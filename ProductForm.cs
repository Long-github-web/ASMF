using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        private void LoadProduct()
        {
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu truy vấn: Thay đổi tên bảng và các cột theo đúng cơ sở dữ liệu của bạn
                    string query = "SELECT ProductID, Name, Price, InventoryQuantity, Image FROM Product";

                    // Sử dụng SqlDataAdapter để lấy dữ liệu
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Tạo một DataTable để lưu dữ liệu từ cơ sở dữ liệu
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Gắn DataTable làm nguồn dữ liệu cho DataGridView
                    datagridview_product.DataSource = dt; // datagridview_product là tên của DataGridView hiển thị dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }
        private void LoadStock()
        {
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu lệnh SQL để lấy tất cả dữ liệu từ bảng Products
                    string query = "SELECT ProductID, Name, Price, InventoryQuantity FROM Product";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Hiển thị kết quả trong DataGridView
                        datagridview_product.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading stock: " + ex.Message, "Error");
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
                    if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_price.Text) || string.IsNullOrWhiteSpace(txt_iq.Text))
                    {
                        MessageBox.Show("All fields must be filled.", "Validation Error");
                        return;
                    }

                    // Kiểm tra xem người dùng có nhập ProductID hay không
                    string inputID = txt_pid.Text.Trim();
                    string query;

                    if (string.IsNullOrEmpty(inputID)) // Nếu người dùng không nhập ProductID
                    {
                        query = "INSERT INTO Product (Name, Price, Inventory Quantity) " +
                                "VALUES (@Name, @Price, @InventoryQuantity, @Image)";
                    }
                    else // Nếu người dùng nhập ProductID
                    {
                        query = "SET IDENTITY_INSERT Product ON; " +
                                "INSERT INTO Product (ProductID, Name, Price, InventoryQuantity, Image) " +
                                "VALUES (@ProductID, @Name, @Price, @InventoryQuantity, @Image); " +
                                "SET IDENTITY_INSERT Product OFF;";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Gán giá trị cho các tham số
                        if (!string.IsNullOrEmpty(inputID))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", int.Parse(inputID)); // ProductID do người dùng nhập
                        }
                        cmd.Parameters.AddWithValue("@Name", txt_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txt_price.Text.Trim())); // Chuyển đổi sang kiểu số thực
                        cmd.Parameters.AddWithValue("@InventoryQuantity", int.Parse(txt_iq.Text.Trim())); // Chuyển đổi sang kiểu số nguyên
                        cmd.Parameters.AddWithValue("@Image", txt_image.Text.Trim());

                        // Thực thi câu lệnh SQL
                        cmd.ExecuteNonQuery();

                        // Thông báo thành công
                        MessageBox.Show("Product added successfully!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới dữ liệu
                        LoadProduct();
                        ClearProductInput();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }
        private void ClearProductInput()
        {
            txt_name.Clear();
            txt_pid.Clear();
            txt_price.Clear();
            txt_iq.Clear();
            txt_image.Clear();
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

            if (string.IsNullOrWhiteSpace(txt_pid.Text)) // Kiểm tra ProductID
            {
                MessageBox.Show("Product ID cannot be empty.", "Validation Error");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu lệnh SQL cập nhật sản phẩm, sử dụng cột 'ProductID'
                    string updateQuery = "UPDATE Product SET " +
                                         "Name = @Name, " +
                                         "Price = @Price, " +
                                         "InventoryQuantity = @InventoryQuantity " +
                                         "Image = @Image, " +
                                         "WHERE ProductID = @ProductID"; // Cập nhật cột 'ProductID'

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        // Gán giá trị từ các ô nhập liệu
                        cmd.Parameters.AddWithValue("@Name", txt_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txt_price.Text.Trim())); // Chuyển đổi giá sang kiểu số thực
                        cmd.Parameters.AddWithValue("@InventoryQuantity", int.Parse(txt_iq.Text.Trim())); // Chuyển đổi số lượng tồn kho sang kiểu số nguyên
                        cmd.Parameters.AddWithValue("@ProductID", int.Parse(txt_pid.Text.Trim())); // ProductID là kiểu số nguyên
                        cmd.Parameters.AddWithValue("@Image", txt_image.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully!", "Success");

                            // Xóa các trường nhập liệu và tải lại danh sách sản phẩm
                            ClearProductInput();
                            LoadProduct();
                        }
                        else
                        {
                            MessageBox.Show("Product not found.", "Error");
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

            // Kiểm tra xem ProductID có được nhập vào hay không
            if (string.IsNullOrWhiteSpace(txt_pid.Text))
            {
                MessageBox.Show("Product ID cannot be empty.", "Validation Error");
                return;
            }

            // Xác nhận xóa sản phẩm
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return; // Dừng lại nếu người dùng chọn No
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kiểm tra xem sản phẩm có tồn tại hay không
                    string checkQuery = "SELECT COUNT(*) FROM Product WHERE ProductID = @ProductID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductID", txt_pid.Text.Trim());

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Product not found.", "Error");
                            return; // Dừng lại nếu không tìm thấy sản phẩm
                        }
                    }

                    // Câu lệnh SQL xóa sản phẩm
                    string deleteQuery = "DELETE FROM Product WHERE ProductID = @ProductID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", txt_pid.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh xóa

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully!", "Success");
                            // Cập nhật lại giao diện người dùng sau khi xóa
                            ClearProductInput(); // Hàm xóa các trường nhập liệu
                            LoadProduct(); // Hàm tải lại danh sách sản phẩm nếu cần
                        }
                        else
                        {
                            MessageBox.Show("Error deleting product.", "Error");
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
                    string query = "SELECT ProductID, Name, Price, InventoryQuantity " +
                                   "FROM Product " +
                                   "WHERE Name LIKE @Keyword OR ProductID LIKE @Keyword";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Gán tham số cho từ khóa tìm kiếm
                        cmd.Parameters.AddWithValue("@Keyword", "%" + txt_search.Text.Trim() + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Hiển thị kết quả trên DataGridView
                        datagridview_product.DataSource = dt;

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

        private void btn_filter_Click(object sender, EventArgs e)
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            // Lấy dữ liệu từ các TextBox
            string productIDKeyword = txt_pid.Text.Trim(); // Tìm theo mã sản phẩm
            string nameKeyword = txt_name.Text.Trim();           // Tìm theo tên sản phẩm
            string priceFilter = txt_price.Text.Trim().ToLower(); // Điều kiện lọc giá (Above/Below 50000)

            // Xây dựng điều kiện WHERE động
            List<string> conditions = new List<string>();
            if (!string.IsNullOrWhiteSpace(productIDKeyword))
            {
                conditions.Add("ProductID LIKE @ProductID");
            }
            if (!string.IsNullOrWhiteSpace(nameKeyword))
            {
                conditions.Add("Name LIKE @Name");
            }
            if (!string.IsNullOrWhiteSpace(priceFilter))
            {
                if (priceFilter == "above 50000")
                {
                    conditions.Add("Price > 50000");
                }
                else if (priceFilter == "below 50000")
                {
                    conditions.Add("Price <= 50000");
                }
                else
                {
                    MessageBox.Show("Invalid price filter. Please enter 'Above 50000' or 'Below 50000'.", "Validation Error");
                    return;
                }
            }

            // Nếu không có điều kiện nào được nhập, thông báo lỗi
            if (conditions.Count == 0)
            {
                MessageBox.Show("Please enter at least one filter criterion.", "Validation Error");
                return;
            }

            // Ghép các điều kiện lại bằng 'AND'
            string whereClause = string.Join(" AND ", conditions);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu truy vấn SQL kết hợp các điều kiện
                    string query = "SELECT ProductID, Name, Price, InventoryQuantity " +
                                   "FROM Product " +
                                   "WHERE " + whereClause;

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Gán tham số tìm kiếm
                        if (!string.IsNullOrWhiteSpace(productIDKeyword))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", "%" + productIDKeyword + "%");
                        }
                        if (!string.IsNullOrWhiteSpace(nameKeyword))
                        {
                            cmd.Parameters.AddWithValue("@Name", "%" + nameKeyword + "%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Hiển thị kết quả tìm kiếm lên DataGridView
                        datagridview_product.DataSource = dt;

                        // Thông báo nếu không tìm thấy kết quả
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No products found with the specified criteria.", "Search Results");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        private void btn_addstock_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa nhập ProductID hoặc InventoryQuantity
            if (string.IsNullOrWhiteSpace(txt_pid.Text) || string.IsNullOrWhiteSpace(txt_add.Text))
            {
                MessageBox.Show("Please enter both ProductID and Inventory Quantity.", "Validation Error");
                return;
            }

            int productID;
            int addstock;

            if (!int.TryParse(txt_pid.Text.Trim(), out productID))
            {
                MessageBox.Show("Invalid ProductID.", "Validation Error");
                return;
            }

            if (!int.TryParse(txt_add.Text.Trim(), out addstock) || addstock <= 0)
            {
                MessageBox.Show("Please enter a valid positive Inventory Quantity.", "Validation Error");
                return;
            }

            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu lệnh SQL để cập nhật số lượng tồn kho
                    string updateQuery = "UPDATE Product " +
                                         "SET InventoryQuantity = InventoryQuantity + @AddQuantity " +  // Tăng số lượng tồn kho
                                         "WHERE ProductID = @ProductID";  // Cập nhật theo ProductID

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        // Gán tham số cho câu lệnh SQL
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.Parameters.AddWithValue("@AddQuantity", addstock);

                        // Thực thi câu lệnh SQL
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock updated successfully!", "Success");

                            // Cập nhật lại giao diện người dùng sau khi nhập kho
                            ClearStockInput();  // Hàm để làm mới các trường nhập liệu (nếu cần)
                            LoadStock();  // Hàm để tải lại danh sách kho (nếu cần)
                        }
                        else
                        {
                            MessageBox.Show("Product not found.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }
        private void ClearStockInput()
        {
            txt_pid.Clear();
            txt_name.Clear();
            txt_price.Clear();
            txt_iq.Clear();
            txt_add.Clear();
            txt_sell.Clear();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Truy vấn dữ liệu sản phẩm
                    string query = "SELECT ProductID, Name, Price, InventoryQuantity, Image FROM Product";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Hiển thị dữ liệu lên DataGridView
                    datagridview_product.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void datagridview_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridview_product.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagridview_product.SelectedRows[0];
                txt_pid.Text = selectedRow.Cells[0].Value.ToString();
                txt_name.Text = selectedRow.Cells[1].Value.ToString();
                txt_price.Text = selectedRow.Cells[2].Value.ToString();
                txt_iq.Text = selectedRow.Cells[3].Value.ToString();
                txt_image.Text = selectedRow.Cells[4].Value.ToString();

                // Lấy đường dẫn ảnh từ cột thứ 5 và hiển thị trong PictureBox
                string imageUrl = selectedRow.Cells[4].Value.ToString();
                ShowImageInPictureBox(imageUrl);


            }

        }
        private void ShowImageInPictureBox(string imageUrl)
        {
            try
            {
                if (!string.IsNullOrEmpty(imageUrl))
                {
                    // Kiểm tra nếu URL hợp lệ
                    if (Uri.IsWellFormedUriString(imageUrl, UriKind.Absolute))
                    {
                        // Sử dụng WebClient để tải ảnh từ URL
                        using (WebClient client = new WebClient())
                        {
                            byte[] imageBytes = client.DownloadData(imageUrl);
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pic_product.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid URL.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load image: " + ex.Message);
            }
        }
    }
}
