using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using order_win.Data;
using Microsoft.EntityFrameworkCore;
using order_win.ProductPage;
using Newtonsoft.Json;

namespace order_win.OrderPage
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadOrderData();
            buttonDeleteOrder.Enabled = false;
        }

        public void LoadOrderData()
        {
            using (var context = new AppDbContext())
            {
                var orders = context.Orders
                    .Include(o => o.Customer)
                    .ToList();

                dataGridViewOrders.Rows.Clear();

                foreach (var order in orders)
                {
                    int rowIndex = dataGridViewOrders.Rows.Add();
                    var row = dataGridViewOrders.Rows[rowIndex];

                    row.Cells["uid"].Value = order.OrderNumber;
                    row.Cells["id"].Value = order.Id;
                    row.Cells["date"].Value = order.CreatedTime.ToLocalTime().ToString("yyyy-MM-dd HH:mm");
                    row.Cells["totalprice"].Value = order.TotalPrice.ToString("F2");
                    row.Cells["customer"].Value = order.Customer?.Name ?? "未知";
                }
            }
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            OrderCreate orderCreate = new OrderCreate(this);
            orderCreate.ShowDialog();
        }

        private async void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            var vectorIdsToDelete = new List<string>();
            using (var context = new AppDbContext())
            {
                foreach (DataGridViewRow row in dataGridViewOrders.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["check"].Value);
                    if (isChecked)
                    {
                        int orderId = (int)row.Cells["id"].Value;

                        var order = context.Orders
                            .Include(o => o.OrderProducts)
                            .FirstOrDefault(o => o.Id == orderId);

                        if (order != null)
                        {
                            vectorIdsToDelete.Add(order.OrderNumber);
                            context.OrderProducts.RemoveRange(order.OrderProducts);
                            context.Orders.Remove(order);
                        }
                    }
                }
                // 呼叫 delete API 刪除向量
                if (vectorIdsToDelete.Any())
                {
                    var json = JsonConvert.SerializeObject(new { ids = vectorIdsToDelete, type = "order" });

                    using (var http = new HttpClient())
                    {
                        var content = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await http.PostAsync("http://localhost:8000/delete", content);
                        if (!response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("訂單刪除成功，但向量刪除失敗。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                context.SaveChanges();
                LoadOrderData(); // 重新載入表格
            }
        }
        private void dataGridViewOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 檢查是否有customer被勾選
            if (e.ColumnIndex == dataGridViewOrders.Columns["check"].Index)
            {
                buttonDeleteOrder.Enabled = dataGridViewOrders.Rows
                    .Cast<DataGridViewRow>()
                    .Any(row => Convert.ToBoolean(row.Cells["check"].Value));
            }

        }
        private void dataGridViewOrders_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.IsCurrentCellDirty)
            {
                dataGridViewOrders.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewOrders.Columns[e.ColumnIndex].Name == "uid")
            {
                int orderId = (int)dataGridViewOrders.Rows[e.RowIndex].Cells["id"].Value;
                using (var context = new AppDbContext())
                {
                    var order = context.Orders
                        .Include(o => o.Customer)
                        .Include(o => o.OrderProducts)
                            .ThenInclude(op => op.Product)
                        .FirstOrDefault(o => o.Id == orderId);

                    if (order != null)
                    {
                        MessageBox.Show("not null");
                        // 顯示詳細資訊，你可以自訂一個 OrderDetailsForm
                        var detailForm = new OrderDetail(order);
                        detailForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("null");
                    }
                }
            }
        }

    }
    
}
