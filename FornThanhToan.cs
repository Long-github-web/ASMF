using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class FormThanhToan : Form
    {
        // Danh sách lưu trữ lịch sử mua hàng
        private List<string> orderHistory = new List<string>();

        public FormThanhToan()
        {
            InitializeComponent();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            btn_pay.Click += btn_pay_Click;
            btn_pay.Click -= btn_pay_Click;
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            // Get quantities from NumericUpDowns
            int chickenQty = (int)nud_chicken.Value;
            int pastaQty = (int)nud_pasta.Value;
            int burgerQty = (int)nud_burger.Value;
            int saladQty = (int)nud_salad.Value;

            // Prices
            int chickenPrice = 35000;
            int pastaPrice = 40000;
            int burgerPrice = 45000;
            int saladPrice = 40000;

            // Calculate total
            int total = (chickenQty * chickenPrice) +
                        (pastaQty * pastaPrice) +
                        (burgerQty * burgerPrice) +
                        (saladQty * saladPrice);

            // Generate order details
            string orderDetails = "";
            if (chickenQty > 0) orderDetails += $"Fried Chicken: {chickenQty} x {chickenPrice:N0} = {chickenQty * chickenPrice:N0} VND\n";
            if (pastaQty > 0) orderDetails += $"Pasta: {pastaQty} x {pastaPrice:N0} = {pastaQty * pastaPrice:N0} VND\n";
            if (burgerQty > 0) orderDetails += $"Hamburger: {burgerQty} x {burgerPrice:N0} = {burgerQty * burgerPrice:N0} VND\n";
            if (saladQty > 0) orderDetails += $"Salad: {saladQty} x {saladPrice:N0} = {saladQty * saladPrice:N0} VND\n";

            // Payment process
            if (total > 0)
            {
                MessageBox.Show($"Add to cart successfully!\nTotal: {total:N0} VND", "Add to cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No items selected for add to cart.", "Add to cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_vh_Click(object sender, EventArgs e)
        {
        
            if (orderHistory.Count == 0)
            {
                MessageBox.Show("No purchase history available.", "History", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tạo chuỗi lịch sử mua hàng
            string history = string.Join("\n--------------------\n", orderHistory);

            // Hiển thị lịch sử mua hàng trong một hộp thoại
            MessageBox.Show(history, "Purchase History", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_createinvoice_Click(object sender, EventArgs e)
        {
            // Get quantities from NumericUpDowns
            int chickenQty = (int)nud_chicken.Value;
            int pastaQty = (int)nud_pasta.Value;
            int burgerQty = (int)nud_burger.Value;
            int saladQty = (int)nud_salad.Value;

            // Prices
            int chickenPrice = 35000;
            int pastaPrice = 40000;
            int burgerPrice = 45000;
            int saladPrice = 40000;

            // Calculate total
            int total = (chickenQty * chickenPrice) +
                        (pastaQty * pastaPrice) +
                        (burgerQty * burgerPrice) +
                        (saladQty * saladPrice);

            // Generate order details
            string orderDetails = "";
            if (chickenQty > 0) orderDetails += $"Fried Chicken: {chickenQty} x {chickenPrice:N0} = {chickenQty * chickenPrice:N0} VND\n";
            if (pastaQty > 0) orderDetails += $"Pasta: {pastaQty} x {pastaPrice:N0} = {pastaQty * pastaPrice:N0} VND\n";
            if (burgerQty > 0) orderDetails += $"Hamburger: {burgerQty} x {burgerPrice:N0} = {burgerQty * burgerPrice:N0} VND\n";
            if (saladQty > 0) orderDetails += $"Salad: {saladQty} x {saladPrice:N0} = {saladQty * saladPrice:N0} VND\n";

            // Open the receipt form
            FormInvoice receiptForm = new FormInvoice(orderDetails, total);
            receiptForm.Show();

            // Save order history
            orderHistory.Add($"Order at {DateTime.Now}: \n{orderDetails}\nTotal: {total:N0} VND\n");
        }
    }
}
