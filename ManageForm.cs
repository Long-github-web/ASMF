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
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
            customizeDesign();

        }

        private void manageform_Load(object sender, EventArgs e)
        {
            customizeDesign(); // Đảm bảo các menu con ẩn lúc ban đầu
        }
        private void customizeDesign()
        {
            option_menu.Visible = false;
            management_menu.Visible = false;
        }
        private void hidesubmenu()
        {
            List<Panel> submenus = new List<Panel> { option_menu, management_menu };
            foreach (var submenu in submenus)
            {
                submenu.Visible = false;
            }
        }
        private void showSubmenu(Panel submenu)
        {
            if (!submenu.Visible) // Nếu submenu chưa hiển thị
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_management_Click(object sender, EventArgs e)
        {
            showSubmenu(management_menu);
        }
        private void btn_product_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            ProductForm f = new ProductForm();
            f.ShowDialog();
            openChildForm(new ProductForm());

        }
        private void btn_employee_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            EmployeeForm f = new EmployeeForm();
            f.ShowDialog();
            openChildForm(new EmployeeForm());
        }
        private void btn_customer_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            CustomerForm f = new CustomerForm();
            f.ShowDialog();
            openChildForm(new CustomerForm());
        }

        private void btn_statisticcal_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            StatisticalForm f = new StatisticalForm();
            f.ShowDialog();
            openChildForm(new StatisticalForm());
        }
        private void btn_option_Click(object sender, EventArgs e)
        {
            showSubmenu(option_menu);
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close(); // Đóng form chính
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_managelogin_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            ManageAccount f = new ManageAccount();
            f.ShowDialog();
            openChildForm(new ManageAccount());
        }
    }       

}
