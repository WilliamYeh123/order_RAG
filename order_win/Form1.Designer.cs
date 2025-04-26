namespace order_win
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            title = new Label();
            customer_manage_btn = new Button();
            product_manage_btn = new Button();
            order_manage_btn = new Button();
            QuestionOutput = new RichTextBox();
            QuestionInput = new TextBox();
            QuestionSend = new PictureBox();
            label1 = new Label();
            QuestionType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)QuestionSend).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("標楷體", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            title.Location = new Point(358, 50);
            title.Margin = new Padding(4, 0, 4, 0);
            title.Name = "title";
            title.Size = new Size(308, 47);
            title.TabIndex = 0;
            title.Text = "訂單管理系統";
            title.Click += label1_Click;
            // 
            // customer_manage_btn
            // 
            customer_manage_btn.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            customer_manage_btn.Location = new Point(121, 162);
            customer_manage_btn.Margin = new Padding(4);
            customer_manage_btn.Name = "customer_manage_btn";
            customer_manage_btn.Size = new Size(244, 78);
            customer_manage_btn.TabIndex = 1;
            customer_manage_btn.Text = "顧客管理";
            customer_manage_btn.UseVisualStyleBackColor = true;
            customer_manage_btn.Click += customer_manage_btn_Click;
            // 
            // product_manage_btn
            // 
            product_manage_btn.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            product_manage_btn.Location = new Point(121, 248);
            product_manage_btn.Margin = new Padding(4);
            product_manage_btn.Name = "product_manage_btn";
            product_manage_btn.Size = new Size(244, 78);
            product_manage_btn.TabIndex = 1;
            product_manage_btn.Text = "產品管理";
            product_manage_btn.UseVisualStyleBackColor = true;
            product_manage_btn.Click += product_manage_btn_Click;
            // 
            // order_manage_btn
            // 
            order_manage_btn.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            order_manage_btn.Location = new Point(121, 334);
            order_manage_btn.Margin = new Padding(4);
            order_manage_btn.Name = "order_manage_btn";
            order_manage_btn.Size = new Size(244, 78);
            order_manage_btn.TabIndex = 1;
            order_manage_btn.Text = "訂單管理";
            order_manage_btn.UseVisualStyleBackColor = true;
            order_manage_btn.Click += order_manage_btn_Click;
            // 
            // QuestionOutput
            // 
            QuestionOutput.Location = new Point(422, 185);
            QuestionOutput.Name = "QuestionOutput";
            QuestionOutput.Size = new Size(519, 227);
            QuestionOutput.TabIndex = 2;
            QuestionOutput.Text = "";
            // 
            // QuestionInput
            // 
            QuestionInput.Font = new Font("Microsoft JhengHei UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 136);
            QuestionInput.Location = new Point(541, 418);
            QuestionInput.Name = "QuestionInput";
            QuestionInput.Size = new Size(359, 27);
            QuestionInput.TabIndex = 3;
            QuestionInput.Text = "請在此輸入問題";
            QuestionInput.Enter += QuestionInput_Enter;
            QuestionInput.Leave += QuestionInput_Leave;
            // 
            // QuestionSend
            // 
            QuestionSend.Image = (Image)resources.GetObject("QuestionSend.Image");
            QuestionSend.Location = new Point(906, 418);
            QuestionSend.Name = "QuestionSend";
            QuestionSend.Size = new Size(33, 32);
            QuestionSend.SizeMode = PictureBoxSizeMode.StretchImage;
            QuestionSend.TabIndex = 5;
            QuestionSend.TabStop = false;
            QuestionSend.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("標楷體", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(422, 152);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 6;
            label1.Text = "智慧客服";
            // 
            // QuestionType
            // 
            QuestionType.FormattingEnabled = true;
            QuestionType.Items.AddRange(new object[] { "order", "customer", "product" });
            QuestionType.Location = new Point(422, 418);
            QuestionType.Name = "QuestionType";
            QuestionType.Size = new Size(113, 27);
            QuestionType.TabIndex = 7;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1029, 570);
            Controls.Add(QuestionType);
            Controls.Add(label1);
            Controls.Add(QuestionSend);
            Controls.Add(QuestionInput);
            Controls.Add(QuestionOutput);
            Controls.Add(order_manage_btn);
            Controls.Add(product_manage_btn);
            Controls.Add(customer_manage_btn);
            Controls.Add(title);
            Margin = new Padding(4);
            Name = "Home";
            Text = "Home";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)QuestionSend).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button customer_manage_btn;
        private Button product_manage_btn;
        private Button order_manage_btn;
        private RichTextBox QuestionOutput;
        private TextBox QuestionInput;
        private PictureBox QuestionSend;
        private Label label1;
        private ComboBox QuestionType;
    }
}
