namespace order_win.Models
{
    public class Customer
    {
        public Customer()
        {
            Name = string.Empty;
            Gender = string.Empty;
            BloodType = string.Empty;
            Email = string.Empty;
        }
        public int Id { get; set; }
        public string? UID { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }  // 文字輸入欄位

        public string Gender { get; set; } // Drop-down: "Male", "Female", "Other"

        public string BloodType { get; set; } // Drop-down: "A", "B", "AB", "O"

        public DateTime BirthDate { get; set; } // Date picker

        public bool IsSubscribed { get; set; }  // Checkbox: 訂閱電子報
        public string? PhotoPath { get; set; }  // 圖片路徑（選項 B）
    }
}
