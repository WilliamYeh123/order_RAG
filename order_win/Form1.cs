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
            customerForm.Show(); // ����U�Ⱥ޲z�e��

            //this.Hide();               // ���í����]MainForm�^

            // �� customerForm �����ɡA�۰ʵ���������ε{���Φ^�쭺���G
            //customerForm.FormClosed += (s, args) => this.Close(); // �Χ令 this.Show(); �^����
        }
        private void product_manage_btn_Click(object sender, EventArgs e)
        {
            ProductManagement productForm = new ProductManagement();
            productForm.Show(); // ����U�Ⱥ޲z�e��

            //this.Hide();               // ���í����]MainForm�^

            // �� customerForm �����ɡA�۰ʵ���������ε{���Φ^�쭺���G
            //productForm.FormClosed += (s, args) => this.Close(); // �Χ令 this.Show(); �^����
        }
        private void order_manage_btn_Click(object sender, EventArgs e)
        {
            OrderManagement orderForm = new OrderManagement();
            orderForm.Show(); // ����U�Ⱥ޲z�e��

            //this.Hide();               // ���í����]MainForm�^

            // �� customerForm �����ɡA�۰ʵ���������ε{���Φ^�쭺���G
            //orderForm.FormClosed += (s, args) => this.Close(); // �Χ令 this.Show(); �^����
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            string question = QuestionInput.Text.Trim();
            if (string.IsNullOrEmpty(question))
            {
                MessageBox.Show("�п�J���D�I");
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

                    // ���]�^�Ǯ榡�O { answer: "..." }
                    dynamic result = JsonConvert.DeserializeObject(responseString);
                    QuestionOutput.Text = result.result;
                }
                catch (Exception ex)
                {
                    QuestionOutput.Text = "�o�Ϳ��~�G" + ex.Message;
                }
            }
        }
        private void QuestionInput_Enter(object sender, EventArgs e)
        {
            // �ϥΪ��I�� TextBox
            if (QuestionInput.Text == "�Цb����J���D")
            {
                QuestionInput.Text = ""; // �M�ťe���r
                QuestionInput.ForeColor = Color.Black; // �վ��r�C��
            }
        }

        private void QuestionInput_Leave(object sender, EventArgs e)
        {
            // �ϥΪ����} TextBox
            if (string.IsNullOrWhiteSpace(QuestionInput.Text))
            {
                QuestionInput.Text = "�Цb����J���D"; // ��_�e���r
                QuestionInput.ForeColor = Color.Gray; // �վ��r�C��
            }
        }

    }
}
