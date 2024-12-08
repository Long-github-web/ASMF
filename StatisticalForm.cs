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
    public partial class StatisticalForm : Form
    {
        public StatisticalForm()
        {
            InitializeComponent();
        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_statistical_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-SKFHJDFE;Initial Catalog=ASMF;Integrated Security=True;TrustServerCertificate=True";
            string query = @"
            SELECT 
            ProductID, 
            Name, 
            InventoryQuantity, 
            ISNULL(QuantitySold, 0) AS QuantitySold 
            FROM 
            Product
            WHERE 
            CreatedDate BETWEEN @StartDate AND @EndDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Lấy giá trị từ DateTimePicker
                DateTime startDate = dtp_from.Value.Date;
                DateTime endDate = dtp_to.Value.Date;

                // Gán tham số
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Gán DataTable vào DataGridView
                    dgv_statistical.DataSource = dt;

                    // Hiển thị tổng tồn kho
                    int totalInventory = dt.AsEnumerable().Sum(row => row.Field<int>("InventoryQuantity"));

                    // Hiển thị tổng số lượng đã bán
                    int totalSold = dt.AsEnumerable().Sum(row => row.Field<int>("QuantitySold"));

                    // Hiển thị vào giao diện
                    lb_statistical.Text = $"Quantity remaining in stock: {totalInventory}\nQuantity sold: {totalSold}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
