using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using order_win.Data;
using order_win.Models;

namespace order_win.CustomerPage
{
    public partial class CustomerCreate : Form
    {
        private string? selectedImagePath = null;
        private CustomerManagement _parentForm;
        public CustomerCreate(CustomerManagement parentForm)
        {
            InitializeComponent();
            // 血型選項
            CustomerCreate_bloodtype_input.Items.Add("A");
            CustomerCreate_bloodtype_input.Items.Add("B");
            CustomerCreate_bloodtype_input.Items.Add("AB");
            CustomerCreate_bloodtype_input.Items.Add("O");
            _parentForm = parentForm;
        }
        
        private void CustomerCreate_image_label_Click(object sender, EventArgs e)
        {

        }

        private void CustomerCreate_image_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                CustomerCreate_image_view.Image = Image.FromFile(selectedImagePath);
            }
        }

        private async void CustomerCreate_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerCreate_name_input.Text) || string.IsNullOrWhiteSpace(CustomerCreate_email_input.Text))
            {
                MessageBox.Show("請填寫姓名與 Email");
                return;
            }
            if (!CustomerCreate_gender_male.Checked && !CustomerCreate_gender_female.Checked)
            {
                MessageBox.Show("請選擇性別");
                return;
            }
            string gender = CustomerCreate_gender_male.Checked ? "Male" : "Female";
            string uid = Guid.NewGuid().ToString();

            // 儲存圖片（如果有）
            string? photoPathInDb = null;
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                string folderPath = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(selectedImagePath);
                string savedPath = Path.Combine(folderPath, uniqueFileName);

                File.Copy(selectedImagePath, savedPath, true);
                photoPathInDb = "Images/" + uniqueFileName;
            }

            var newCustomer = new Customer
            {
                Name = CustomerCreate_name_input.Text,
                UID = uid,
                Email = CustomerCreate_email_input.Text,
                Gender = gender,
                BloodType = CustomerCreate_bloodtype_input.SelectedItem?.ToString() ?? "",
                BirthDate = CustomerCreate_birth_input.Value,
                IsSubscribed = CustomerCreate_sub_input.Checked,
                PhotoPath = photoPathInDb
            };

            var success = await SendApiRequest(newCustomer);
            if (!success)
            {
                MessageBox.Show("儲存向量資料失敗，請稍後再試。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new AppDbContext())
            {
                db.Customers.Add(newCustomer);
                db.SaveChanges();
            }

            MessageBox.Show("顧客資料新增成功！");
            _parentForm.LoadCustomerData(); // 重新載入資料
            this.Close(); // 關閉表單
        }
        private async Task<bool> SendApiRequest(Customer newCustomer)
        {
            try
            {
                var client = new HttpClient();
                var data = new
                {
                    type = "customer",
                    id = newCustomer.UID,
                    text = $"Customer {newCustomer.Name}(UID: {newCustomer.UID}), {newCustomer.Gender}, " +
                    $"was born in {newCustomer.BirthDate} and bloodtype is {newCustomer.BloodType}." +
                    $"Customer's contacting email is {newCustomer.Email}."+
                    $"{(newCustomer.IsSubscribed ? "The customer is subscribed to our membership." : "The customer has not subscribed to our membership.")}"
                    //text = $"顧客 {newCustomer.Name} " +
                    //$"{(newCustomer.Gender == "Male" ? "先生" : "小姐")}" +
                    //" 的customer UID為{newCustomer.UID}，" +
                    //$"生日在{newCustomer.BirthDate}並且血型為{newCustomer.BloodType}型。" +
                    //$"顧客的聯絡信箱(email)是{newCustomer.Email}，" +
                    //$"{(newCustomer.IsSubscribed ? "並且已經加入會員" : "還沒加入會員")}"
                };


                string json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://localhost:8000/embed", content);
                Console.WriteLine($"Vector DB 儲存成功");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                // 可以記錄 log
                Console.WriteLine($"Vector DB 儲存錯誤: {ex.Message}");
                return false;
            }
        }

        private void CustomerCreate_cancel_Click(object sender, EventArgs e)
        {
            this.Close(); // 關閉目前表單
        }


    }
}
