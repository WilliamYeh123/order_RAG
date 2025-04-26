using Newtonsoft.Json;
using System.Text;
using order_win.CustomerPage;
using order_win.OrderPage;
using order_win.ProductPage;

namespace order_win
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuestionType.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customer_manage_btn_Click(object sender, EventArgs e)
        {
            CustomerManagement customerForm = new CustomerManagement();
            customerForm.Show(); // 顯示顧客管理畫面

            //this.Hide();               // 隱藏首頁（MainForm）

            // 當 customerForm 關閉時，自動結束整個應用程式或回到首頁：
            //customerForm.FormClosed += (s, args) => this.Close(); // 或改成 this.Show(); 回首頁
        }
        private void product_manage_btn_Click(object sender, EventArgs e)
        {
            ProductManagement productForm = new ProductManagement();
            productForm.Show(); // 顯示顧客管理畫面

            //this.Hide();               // 隱藏首頁（MainForm）

            // 當 customerForm 關閉時，自動結束整個應用程式或回到首頁：
            //productForm.FormClosed += (s, args) => this.Close(); // 或改成 this.Show(); 回首頁
        }
        private void order_manage_btn_Click(object sender, EventArgs e)
        {
            OrderManagement orderForm = new OrderManagement();
            orderForm.Show(); // 顯示顧客管理畫面

            //this.Hide();               // 隱藏首頁（MainForm）

            // 當 customerForm 關閉時，自動結束整個應用程式或回到首頁：
            //orderForm.FormClosed += (s, args) => this.Close(); // 或改成 this.Show(); 回首頁
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            string question = QuestionInput.Text.Trim();
            if (string.IsNullOrEmpty(question))
            {
                MessageBox.Show("請輸入問題！");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                var payload = new { query = question ,type=QuestionType.Text};
                var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                QuestionOutput.Text = "";
                try
                {
                    HttpResponseMessage response = await client.PostAsync("http://localhost:8000/search", content);
                    response.EnsureSuccessStatusCode();
                    string responseString = await response.Content.ReadAsStringAsync();

                    // 假設回傳格式是 { answer: "..." }
                    dynamic result = JsonConvert.DeserializeObject(responseString);
                    QuestionOutput.Text = result.result;
                }
                catch (Exception ex)
                {
                    QuestionOutput.Text = "發生錯誤：" + ex.Message;
                }
            }
        }
        private void QuestionInput_Enter(object sender, EventArgs e)
        {
            // 使用者點擊 TextBox
            if (QuestionInput.Text == "請在此輸入問題")
            {
                QuestionInput.Text = ""; // 清空占位文字
                QuestionInput.ForeColor = Color.Black; // 調整文字顏色
            }
        }

        private void QuestionInput_Leave(object sender, EventArgs e)
        {
            // 使用者離開 TextBox
            if (string.IsNullOrWhiteSpace(QuestionInput.Text))
            {
                QuestionInput.Text = "請在此輸入問題"; // 恢復占位文字
                QuestionInput.ForeColor = Color.Gray; // 調整文字顏色
            }
        }

    }
}
