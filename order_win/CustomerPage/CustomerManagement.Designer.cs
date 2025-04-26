namespace order_win.CustomerPage
{
    partial class CustomerManagement
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
            dataGridViewCustomers = new DataGridView();
            CustomerListTitle = new Label();
            buttonCreateCustomer = new Button();
            buttonDeleteCustomer = new Button();
            buttonUpdateCustomer = new Button();
            check = new DataGridViewCheckBoxColumn();
            id = new DataGridViewTextBoxColumn();
            uid = new DataGridViewTextBoxColumn();
            image = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            gender = new DataGridViewComboBoxColumn();
            bloodtype = new DataGridViewComboBoxColumn();
            subscribe = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AllowUserToAddRows = false;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Columns.AddRange(new DataGridViewColumn[] { check, id, uid, image, name, email, gender, bloodtype, subscribe });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCustomers.Location = new Point(73, 149);
            dataGridViewCustomers.Margin = new Padding(4);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersVisible = false;
            dataGridViewCustomers.RowHeadersWidth = 62;
            dataGridViewCustomers.Size = new Size(900, 330);
            dataGridViewCustomers.TabIndex = 0;
            dataGridViewCustomers.CellValueChanged += dataGridViewCustomers_CellValueChanged;
            dataGridViewCustomers.CurrentCellDirtyStateChanged += dataGridViewCustomers_CurrentCellDirtyStateChanged;
            // 
            // CustomerListTitle
            // 
            CustomerListTitle.AutoSize = true;
            CustomerListTitle.Font = new Font("標楷體", 48F, FontStyle.Regular, GraphicsUnit.Point, 136);
            CustomerListTitle.Location = new Point(56, 26);
            CustomerListTitle.Margin = new Padding(4, 0, 4, 0);
            CustomerListTitle.Name = "CustomerListTitle";
            CustomerListTitle.Size = new Size(354, 80);
            CustomerListTitle.TabIndex = 1;
            CustomerListTitle.Text = "顧客管理";
            // 
            // buttonCreateCustomer
            // 
            buttonCreateCustomer.BackColor = SystemColors.ButtonFace;
            buttonCreateCustomer.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonCreateCustomer.Location = new Point(689, 57);
            buttonCreateCustomer.Margin = new Padding(4);
            buttonCreateCustomer.Name = "buttonCreateCustomer";
            buttonCreateCustomer.Size = new Size(130, 50);
            buttonCreateCustomer.TabIndex = 2;
            buttonCreateCustomer.Text = "新增";
            buttonCreateCustomer.UseVisualStyleBackColor = false;
            buttonCreateCustomer.Click += buttonCreateCustomer_Click;
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.BackColor = Color.Red;
            buttonDeleteCustomer.Enabled = false;
            buttonDeleteCustomer.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonDeleteCustomer.ForeColor = SystemColors.ButtonHighlight;
            buttonDeleteCustomer.ImageAlign = ContentAlignment.TopCenter;
            buttonDeleteCustomer.Location = new Point(826, 57);
            buttonDeleteCustomer.Margin = new Padding(4);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(130, 50);
            buttonDeleteCustomer.TabIndex = 2;
            buttonDeleteCustomer.Text = "刪除";
            buttonDeleteCustomer.UseVisualStyleBackColor = false;
            buttonDeleteCustomer.Click += buttonDeleteCustomer_Click;
            // 
            // buttonUpdateCustomer
            // 
            buttonUpdateCustomer.BackColor = Color.FromArgb(128, 255, 128);
            buttonUpdateCustomer.Location = new Point(826, 500);
            buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            buttonUpdateCustomer.Size = new Size(130, 39);
            buttonUpdateCustomer.TabIndex = 3;
            buttonUpdateCustomer.Text = "更新";
            buttonUpdateCustomer.UseVisualStyleBackColor = false;
            buttonUpdateCustomer.Visible = false;
            buttonUpdateCustomer.Click += buttonUpdateCustomer_Click;
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
            uid.HeaderText = "";
            uid.MinimumWidth = 6;
            uid.Name = "uid";
            uid.Visible = false;
            uid.Width = 125;
            // 
            // image
            // 
            image.HeaderText = "圖片";
            image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            image.MinimumWidth = 6;
            image.Name = "image";
            image.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "姓名";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 200;
            // 
            // email
            // 
            email.HeaderText = "信箱";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 300;
            // 
            // gender
            // 
            gender.HeaderText = "性別";
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.MinimumWidth = 6;
            gender.Name = "gender";
            gender.Resizable = DataGridViewTriState.True;
            gender.SortMode = DataGridViewColumnSortMode.Automatic;
            gender.Width = 125;
            // 
            // bloodtype
            // 
            bloodtype.HeaderText = "血型";
            bloodtype.Items.AddRange(new object[] { "A", "B", "AB", "O" });
            bloodtype.MinimumWidth = 6;
            bloodtype.Name = "bloodtype";
            bloodtype.Resizable = DataGridViewTriState.True;
            bloodtype.SortMode = DataGridViewColumnSortMode.Automatic;
            bloodtype.Width = 50;
            // 
            // subscribe
            // 
            subscribe.HeaderText = "訂閱";
            subscribe.MinimumWidth = 6;
            subscribe.Name = "subscribe";
            subscribe.Resizable = DataGridViewTriState.True;
            subscribe.SortMode = DataGridViewColumnSortMode.Automatic;
            subscribe.Width = 50;
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1028, 570);
            Controls.Add(buttonUpdateCustomer);
            Controls.Add(buttonDeleteCustomer);
            Controls.Add(buttonCreateCustomer);
            Controls.Add(CustomerListTitle);
            Controls.Add(dataGridViewCustomers);
            Margin = new Padding(4);
            Name = "CustomerManagement";
            Text = "CustomerManagement";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCustomers;
        private Label CustomerListTitle;
        private Button buttonCreateCustomer;
        private Button buttonDeleteCustomer;
        private Button buttonUpdateCustomer;
        private DataGridViewCheckBoxColumn check;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn uid;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewComboBoxColumn gender;
        private DataGridViewComboBoxColumn bloodtype;
        private DataGridViewCheckBoxColumn subscribe;
    }
}