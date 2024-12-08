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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
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
                    if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_phone.Text) || string.IsNullOrWhiteSpace(txt_address.Text))
                    {
                        MessageBox.Show("All fields must be filled.", "Validation Error");
                        return;
                    }

                    // Kiểm tra xem người dùng có nhập ID hay không
                    string inputID = txt_cid.Text.Trim();
                    string query;

                    if (string.IsNullOrEmpty(inputID)) // Nếu người dùng không nhập ID
                    {
                        query = "INSERT INTO Customer (Name, Phone, Address) " +
                                "VALUES (@Name, @Phone, @Address)";
                    }
                    else // Nếu người dùng nhập ID
                    {
                        query = "SET IDENTITY_INSERT Customer ON; " +
                                "INSERT INTO Customer (CustomerID, Name, Phone, Address) " +
                                "VALUES (@ID, @Name, @Phone, @Address); " +
                                "SET IDENTITY_INSERT Customer OFF;";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Gán giá trị cho các tham số
                        if (!string.IsNullOrEmpty(inputID))
                        {
                            cmd.Parameters.AddWithValue("@ID", int.Parse(inputID)); // CustomerID do người dùng nhập
                        }
                        cmd.Parameters.AddWithValue("@Name", txt_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txt_phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txt_address.Text.Trim());

                        // Thực thi câu lệnh SQL
                        cmd.ExecuteNonQuery();

                        // Thông báo thành công
                        MessageBox.Show("Customer added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu
                        LoadCustomer(); // Gọi hàm để tải lại danh sách khách hàng
                        ClearCustomerInput(); // Gọi hàm để xóa các trường nhập liệu
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }
        private void ClearCustomerInput()
        {
            txt_name.Clear();
            txt_cid.Clear();
            txt_phone.Clear();
            txt_address.Clear();
        }
        private void LoadCustomer()
        {
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Truy vấn dữ liệu từ bảng Customers
                    string query = "SELECT CustomerID, Name, Phone, Address FROM Customer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Gắn dữ liệu vào DataGridView
                    datagridview_product.DataSource = dt; // Giả sử bạn hiển thị danh sách khách hàng trên DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomer();
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

            if (string.IsNullOrWhiteSpace(txt_cid.Text)) // Kiểm tra ID khách hàng
            {
                MessageBox.Show("Customer ID cannot be empty.", "Validation Error");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu lệnh SQL cập nhật thông tin khách hàng
                    string updateQuery = "UPDATE Customer SET " +
                                         "Name = @Name, " +
                                         "Phone = @Phone, " +
                                         "Address = @Address " +
                                         "WHERE CustomerID = @CustomerID"; // Cập nhật theo CustomerID

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        // Gán giá trị từ các ô nhập liệu
                        cmd.Parameters.AddWithValue("@Name", txt_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txt_phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txt_address.Text.Trim());
                        cmd.Parameters.AddWithValue("@CustomerID", txt_cid.Text.Trim()); // Tham số CustomerID

                        int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully!", "Success");

                            // Xóa các trường nhập liệu và tải lại danh sách khách hàng
                            ClearCustomerInput();
                            LoadCustomer();
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.", "Error");
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
            if (string.IsNullOrWhiteSpace(txt_cid.Text))
            {
                MessageBox.Show("Customer ID cannot be empty.", "Validation Error");
                return;
            }

            // Xác nhận xóa khách hàng
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return; // Dừng lại nếu người dùng chọn No
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kiểm tra xem khách hàng có tồn tại hay không
                    string checkQuery = "SELECT COUNT(*) FROM Customer WHERE CustomerID = @CustomerID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@CustomerID", txt_cid.Text.Trim());

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Customer not found.", "Error");
                            return; // Dừng lại nếu không tìm thấy khách hàng
                        }
                    }

                    // Câu lệnh SQL xóa khách hàng
                    string deleteQuery = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", txt_cid.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh xóa

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer deleted successfully!", "Success");
                            // Cập nhật lại giao diện người dùng sau khi xóa
                            ClearCustomerInput();
                            LoadCustomer(); // Tải lại danh sách khách hàng nếu cần
                        }
                        else
                        {
                            MessageBox.Show("Error deleting customer.", "Error");
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
                    string query = "SELECT CustomerID, Name, Phone, Address " +
                                   "FROM Customer " +  // Đổi tên bảng thành Customers
                                   "WHERE Name LIKE @Keyword OR CustomerID LIKE @Keyword";  // Đổi cột thành CustomerID

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Gán tham số cho từ khóa tìm kiếm
                        cmd.Parameters.AddWithValue("@Keyword", "%" + txt_search.Text.Trim() + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Hiển thị kết quả trên DataGridView
                        datagridview_product.DataSource = dt; // Đổi thành datagridview_customer

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
