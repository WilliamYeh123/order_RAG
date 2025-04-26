namespace order_win.ProductPage
{
    partial class ProductCreate
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
            ProductCreate_name_label = new Label();
            ProductCreate_name_input = new TextBox();
            ProductCreate_category_label = new Label();
            ProductCreate_category_input = new ComboBox();
            ProductCreate_price_label = new Label();
            ProductCreate_price_input = new TextBox();
            ProductCreate_save = new Button();
            ProductCreate_cancel = new Button();
            SuspendLayout();
            // 
            // ProductCreate_name_label
            // 
            ProductCreate_name_label.AutoSize = true;
            ProductCreate_name_label.Location = new Point(150, 72);
            ProductCreate_name_label.Name = "ProductCreate_name_label";
            ProductCreate_name_label.Size = new Size(54, 19);
            ProductCreate_name_label.TabIndex = 0;
            ProductCreate_name_label.Text = "Name:";
            // 
            // ProductCreate_name_input
            // 
            ProductCreate_name_input.Location = new Point(210, 69);
            ProductCreate_name_input.Name = "ProductCreate_name_input";
            ProductCreate_name_input.Size = new Size(188, 27);
            ProductCreate_name_input.TabIndex = 1;
            // 
            // ProductCreate_category_label
            // 
            ProductCreate_category_label.AutoSize = true;
            ProductCreate_category_label.Location = new Point(128, 128);
            ProductCreate_category_label.Name = "ProductCreate_category_label";
            ProductCreate_category_label.Size = new Size(76, 19);
            ProductCreate_category_label.TabIndex = 2;
            ProductCreate_category_label.Text = "Category:";
            // 
            // ProductCreate_category_input
            // 
            ProductCreate_category_input.FormattingEnabled = true;
            ProductCreate_category_input.Location = new Point(210, 125);
            ProductCreate_category_input.Name = "ProductCreate_category_input";
            ProductCreate_category_input.Size = new Size(188, 27);
            ProductCreate_category_input.TabIndex = 3;
            // 
            // ProductCreate_price_label
            // 
            ProductCreate_price_label.AutoSize = true;
            ProductCreate_price_label.Location = new Point(158, 184);
            ProductCreate_price_label.Name = "ProductCreate_price_label";
            ProductCreate_price_label.Size = new Size(46, 19);
            ProductCreate_price_label.TabIndex = 4;
            ProductCreate_price_label.Text = "Price:";
            // 
            // ProductCreate_price_input
            // 
            ProductCreate_price_input.Location = new Point(210, 181);
            ProductCreate_price_input.Name = "ProductCreate_price_input";
            ProductCreate_price_input.Size = new Size(103, 27);
            ProductCreate_price_input.TabIndex = 5;
            ProductCreate_price_input.Text = "0";
            ProductCreate_price_input.TextAlign = HorizontalAlignment.Right;
            // 
            // ProductCreate_save
            // 
            ProductCreate_save.Location = new Point(322, 266);
            ProductCreate_save.Margin = new Padding(4);
            ProductCreate_save.Name = "ProductCreate_save";
            ProductCreate_save.Size = new Size(96, 29);
            ProductCreate_save.TabIndex = 9;
            ProductCreate_save.Text = "Save";
            ProductCreate_save.UseVisualStyleBackColor = true;
            ProductCreate_save.Click += ProductCreate_save_Click;
            // 
            // ProductCreate_cancel
            // 
            ProductCreate_cancel.Location = new Point(443, 266);
            ProductCreate_cancel.Margin = new Padding(4);
            ProductCreate_cancel.Name = "ProductCreate_cancel";
            ProductCreate_cancel.Size = new Size(96, 29);
            ProductCreate_cancel.TabIndex = 10;
            ProductCreate_cancel.Text = "Cancel";
            ProductCreate_cancel.UseVisualStyleBackColor = true;
            ProductCreate_cancel.Click += ProductCreate_cancel_Click;
            // 
            // ProductCreate
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 308);
            Controls.Add(ProductCreate_cancel);
            Controls.Add(ProductCreate_save);
            Controls.Add(ProductCreate_price_input);
            Controls.Add(ProductCreate_price_label);
            Controls.Add(ProductCreate_category_input);
            Controls.Add(ProductCreate_category_label);
            Controls.Add(ProductCreate_name_input);
            Controls.Add(ProductCreate_name_label);
            Name = "ProductCreate";
            Text = "ProductCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProductCreate_name_label;
        private TextBox ProductCreate_name_input;
        private Label ProductCreate_category_label;
        private ComboBox ProductCreate_category_input;
        private Label ProductCreate_price_label;
        private TextBox ProductCreate_price_input;
        private Button ProductCreate_save;
        private Button ProductCreate_cancel;
    }
}