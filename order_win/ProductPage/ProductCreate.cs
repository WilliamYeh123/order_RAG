using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using order_win.CustomerPage;
using order_win.Data;
using order_win.Models;
using System.Text.Json;
using Newtonsoft.Json;

namespace order_win.ProductPage
{
    public partial class ProductCreate : Form
    {
        private ProductManagement _parentForm;
        private readonly AppDbContext _context;
        public ProductCreate(ProductManagement parentForm)
        {
            InitializeComponent();
            LoadCategories();

            _parentForm = parentForm;
            _context = new AppDbContext();  // 建立資料庫連線
        }
        private void LoadCategories()
        {
            using (var context = new AppDbContext())
            {
                var categories = context.Categories.ToList();
                categories.Insert(0, new Category { Id = -1, Name = "--Select--" });
                ProductCreate_category_input.DataSource = categories;
                ProductCreate_category_input.DisplayMember = "Name";
                ProductCreate_category_input.ValueMember = "Id";
            }
        }

        private async void ProductCreate_save_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(ProductCreate_price_input.Text.Trim(), out decimal price))
            {
                MessageBox.Show("請輸入有效的價格", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string uid = Guid.NewGuid().ToString(); ;
            var selectedValue = ProductCreate_category_input.SelectedValue;
            string category_name = ProductCreate_category_input.Text;
            if (selectedValue != null)
            {
                int categoryId = (int)selectedValue;
                var newProduct = new Product
                {
                    UID = uid,
                    Name = ProductCreate_name_input.Text.Trim(),
                    Price = price,
                    CategoryId = categoryId
                };

                var success = await SendApiRequest(newProduct, category_name);
                if (!success)
                {
                    MessageBox.Show("儲存向量資料失敗，請稍後再試。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _context.Products.Add(newProduct);
                _context.SaveChanges();

            }
            else 
            {
                MessageBox.Show("請選擇有效的分類！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            MessageBox.Show("產品新增成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _parentForm.LoadProductData();
            this.Close();
        }
        private async Task<bool> SendApiRequest(Product newProduct, string category)
        {
            try
            {
                var client = new HttpClient();
                var data = new
                {
                    type = "product",
                    id = newProduct.UID,
                    //text = $"商品{newProduct.Name}的分類(category)是{newProduct.Category?.Name ?? "未分類"}，價格為{newProduct.Price}元。"
                    text = $"Product {newProduct.Name} in {category} category that costs {newProduct.Price} dollars."
                };

                string json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://localhost:8000/embed", content);
                Console.WriteLine($"Vector DB 儲存成功");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                // 可以記錄 log
                Console.WriteLine($"Vector DB 儲存錯誤: {ex.Message}");
                return false;
            }
        }

        private void ProductCreate_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
