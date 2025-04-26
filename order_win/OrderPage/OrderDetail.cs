using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using order_win.Models;

namespace order_win.OrderPage
{
    public partial class OrderDetail : Form
    {
        private Order _order;
        public OrderDetail(Order order)
        {
            InitializeComponent();
            _order = order;
            LoadDetails();
        }
        private void LoadDetails()
        {
            detailOrderNumber.Text = _order.OrderNumber;
            detailCustomer.Text = _order.Customer?.Name ?? "N/A";
            detailCreateTime.Text = _order.CreatedTime.ToString("yyyy-MM-dd HH:mm");
            detailTotalPrice.Text = $"${_order.TotalPrice:N2}";

            foreach (var op in _order.OrderProducts)
            {
                dataGridViewOrderDetail.Rows.Add(op.Product?.Name, op.Product?.Price, op.Count, op.Count * op.Product?.Price ?? 0);
            }
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
