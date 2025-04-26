using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using order_win.Data;
using order_win.Models;
using order_win.ProductPage;

namespace order_win.OrderPage
{
    public partial class OrderCreate : Form
    {
        private OrderManagement _parentForm;
        private readonly AppDbContext _context;
        public OrderCreate(OrderManagement parentForm)
        {
            InitializeComponent();
            LoadCategories();
            LoadCustomers();

            _parentForm = parentForm;
            _context = new AppDbContext();
        }
        private void LoadCategories()
        {
            using (var context = new AppDbContext())
            {
                var categories = context.Categories.ToList();
                categories.Insert(0, new Category { Id = -1, Name = "--Select--" });
                OrderCategoryInput.DataSource = categories;
                OrderCategoryInput.DisplayMember = "Name";
                OrderCategoryInput.ValueMember = "Id";
            }
        }
        private void LoadCustomers()
        {
            using (var context = new AppDbContext())
            {
                var customers = context.Customers.ToList();
                customers.Insert(0, new Customer { Id = -1, Name = "--Select--" });
                OrderCustomerInput.DataSource = customers;
                OrderCustomerInput.DisplayMember = "Name";
                OrderCustomerInput.ValueMember = "Id";
            }
        }
        private void OrderCategoryInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(OrderCategoryInput.SelectedValue);
            try
            {
                if (OrderCategoryInput.SelectedValue is int categoryId && categoryId != -1)
                {
                    using (var context = new AppDbContext())
                    {
                        var products = context.Products
                            .Where(p => p.CategoryId == categoryId)
                            .ToList();

                        OrderProductInput.DataSource = products;
                        OrderProductInput.DisplayMember = "Name";
                        OrderProductInput.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入產品時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (int.TryParse(OrderCountInput.Text, out int count) && count > 0)
            {
                var product = (Product)OrderProductInput.SelectedItem;
                var subtotal = product.Price * count;

                int rowIndex = dataGridViewAddedProduct.Rows.Add();
                var row = dataGridViewAddedProduct.Rows[rowIndex];
                row.Cells["productname"].Value = product.Name;
                row.Cells["id"].Value = product.Id;
                row.Cells["count"].Value = count;
                row.Cells["subtotal"].Value = subtotal;
                row.Cells["price"].Value = product.Price;


                CalculateTotalPrice();
            }
            else
            {
                MessageBox.Show("請輸入正確的商品數量！");
            }
        }
        private void CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridViewAddedProduct.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }
            labelTotalPrice.Text = $"總價：{total:C}";
        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private async void OrderSubmitBtn_Click(object sender, EventArgs e)
        {
            if (OrderProductInput.SelectedValue == null)
            {
                MessageBox.Show("請選擇顧客", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var customerId = (int)OrderCustomerInput.SelectedValue;
            var orderNumber = Guid.NewGuid().ToString(); ;
            var createdTime = DateTime.UtcNow;

            var orderProducts = new List<OrderProduct>();
            decimal totalPrice = 0;
            var productDescriptions = new List<string>();

            using (var context = new AppDbContext())
            {
                foreach (DataGridViewRow row in dataGridViewAddedProduct.Rows)
                {
                    if (row.IsNewRow) continue;

                    var productId = Convert.ToInt32(row.Cells["id"].Value);
                    var count = Convert.ToInt32(row.Cells["count"].Value);

                    var product = context.Products.FirstOrDefault(p => p.Id == productId);
                    if (product == null) continue;

                    totalPrice += product.Price * count;
                    //productDescriptions.Add($"{count}個{product.Name}(${product.Price})");
                    productDescriptions.Add($" {product.Name}(${product.Price}) x {count}(quantity)");

                    orderProducts.Add(new OrderProduct
                    {
                        ProductId = productId,
                        Count = count
                    });
                }

                var customer = context.Customers.FirstOrDefault(c => c.Id == customerId);

                var order = new Order
                {
                    OrderNumber = orderNumber,
                    CreatedTime = createdTime,
                    CustomerId = customerId,
                    TotalPrice = totalPrice,
                    OrderProducts = orderProducts
                };


                // Send to RAG API
                if (customer != null)
                {
                    var text = $"Order {orderNumber}: Customer {customer.Name} bought {string.Join(", ", productDescriptions)}. Total: ${totalPrice}. Date: {createdTime:yyyy-MM-dd}";
                    // var text = $"訂單編號 {orderNumber}: 顧客 {customer.Name}在{createdTime:yyyy-MM-dd}買了 {string.Join("、", productDescriptions)}，總共{totalPrice}元。";
                    var json = JsonConvert.SerializeObject(new
                    {
                        type = "order",
                        id = orderNumber,
                        text = text
                    });

                    try
                    {
                        using (var http = new HttpClient())
                        {
                            var content = new StringContent(json, Encoding.UTF8, "application/json");
                            var response = await http.PostAsync("http://localhost:8000/embed", content);
                        }
                    }
                    catch (Exception ex)
                    {
                        // 可以記錄 log
                        MessageBox.Show("訂單建立成功，但向量嵌入失敗。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine($"Vector DB 儲存錯誤: {ex.Message}");
                        return;
                    }


                    context.Orders.Add(order);
                    context.SaveChanges();
                }
            }

            MessageBox.Show("訂單建立成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 清除畫面資料
            dataGridViewAddedProduct.Rows.Clear();
            labelTotalPrice.Text = "總價:  0 元";

            _parentForm.LoadOrderData();
            this.Close();
        }
        private void OrderCancelBtn_Click(object sender, EventArgs e)
        {
            _parentForm.LoadOrderData();
            this.Close();
        }
        private void dataGridViewOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 確認不是點擊標題列且是點擊 remove 欄位
            if (e.RowIndex >= 0 && dataGridViewAddedProduct.Columns[e.ColumnIndex].Name == "remove")
            {
                // 確認是否真的要刪除
                var result = MessageBox.Show("確定要移除此商品嗎？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dataGridViewAddedProduct.Rows.RemoveAt(e.RowIndex);
                    RecalculateTotalPrice();
                }
            }
        }
        private void RecalculateTotalPrice()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridViewAddedProduct.Rows)
            {
                if (row.IsNewRow) continue;

                var priceCell = row.Cells["price"];
                var countCell = row.Cells["count"];

                if (decimal.TryParse(priceCell.Value?.ToString(), out decimal price) &&
                    int.TryParse(countCell.Value?.ToString(), out int count))
                {
                    total += price * count;
                }
            }

            labelTotalPrice.Text = total.ToString("0.##");
        }
    }
}
