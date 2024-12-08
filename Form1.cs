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

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Ẩn form hiện tại
            this.Hide();

            // Tạo một instance của form RegisterForm
            RegisterForm registerForm = new RegisterForm();

            // Hiển thị RegisterForm dưới dạng hộp thoại
            registerForm.ShowDialog();

            // Hiển thị lại form hiện tại sau khi form mới được đóng
            this.Show();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Please enter both name and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuỗi kết nối tới SQL Server
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu lệnh kiểm tra tài khoản, mật khẩu và vai trò
                    string query = "SELECT Role FROM Register WHERE Name = @Name AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Gán giá trị từ TextBox vào tham số truy vấn
                        cmd.Parameters.AddWithValue("@Name", txt_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txt_password.Text.Trim());

                        object roleObj = cmd.ExecuteScalar(); // Thực thi truy vấn, trả về vai trò nếu đúng

                        if (roleObj != null)
                        {
                            string role = roleObj.ToString();

                            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("Login successful as Manager!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Mở form dành cho quản lý
                                ManageForm managerForm = new ManageForm();
                                managerForm.Show();
                                this.Hide();
                            }
                            else if (role.Equals("Customer", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("Login successful as Customer!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Mở form dành cho khách hàng
                                FormThanhToan customerForm = new FormThanhToan();
                                customerForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show($"Unknown role: {role}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid name or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
