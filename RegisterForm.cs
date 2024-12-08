using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string name = txt_name.Text;
            string password = txt_password.Text;
            string phone = txt_phone.Text;
            string address = txt_address.Text;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter complete informatio!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuỗi kết nối SQL Server
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                // Kết nối SQL Server và thực thi lệnh
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Thêm cột Role vào câu lệnh SQL để mặc định là "Customer"
                    string query = "INSERT INTO Register (Name, Password, Phone, Address, Role) VALUES (@Name, @Password, @Phone, @Address, @Role)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Role", "Customer"); // Mặc định vai trò là "Customer"

                        // Thực thi
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Registration successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Đóng form sau khi đăng ký thành công
                        }
                        else
                        {
                            MessageBox.Show("Registration failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
