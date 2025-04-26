namespace order_win.OrderPage
{
    partial class OrderDetail
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridViewOrderDetail = new DataGridView();
            product_name = new DataGridViewTextBoxColumn();
            product_price = new DataGridViewTextBoxColumn();
            product_count = new DataGridViewTextBoxColumn();
            product_subtotal = new DataGridViewTextBoxColumn();
            detailOrderNumber = new Label();
            detailCustomer = new Label();
            detailCreateTime = new Label();
            detailTotalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 39);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 0;
            label1.Text = "order number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 80);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 0;
            label2.Text = "customer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 126);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 0;
            label3.Text = "create time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 175);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 0;
            label4.Text = "total price:";
            // 
            // dataGridViewOrderDetail
            // 
            dataGridViewOrderDetail.AllowUserToAddRows = false;
            dataGridViewOrderDetail.Anchor = AnchorStyles.None;
            dataGridViewOrderDetail.BackgroundColor = SystemColors.Control;
            dataGridViewOrderDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderDetail.Columns.AddRange(new DataGridViewColumn[] { product_name, product_price, product_count, product_subtotal });
            dataGridViewOrderDetail.Location = new Point(80, 222);
            dataGridViewOrderDetail.Name = "dataGridViewOrderDetail";
            dataGridViewOrderDetail.RowHeadersVisible = false;
            dataGridViewOrderDetail.RowHeadersWidth = 51;
            dataGridViewOrderDetail.Size = new Size(503, 188);
            dataGridViewOrderDetail.TabIndex = 1;
            // 
            // product_name
            // 
            product_name.HeaderText = "商品名稱";
            product_name.MinimumWidth = 6;
            product_name.Name = "product_name";
            product_name.Width = 125;
            // 
            // product_price
            // 
            product_price.HeaderText = "商品價格";
            product_price.MinimumWidth = 6;
            product_price.Name = "product_price";
            product_price.Width = 125;
            // 
            // product_count
            // 
            product_count.HeaderText = "數量";
            product_count.MinimumWidth = 6;
            product_count.Name = "product_count";
            product_count.Width = 125;
            // 
            // product_subtotal
            // 
            product_subtotal.HeaderText = "合計子項";
            product_subtotal.MinimumWidth = 6;
            product_subtotal.Name = "product_subtotal";
            product_subtotal.Width = 125;
            // 
            // detailOrderNumber
            // 
            detailOrderNumber.AutoSize = true;
            detailOrderNumber.BackColor = SystemColors.Control;
            detailOrderNumber.Location = new Point(389, 39);
            detailOrderNumber.Name = "detailOrderNumber";
            detailOrderNumber.Size = new Size(44, 19);
            detailOrderNumber.TabIndex = 2;
            detailOrderNumber.Text = "none";
            // 
            // detailCustomer
            // 
            detailCustomer.AutoSize = true;
            detailCustomer.Location = new Point(389, 80);
            detailCustomer.Name = "detailCustomer";
            detailCustomer.Size = new Size(44, 19);
            detailCustomer.TabIndex = 2;
            detailCustomer.Text = "none";
            // 
            // detailCreateTime
            // 
            detailCreateTime.AutoSize = true;
            detailCreateTime.Location = new Point(389, 126);
            detailCreateTime.Name = "detailCreateTime";
            detailCreateTime.Size = new Size(44, 19);
            detailCreateTime.TabIndex = 2;
            detailCreateTime.Text = "none";
            // 
            // detailTotalPrice
            // 
            detailTotalPrice.AutoSize = true;
            detailTotalPrice.Location = new Point(389, 175);
            detailTotalPrice.Name = "detailTotalPrice";
            detailTotalPrice.Size = new Size(44, 19);
            detailTotalPrice.TabIndex = 2;
            detailTotalPrice.Text = "none";
            // 
            // OrderDetail
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 450);
            Controls.Add(detailTotalPrice);
            Controls.Add(detailCreateTime);
            Controls.Add(detailCustomer);
            Controls.Add(detailOrderNumber);
            Controls.Add(dataGridViewOrderDetail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderDetail";
            Text = "OrderDetail";
            Load += OrderDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewOrderDetail;
        private Label detailOrderNumber;
        private Label detailCustomer;
        private Label detailCreateTime;
        private Label detailTotalPrice;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn product_price;
        private DataGridViewTextBoxColumn product_count;
        private DataGridViewTextBoxColumn product_subtotal;
    }
}