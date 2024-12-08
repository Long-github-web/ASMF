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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        private void LoadEmployee()
        {
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT EmployeeID, Name, Phone, Email, Address, Position, Authority FROM Employee";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    datagridview_employee.DataSource = dt; // Giả sử bạn hiển thị danh sách nhân viên trên DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
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
                    if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_phone.Text) || string.IsNullOrWhiteSpace(txt_email.Text))
                    {
                        MessageBox.Show("All fields must be filled.", "Validation Error");
                        return;
                    }

                    // Kiểm tra xem người dùng có nhập ID hay không
                    string inputID = txt_eid.Text.Trim();
                    string query;

                    if (string.IsNullOrEmpty(inputID)) // Nếu người dùng không nhập ID
                    {
                        query = "INSERT INTO Employee (Name, Phone, Email, Address, Position, Authority) " +
                                "VALUES (@Name, @Phone, @Email, @Address, @Position, @Authority)";
                    }
                    else // Nếu người dùng nhập ID
                    {
                        query = "SET IDENTITY_INSERT Employee ON; " +
                                "INSERT INTO Employee (EmployeeID, Name, Phone, Email, Address, Position, Authority) " +
                                "VALUES (@ID, @Name, @Phone, @Email, @Address, @Position, @Authority); " +
                                "SET IDENTITY_INSERT Employee OFF;";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Gán giá trị cho các tham số
                        if (!string.IsNullOrEmpty(inputID))
                        {
                            cmd.Parameters.AddWithValue("@ID", int.Parse(inputID)); // ID do người dùng nhập
                        }
                        cmd.Parameters.AddWithValue("@Name", txt_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txt_phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txt_address.Text.Trim());
                        cmd.Parameters.AddWithValue("@Position", txt_position.Text.Trim());
                        cmd.Parameters.AddWithValue("@Authority", txt_authority.Text.Trim());

                        // Thực thi câu lệnh SQL
                        cmd.ExecuteNonQuery();

                        // Thông báo thành công
                        MessageBox.Show("Add employee successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu
                        LoadEmployee();
                        ClearEmployeeInput();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }
        private void ClearEmployeeInput()
        {
            txt_name.Clear();
            txt_eid.Clear();
            txt_phone.Clear();
            txt_email.Clear();
            txt_address.Clear();
            txt_position.Clear();
            txt_authority.Clear();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_eid.Text))  // Kiểm tra ID nhân viên
            {
                MessageBox.Show("Employee ID cannot be empty.", "Validation Error");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu lệnh SQL cập nhật nhân viên, sử dụng cột 'EmployeeID'
                    string updateQuery = "UPDATE Employee SET " +
                                         "Name = @Name, " +
                                         "Phone = @Phone, " +
                                         "Email = @Email, " +
                                         "Address = @Address, " +
                                         "Position = @Position, " +
                                         "Authority = @Authority " +
                                         "WHERE EmployeeID = @EmployeeID";  // Cập nhật cột 'EmployeeID'

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        // Gán giá trị từ các ô nhập liệu
                        cmd.Parameters.AddWithValue("@Name", txt_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txt_phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txt_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txt_address.Text.Trim());
                        cmd.Parameters.AddWithValue("@Position", txt_position.Text.Trim());
                        cmd.Parameters.AddWithValue("@Authority", txt_authority.Text.Trim());
                        cmd.Parameters.AddWithValue("@EmployeeID", txt_eid.Text.Trim());  // Tham số EmployeeID thay vì ID

                        int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee updated successfully!", "Success");

                            // Xóa các trường nhập liệu và tải lại danh sách nhân viên
                            ClearEmployeeInput();
                            LoadEmployee();
                        }
                        else
                        {
                            MessageBox.Show("Employee not found.", "Error");
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
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            // Kiểm tra xem ID có được nhập vào hay không
            if (string.IsNullOrWhiteSpace(txt_eid.Text))
            {
                MessageBox.Show("Employee ID cannot be empty.", "Validation Error");
                return;
            }

            // Xác nhận xóa nhân viên
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return; // Dừng lại nếu người dùng chọn No
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kiểm tra xem nhân viên có tồn tại hay không
                    string checkQuery = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @EmployeeID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@EmployeeID", txt_eid.Text.Trim());

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Employee not found.", "Error");
                            return; // Dừng lại nếu không tìm thấy nhân viên
                        }
                    }

                    // Câu lệnh SQL xóa nhân viên
                    string deleteQuery = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", txt_eid.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh xóa

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully!", "Success");
                            // Cập nhật lại giao diện người dùng sau khi xóa
                            ClearEmployeeInput();
                            LoadEmployee(); // Tải lại danh sách nhân viên nếu cần
                        }
                        else
                        {
                            MessageBox.Show("Error deleting employee.", "Error");
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
                    string query = "SELECT EmployeeID, Name, Phone, Email, Address, Position, Authority " +
                                   "FROM Employee " +  // Thay đổi tên bảng thành Employee
                                   "WHERE Name LIKE @Keyword OR EmployeeID LIKE @Keyword";  // Thay đổi cột thành EmployeeID

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Gán tham số cho từ khóa tìm kiếm
                        cmd.Parameters.AddWithValue("@Keyword", "%" + txt_search.Text.Trim() + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Hiển thị kết quả trên DataGridView
                        datagridview_employee.DataSource = dt;

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

        private void datagridview_employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridview_employee.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagridview_employee.SelectedRows[0];
                txt_name.Text = selectedRow.Cells[1].Value.ToString();
                txt_eid.Text = selectedRow.Cells[0].Value.ToString();
                txt_phone.Text = selectedRow.Cells[2].Value.ToString();
                txt_email.Text = selectedRow.Cells[3].Value.ToString();
                txt_address.Text = selectedRow.Cells[4].Value.ToString();
                txt_position.Text = selectedRow.Cells[5].Value.ToString();
                txt_authority.Text = selectedRow.Cells[6].Value.ToString();
            }
        }
    }

}
