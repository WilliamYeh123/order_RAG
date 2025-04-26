namespace order_win.OrderPage
{
    partial class OrderManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            OrderListTitle = new Label();
            dataGridViewOrders = new DataGridView();
            check = new DataGridViewCheckBoxColumn();
            id = new DataGridViewTextBoxColumn();
            uid = new DataGridViewLinkColumn();
            date = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            totalprice = new DataGridViewTextBoxColumn();
            buttonCreateOrder = new Button();
            buttonDeleteOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // OrderListTitle
            // 
            OrderListTitle.AutoSize = true;
            OrderListTitle.Font = new Font("標楷體", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 136);
            OrderListTitle.Location = new Point(87, 57);
            OrderListTitle.Name = "OrderListTitle";
            OrderListTitle.Size = new Size(195, 44);
            OrderListTitle.TabIndex = 1;
            OrderListTitle.Text = "訂單管理";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { check, id, uid, date, customer, totalprice });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOrders.Location = new Point(87, 151);
            dataGridViewOrders.Margin = new Padding(4);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewOrders.RowHeadersWidth = 62;
            dataGridViewOrders.Size = new Size(802, 330);
            dataGridViewOrders.TabIndex = 2;
            dataGridViewOrders.CellContentClick += dataGridViewOrders_CellContentClick;
            dataGridViewOrders.CellValueChanged += dataGridViewOrders_CellValueChanged;
            dataGridViewOrders.CurrentCellDirtyStateChanged += dataGridViewOrders_CurrentCellDirtyStateChanged;
            // 
            // check
            // 
            check.HeaderText = "";
            check.MinimumWidth = 6;
            check.Name = "check";
            check.Width = 50;
            // 
            // id
            // 
            id.HeaderText = "";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            id.Width = 125;
            // 
            // uid
            // 
            uid.HeaderText = "編號";
            uid.MinimumWidth = 6;
            uid.Name = "uid";
            uid.Resizable = DataGridViewTriState.True;
            uid.SortMode = DataGridViewColumnSortMode.Automatic;
            uid.Width = 300;
            // 
            // date
            // 
            date.HeaderText = "建立時間";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 200;
            // 
            // customer
            // 
            customer.HeaderText = "顧客";
            customer.MinimumWidth = 6;
            customer.Name = "customer";
            customer.Width = 125;
            // 
            // totalprice
            // 
            totalprice.HeaderText = "總價";
            totalprice.MinimumWidth = 6;
            totalprice.Name = "totalprice";
            totalprice.Width = 125;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.BackColor = SystemColors.ButtonFace;
            buttonCreateOrder.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonCreateOrder.Location = new Point(618, 97);
            buttonCreateOrder.Margin = new Padding(4);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(130, 50);
            buttonCreateOrder.TabIndex = 3;
            buttonCreateOrder.Text = "新增";
            buttonCreateOrder.UseVisualStyleBackColor = false;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.BackColor = Color.Red;
            buttonDeleteOrder.Enabled = false;
            buttonDeleteOrder.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonDeleteOrder.ForeColor = SystemColors.ButtonHighlight;
            buttonDeleteOrder.ImageAlign = ContentAlignment.TopCenter;
            buttonDeleteOrder.Location = new Point(756, 97);
            buttonDeleteOrder.Margin = new Padding(4);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(130, 50);
            buttonDeleteOrder.TabIndex = 5;
            buttonDeleteOrder.Text = "刪除";
            buttonDeleteOrder.UseVisualStyleBackColor = false;
            buttonDeleteOrder.Click += buttonDeleteOrder_Click;
            // 
            // OrderManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 557);
            Controls.Add(buttonDeleteOrder);
            Controls.Add(buttonCreateOrder);
            Controls.Add(dataGridViewOrders);
            Controls.Add(OrderListTitle);
            Name = "OrderManagement";
            Text = "OrderManagement";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OrderListTitle;
        private DataGridView dataGridViewOrders;
        private DataGridViewCheckBoxColumn check;
        private DataGridViewTextBoxColumn id;
        private DataGridViewLinkColumn uid;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn totalprice;
        private Button buttonCreateOrder;
        private Button buttonDeleteOrder;
    }
}