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
    public partial class ManageAccount : Form
    {
        public ManageAccount()
        {
            InitializeComponent();
        }
        private void LoadAccount()
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            string query = "SELECT Name, Password, Role FROM Register"; // Chỉ lấy cột Name, Password và Role

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Gán DataTable vào DataGridView
                    datagridview_account.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }
        private void datagridview_account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridview_account.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagridview_account.SelectedRows[0];
                txt_name.Text = selectedRow.Cells[0].Value.ToString();
                txt_password.Text = selectedRow.Cells[1].Value.ToString();
                txt_role.Text = selectedRow.Cells[2].Value.ToString();

            }
        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kiểm tra đầu vào
                    if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
                    {
                        MessageBox.Show("Name and Password fields must be filled.", "Validation Error");
                        return;
                    }

                    // Câu lệnh SQL để chèn vào bảng Register (ID được tạo tự động)
                    string query = "INSERT INTO Register (Name, Password) " +
                                   "VALUES (@Name, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Gán giá trị cho các tham số
                        cmd.Parameters.AddWithValue("@Name", txt_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txt_password.Text.Trim());

                        // Thực thi câu lệnh SQL
                        cmd.ExecuteNonQuery();

                        // Thông báo thành công
                        MessageBox.Show("Account added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu
                        LoadAccount(); // Gọi hàm để tải lại danh sách trong bảng Register
                        ClearAccountInput(); // Gọi hàm để xóa các trường nhập liệu
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }
        private void ClearAccountInput()
        {
            txt_name.Clear();
            txt_password.Clear();
            txt_role.Clear();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_password.Text) || string.IsNullOrWhiteSpace(txt_role.Text))
            {
                MessageBox.Show("Name, Password, and Role fields must be filled.", "Validation Error");
                return;
            }

            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            // Câu lệnh SQL để cập nhật dữ liệu vào bảng Register
            string updateQuery = "UPDATE Register SET Name = @Name, Password = @Password, Role = @Role WHERE Name = @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        // Gán giá trị cho các tham số
                        cmd.Parameters.AddWithValue("@Name", txt_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txt_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@Role", txt_role.Text.Trim());

                        // Thực thi câu lệnh SQL
                        int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh cập nhật

                        // Kiểm tra kết quả cập nhật
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account updated successfully!", "Success");

                            // Làm mới dữ liệu
                            LoadAccount();  // Gọi hàm để tải lại dữ liệu vào DataGridView
                            ClearAccountInput();  // Gọi hàm để xóa các trường nhập liệu
                        }
                        else
                        {
                            MessageBox.Show("No matching account found to update.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_role.Text))
            {
                MessageBox.Show("Name and Role fields must be filled.", "Validation Error");
                return;
            }

            // Xác nhận xóa từ người dùng
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return; // Nếu người dùng chọn "No", không thực hiện xóa
            }

            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            // Câu lệnh SQL để xóa tài khoản từ bảng Register
            string deleteQuery = "DELETE FROM Register WHERE Name = @Name AND Role = @Role";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        // Gán giá trị cho các tham số
                        cmd.Parameters.AddWithValue("@Name", txt_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@Role", txt_role.Text.Trim());

                        // Thực thi câu lệnh SQL
                        int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh xóa

                        // Kiểm tra kết quả xóa
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account deleted successfully!", "Success");

                            // Làm mới dữ liệu
                            LoadAccount();  // Gọi hàm để tải lại dữ liệu vào DataGridView
                            ClearAccountInput();  // Gọi hàm để xóa các trường nhập liệu
                        }
                        else
                        {
                            MessageBox.Show("No matching account found to delete.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            // Kiểm tra nếu người dùng chưa nhập từ khóa
            if (string.IsNullOrWhiteSpace(txt_search.Text))
            {
                MessageBox.Show("Please enter a keyword to search.", "Validation Error");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu lệnh truy vấn tìm kiếm
                    string query = "SELECT Name, Password, Role " +
                                   "FROM Register " + // Sửa tên bảng thành Register
                                   "WHERE Name LIKE @Keyword OR Role LIKE @Keyword"; // Tìm kiếm theo Name hoặc Role

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Gán tham số cho từ khóa tìm kiếm
                        cmd.Parameters.AddWithValue("@Keyword", "%" + txt_search.Text.Trim() + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Hiển thị kết quả trên DataGridView
                        datagridview_account.DataSource = dt; // Thay đổi tên DataGridView

                        // Kiểm tra nếu không có kết quả
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No results found.", "Search Results");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }
    }
}
