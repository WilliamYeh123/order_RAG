namespace order_win.ProductPage
{
    partial class ProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ProductListTitle = new Label();
            dataGridViewProducts = new DataGridView();
            categoryBindingSource = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            buttonCreateProduct = new Button();
            buttonDeleteProduct = new Button();
            buttonUpdateProduct = new Button();
            check = new DataGridViewCheckBoxColumn();
            uid = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            category = new DataGridViewComboBoxColumn();
            price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ProductListTitle
            // 
            ProductListTitle.AutoSize = true;
            ProductListTitle.Font = new Font("標楷體", 48F, FontStyle.Regular, GraphicsUnit.Point, 136);
            ProductListTitle.Location = new Point(12, 36);
            ProductListTitle.Name = "ProductListTitle";
            ProductListTitle.Size = new Size(354, 80);
            ProductListTitle.TabIndex = 0;
            ProductListTitle.Text = "產品管理";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { check, uid, id, name, category, price });
            dataGridViewProducts.Location = new Point(211, 169);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(578, 330);
            dataGridViewProducts.TabIndex = 1;
            dataGridViewProducts.CellValueChanged += dataGridViewProducts_CellValueChanged;
            dataGridViewProducts.CurrentCellDirtyStateChanged += dataGridViewProducts_CurrentCellDirtyStateChanged;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // buttonCreateProduct
            // 
            buttonCreateProduct.BackColor = SystemColors.ButtonFace;
            buttonCreateProduct.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonCreateProduct.Location = new Point(684, 68);
            buttonCreateProduct.Margin = new Padding(4);
            buttonCreateProduct.Name = "buttonCreateProduct";
            buttonCreateProduct.Size = new Size(130, 50);
            buttonCreateProduct.TabIndex = 3;
            buttonCreateProduct.Text = "新增";
            buttonCreateProduct.UseVisualStyleBackColor = false;
            buttonCreateProduct.Click += buttonCreateProduct_Click;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.BackColor = Color.Red;
            buttonDeleteProduct.Enabled = false;
            buttonDeleteProduct.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonDeleteProduct.ForeColor = SystemColors.ButtonHighlight;
            buttonDeleteProduct.ImageAlign = ContentAlignment.TopCenter;
            buttonDeleteProduct.Location = new Point(822, 68);
            buttonDeleteProduct.Margin = new Padding(4);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(130, 50);
            buttonDeleteProduct.TabIndex = 4;
            buttonDeleteProduct.Text = "刪除";
            buttonDeleteProduct.UseVisualStyleBackColor = false;
            buttonDeleteProduct.Click += buttonDeleteProduct_Click;
            // 
            // buttonUpdateProduct
            // 
            buttonUpdateProduct.BackColor = Color.FromArgb(128, 255, 128);
            buttonUpdateProduct.Location = new Point(731, 519);
            buttonUpdateProduct.Name = "buttonUpdateProduct";
            buttonUpdateProduct.Size = new Size(130, 39);
            buttonUpdateProduct.TabIndex = 5;
            buttonUpdateProduct.Text = "更新";
            buttonUpdateProduct.UseVisualStyleBackColor = false;
            buttonUpdateProduct.Visible = false;
            buttonUpdateProduct.Click += buttonUpdateProduct_Click;
            // 
            // check
            // 
            check.HeaderText = "";
            check.MinimumWidth = 6;
            check.Name = "check";
            check.Width = 50;
            // 
            // uid
            // 
            uid.HeaderText = "";
            uid.MinimumWidth = 6;
            uid.Name = "uid";
            uid.Visible = false;
            uid.Width = 125;
            // 
            // id
            // 
            id.HeaderText = "";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            id.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "名稱";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 200;
            // 
            // category
            // 
            category.DataSource = categoryBindingSource;
            category.DisplayMember = "Name";
            category.HeaderText = "分類";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.ValueMember = "Id";
            category.Width = 200;
            // 
            // price
            // 
            price.HeaderText = "價格";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 125;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 570);
            Controls.Add(buttonUpdateProduct);
            Controls.Add(buttonDeleteProduct);
            Controls.Add(buttonCreateProduct);
            Controls.Add(dataGridViewProducts);
            Controls.Add(ProductListTitle);
            Name = "ProductManagement";
            Text = "ProductManagement";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProductListTitle;
        private DataGridView dataGridViewProducts;
        private Button buttonCreateProduct;
        private BindingSource categoryBindingSource;
        private BindingSource productBindingSource;
        private Button buttonDeleteProduct;
        private Button buttonUpdateProduct;
        private DataGridViewCheckBoxColumn check;
        private DataGridViewTextBoxColumn uid;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewComboBoxColumn category;
        private DataGridViewTextBoxColumn price;
    }
}