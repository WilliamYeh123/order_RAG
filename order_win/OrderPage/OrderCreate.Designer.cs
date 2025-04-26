namespace order_win.OrderPage
{
    partial class OrderCreate
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewAddedProduct = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            categoryBindingSource = new BindingSource(components);
            label3 = new Label();
            label4 = new Label();
            OrderProductInput = new ComboBox();
            label5 = new Label();
            OrderCountInput = new TextBox();
            buttonAddProduct = new Button();
            OrderCategoryInput = new ComboBox();
            labelTotalPrice = new Label();
            OrderSubmitBtn = new Button();
            label6 = new Label();
            OrderCustomerInput = new ComboBox();
            OrderCancelBtn = new Button();
            id = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            productname = new DataGridViewTextBoxColumn();
            count = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            remove = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddedProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAddedProduct
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewAddedProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAddedProduct.BackgroundColor = SystemColors.Control;
            dataGridViewAddedProduct.BorderStyle = BorderStyle.None;
            dataGridViewAddedProduct.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewAddedProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft JhengHei UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAddedProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAddedProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAddedProduct.Columns.AddRange(new DataGridViewColumn[] { id, price, productname, count, subtotal, remove });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft JhengHei UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewAddedProduct.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewAddedProduct.GridColor = SystemColors.Control;
            dataGridViewAddedProduct.Location = new Point(149, 53);
            dataGridViewAddedProduct.Name = "dataGridViewAddedProduct";
            dataGridViewAddedProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewAddedProduct.RowHeadersVisible = false;
            dataGridViewAddedProduct.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewAddedProduct.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewAddedProduct.Size = new Size(528, 188);
            dataGridViewAddedProduct.TabIndex = 0;
            dataGridViewAddedProduct.CellContentClick += dataGridViewOrderItems_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("標楷體", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(73, 26);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "已加入";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("標楷體", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(73, 300);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "加入商品";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("標楷體", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(73, 336);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 3;
            label3.Text = "分類:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("標楷體", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(257, 336);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 3;
            label4.Text = "商品:";
            // 
            // OrderProductInput
            // 
            OrderProductInput.FormattingEnabled = true;
            OrderProductInput.Location = new Point(257, 356);
            OrderProductInput.Name = "OrderProductInput";
            OrderProductInput.Size = new Size(151, 27);
            OrderProductInput.TabIndex = 2;
            OrderProductInput.Text = "--Select--";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("標楷體", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(438, 336);
            label5.Name = "label5";
            label5.Size = new Size(53, 17);
            label5.TabIndex = 3;
            label5.Text = "數量:";
            // 
            // OrderCountInput
            // 
            OrderCountInput.Location = new Point(438, 356);
            OrderCountInput.Name = "OrderCountInput";
            OrderCountInput.Size = new Size(125, 27);
            OrderCountInput.TabIndex = 4;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.BackColor = SystemColors.ControlDark;
            buttonAddProduct.Font = new Font("標楷體", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            buttonAddProduct.ForeColor = SystemColors.ButtonHighlight;
            buttonAddProduct.Location = new Point(616, 334);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(94, 68);
            buttonAddProduct.TabIndex = 5;
            buttonAddProduct.Text = "加入";
            buttonAddProduct.UseVisualStyleBackColor = false;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // OrderCategoryInput
            // 
            OrderCategoryInput.FormattingEnabled = true;
            OrderCategoryInput.Location = new Point(73, 356);
            OrderCategoryInput.Name = "OrderCategoryInput";
            OrderCategoryInput.Size = new Size(141, 27);
            OrderCategoryInput.TabIndex = 6;
            OrderCategoryInput.Text = "--Select--";
            OrderCategoryInput.SelectedIndexChanged += OrderCategoryInput_SelectedIndexChanged;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("標楷體", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelTotalPrice.ForeColor = SystemColors.ActiveCaptionText;
            labelTotalPrice.Location = new Point(532, 261);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(107, 17);
            labelTotalPrice.TabIndex = 7;
            labelTotalPrice.Text = "總價:  0 元";
            labelTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            labelTotalPrice.Click += labelTotalPrice_Click;
            // 
            // OrderSubmitBtn
            // 
            OrderSubmitBtn.BackColor = SystemColors.ActiveCaption;
            OrderSubmitBtn.ForeColor = SystemColors.ActiveCaptionText;
            OrderSubmitBtn.Location = new Point(569, 447);
            OrderSubmitBtn.Name = "OrderSubmitBtn";
            OrderSubmitBtn.Size = new Size(141, 50);
            OrderSubmitBtn.TabIndex = 8;
            OrderSubmitBtn.Text = "送出";
            OrderSubmitBtn.UseVisualStyleBackColor = false;
            OrderSubmitBtn.Click += OrderSubmitBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("標楷體", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(73, 417);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 3;
            label6.Text = "顧客:";
            // 
            // OrderCustomerInput
            // 
            OrderCustomerInput.FormattingEnabled = true;
            OrderCustomerInput.Location = new Point(73, 437);
            OrderCustomerInput.Name = "OrderCustomerInput";
            OrderCustomerInput.Size = new Size(141, 27);
            OrderCustomerInput.TabIndex = 6;
            OrderCustomerInput.Text = "--Select--";
            OrderCustomerInput.SelectedIndexChanged += OrderCategoryInput_SelectedIndexChanged;
            // 
            // OrderCancelBtn
            // 
            OrderCancelBtn.BackColor = Color.FromArgb(255, 192, 192);
            OrderCancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            OrderCancelBtn.Location = new Point(438, 447);
            OrderCancelBtn.Name = "OrderCancelBtn";
            OrderCancelBtn.Size = new Size(125, 50);
            OrderCancelBtn.TabIndex = 9;
            OrderCancelBtn.Text = "取消";
            OrderCancelBtn.UseVisualStyleBackColor = false;
            OrderCancelBtn.Click += OrderCancelBtn_Click;
            // 
            // id
            // 
            id.HeaderText = "";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            id.Width = 125;
            // 
            // price
            // 
            price.HeaderText = "商品價格";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Visible = false;
            price.Width = 125;
            // 
            // productname
            // 
            productname.HeaderText = "商品名稱";
            productname.MinimumWidth = 6;
            productname.Name = "productname";
            productname.ReadOnly = true;
            productname.Width = 200;
            // 
            // count
            // 
            count.HeaderText = "數量";
            count.MinimumWidth = 6;
            count.Name = "count";
            count.Width = 125;
            // 
            // subtotal
            // 
            subtotal.HeaderText = "價格";
            subtotal.MinimumWidth = 6;
            subtotal.Name = "subtotal";
            subtotal.ReadOnly = true;
            subtotal.Width = 150;
            // 
            // remove
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            remove.DefaultCellStyle = dataGridViewCellStyle3;
            remove.HeaderText = "移除";
            remove.MinimumWidth = 6;
            remove.Name = "remove";
            remove.Text = "移除";
            remove.Width = 50;
            // 
            // OrderCreate
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 520);
            Controls.Add(OrderCancelBtn);
            Controls.Add(OrderSubmitBtn);
            Controls.Add(labelTotalPrice);
            Controls.Add(OrderCustomerInput);
            Controls.Add(OrderCategoryInput);
            Controls.Add(buttonAddProduct);
            Controls.Add(OrderCountInput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(OrderProductInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewAddedProduct);
            ForeColor = SystemColors.Control;
            Name = "OrderCreate";
            Text = "OrderCreate";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddedProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAddedProduct;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox OrderProductInput;
        private Label label5;
        private TextBox OrderCountInput;
        private Button buttonAddProduct;
        private BindingSource categoryBindingSource;
        private ComboBox OrderCategoryInput;
        private Label labelTotalPrice;
        private Button OrderSubmitBtn;
        private Label label6;
        private ComboBox OrderCustomerInput;
        private Button OrderCancelBtn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn productname;
        private DataGridViewTextBoxColumn count;
        private DataGridViewTextBoxColumn subtotal;
        private DataGridViewButtonColumn remove;
        private DataGridViewTextBoxColumn price;
    }
}