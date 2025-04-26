using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using order_win.CustomerPage;
using order_win.Data;
using order_win.Models;

namespace order_win.ProductPage
{
    public partial class ProductManagement : Form
    {
        private readonly AppDbContext _context;
        private List<Category> _categories;
        public ProductManagement()
        {
            InitializeComponent();
            _context = new AppDbContext();  // 建立資料庫連線
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            SetupCategoryComboBoxColumn();
            LoadProductData();
            buttonUpdateProduct.Visible = false;
        }
        private void SetupCategoryComboBoxColumn()
        {
            using (var context = new AppDbContext())
            {
                _categories = context.Categories.ToList();
            }

            var comboColumn = (DataGridViewComboBoxColumn)dataGridViewProducts.Columns["category"];
            comboColumn.DataSource = _categories;
            comboColumn.DisplayMember = "Name";
            comboColumn.ValueMember = "Id";
        }
        private void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            ProductCreate productCreate = new ProductCreate(this);
            productCreate.ShowDialog(); // 顯示顧客管理畫面
        }
        public void LoadProductData()
        {
            using (var context = new AppDbContext())
            {
                var products = context.Products.ToList();
                dataGridViewProducts.Rows.Clear();

                foreach (var product in products)
                {
                    int rowIndex = dataGridViewProducts.Rows.Add();
                    var row = dataGridViewProducts.Rows[rowIndex];

                    row.Cells["check"].Value = false;
                    row.Cells["name"].Value = product.Name;
                    row.Cells["category"].Value = product.CategoryId;
                    row.Cells["price"].Value = product.Price;
                    row.Cells["id"].Value = product.Id;
                    row.Cells["uid"].Value = product.UID;
                    row.Tag = product.Id;
                }
            }
        }

        private async void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            var selectedIds = new List<int>();
            var vectorIdsToDelete = new List<string>();

            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["check"].Value);
                if (isChecked && row.Tag != null)
                {
                    int productId = (int)row.Tag;
                    selectedIds.Add(productId);
                    vectorIdsToDelete.Add((string)row.Cells["uid"].Value);
                }
            }

            if (selectedIds.Any())
            {
                using (var context = new AppDbContext())
                {
                    var productsToDelete = context.Products
                        .Where(c => selectedIds.Contains(c.Id))
                        .ToList();

                    context.Products.RemoveRange(productsToDelete);
                    context.SaveChanges();
                }
                // 呼叫向量刪除 API
                var json = JsonConvert.SerializeObject(new { ids = vectorIdsToDelete, type="product" });

                using (var http = new HttpClient())
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await http.PostAsync("http://localhost:8000/delete", content);
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("商品刪除成功，但向量刪除失敗。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                LoadProductData(); // 重新載入資料
            }
        }
        private void dataGridViewProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 檢查是否有customer被勾選
            if (e.ColumnIndex == dataGridViewProducts.Columns["check"].Index)
            {
                buttonDeleteProduct.Enabled = dataGridViewProducts.Rows
                    .Cast<DataGridViewRow>()
                    .Any(row => Convert.ToBoolean(row.Cells["check"].Value));
            }

            // 檢查customer資料被修改
            var editableColumns = new[] { "name", "category", "price" };
            string columnName = dataGridViewProducts.Columns[e.ColumnIndex].Name;
            if (editableColumns.Contains(columnName))
            {
                buttonUpdateProduct.Visible = true; // 有人改過資料就顯示按鈕
            }

        }
        private void dataGridViewProducts_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.IsCurrentCellDirty)
            {
                dataGridViewProducts.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext()) // 建議在這裡統一使用一個 context
            {
                foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                {
                    if (row.IsNewRow) continue;

                    int id = Convert.ToInt32(row.Cells["id"].Value);
                    var product = context.Products.FirstOrDefault(c => c.Id == id);
                    if (product != null)
                    {
                        product.Name = row.Cells["name"].Value?.ToString() ?? "";
                        if (decimal.TryParse(row.Cells["price"].Value?.ToString(), out decimal price))
                        {
                            product.Price = price;
                        }
                        else
                        {
                            // 顯示錯誤或忽略
                            MessageBox.Show("價格格式錯誤！");
                            continue; // 或 return / skip 處理
                        }
                        if (int.TryParse(row.Cells["category"].Value?.ToString(), out int categoryId))
                        {
                            product.CategoryId = categoryId;
                        }
                        else
                        {
                            MessageBox.Show("請選擇正確的分類！");
                            continue; // 或 return / skip 處理
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

            buttonUpdateProduct.Visible = false;
            LoadProductData();
        }
    }
}
