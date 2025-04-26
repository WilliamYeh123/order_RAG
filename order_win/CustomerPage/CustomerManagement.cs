using Microsoft.EntityFrameworkCore;
using order_win.Data;
//using order_win.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using order_win.Models; // Customer 的命名空間
using Newtonsoft.Json;

namespace order_win.CustomerPage
{
    public partial class CustomerManagement : Form
    {
        private readonly AppDbContext _context;
        public CustomerManagement()
        {
            InitializeComponent();
            _context = new AppDbContext();  // 建立資料庫連線
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
            buttonUpdateCustomer.Visible = false;
        }

        private void buttonCreateCustomer_Click(object sender, EventArgs e)
        {
            CustomerCreate customerCreate = new CustomerCreate(this);
            customerCreate.ShowDialog(); // 顯示顧客管理畫面
        }

        public void LoadCustomerData()
        {
            using (var context = new AppDbContext())
            {
                var customers = context.Customers.ToList();
                dataGridViewCustomers.Rows.Clear();
                dataGridViewCustomers.RowTemplate.Height = 100;

                foreach (var customer in customers)
                {
                    int rowIndex = dataGridViewCustomers.Rows.Add();
                    var row = dataGridViewCustomers.Rows[rowIndex];

                    // 設定圖片欄位
                    if (!string.IsNullOrEmpty(customer.PhotoPath) && File.Exists(customer.PhotoPath))
                    {
                        row.Cells["image"].Value = Image.FromFile(customer.PhotoPath);
                    }

                    row.Cells["check"].Value = false;
                    row.Cells["name"].Value = customer.Name;
                    row.Cells["email"].Value = customer.Email;
                    row.Cells["gender"].Value = customer.Gender;
                    row.Cells["bloodtype"].Value = customer.BloodType;
                    row.Cells["subscribe"].Value = customer.IsSubscribed;// ? "是" : "否";
                    row.Cells["id"].Value = customer.Id;
                    row.Cells["uid"].Value = customer.UID;
                    // 將 ID 存在 row.Tag 或新增隱藏欄位
                    row.Tag = customer.Id;
                }
            }
        }

        private async void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            var selectedIds = new List<int>();
            var vectorIdsToDelete = new List<string>();

            foreach (DataGridViewRow row in dataGridViewCustomers.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["check"].Value);
                if (isChecked && row.Tag != null)
                {
                    int customerId = (int)row.Tag;
                    selectedIds.Add(customerId);
                    vectorIdsToDelete.Add((string)row.Cells["uid"].Value);
                }
            }

            if (selectedIds.Any())
            {
                using (var context = new AppDbContext())
                {
                    var customersToDelete = context.Customers
                        .Where(c => selectedIds.Contains(c.Id))
                        .ToList();

                    context.Customers.RemoveRange(customersToDelete);
                    context.SaveChanges();
                }
                // 呼叫向量刪除 API
                var json = JsonConvert.SerializeObject(new { ids = vectorIdsToDelete, type = "customer" });

                using (var http = new HttpClient())
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await http.PostAsync("http://localhost:8000/delete", content);
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("顧客刪除成功，但向量刪除失敗。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                LoadCustomerData(); // 重新載入資料
            }
        }

        private void dataGridViewCustomers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 檢查是否有customer被勾選
            if (e.ColumnIndex == dataGridViewCustomers.Columns["check"].Index)
            {
                buttonDeleteCustomer.Enabled = dataGridViewCustomers.Rows
                    .Cast<DataGridViewRow>()
                    .Any(row => Convert.ToBoolean(row.Cells["check"].Value));
            }

            // 檢查customer資料被修改
            var editableColumns = new[] { "name", "email", "gender", "bloodtype", "subscribe" };
            string columnName = dataGridViewCustomers.Columns[e.ColumnIndex].Name;
            if (editableColumns.Contains(columnName))
            {
                buttonUpdateCustomer.Visible = true; // 有人改過資料就顯示按鈕
            }

        }
        private void dataGridViewCustomers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.IsCurrentCellDirty)
            {
                dataGridViewCustomers.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext()) // 建議在這裡統一使用一個 context
            {
                foreach (DataGridViewRow row in dataGridViewCustomers.Rows)
                {
                    if (row.IsNewRow) continue;

                    int id = Convert.ToInt32(row.Cells["id"].Value);
                    var customer = context.Customers.FirstOrDefault(c => c.Id == id);
                    if (customer != null)
                    {
                        customer.Name = row.Cells["name"].Value?.ToString() ?? "";
                        customer.Email = row.Cells["email"].Value?.ToString() ?? "";
                        customer.Gender = row.Cells["gender"].Value?.ToString() ?? "";
                        customer.BloodType = row.Cells["bloodtype"].Value?.ToString() ?? "";

                        if (row.Cells["subscribe"].Value != null)
                        {
                            customer.IsSubscribed = Convert.ToBoolean(row.Cells["subscribe"].Value);
                        }
                    }
                }

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("更新成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("更新失敗：" + ex.Message);
                }
            }

            buttonUpdateCustomer.Visible = false;
            LoadCustomerData();
        }
    }
}
