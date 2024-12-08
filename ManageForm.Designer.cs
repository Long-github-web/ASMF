namespace WindowsFormsApp1
{
    partial class ManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_manage = new System.Windows.Forms.Panel();
            this.option_menu = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_option = new System.Windows.Forms.Button();
            this.management_menu = new System.Windows.Forms.Panel();
            this.btn_managelogin = new System.Windows.Forms.Button();
            this.btn_statisticcal = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_management = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_manage.SuspendLayout();
            this.option_menu.SuspendLayout();
            this.management_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_manage
            // 
            this.panel_manage.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_manage.Controls.Add(this.option_menu);
            this.panel_manage.Controls.Add(this.btn_option);
            this.panel_manage.Controls.Add(this.management_menu);
            this.panel_manage.Controls.Add(this.btn_management);
            this.panel_manage.Controls.Add(this.panel_logo);
            this.panel_manage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_manage.Location = new System.Drawing.Point(0, 0);
            this.panel_manage.Name = "panel_manage";
            this.panel_manage.Size = new System.Drawing.Size(249, 607);
            this.panel_manage.TabIndex = 0;
            // 
            // option_menu
            // 
            this.option_menu.Controls.Add(this.btn_exit);
            this.option_menu.Controls.Add(this.btn_logout);
            this.option_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.option_menu.Location = new System.Drawing.Point(0, 502);
            this.option_menu.Name = "option_menu";
            this.option_menu.Size = new System.Drawing.Size(249, 107);
            this.option_menu.TabIndex = 5;
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(0, 52);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.btn_exit.Size = new System.Drawing.Size(249, 52);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(0, 0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(249, 52);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_option
            // 
            this.btn_option.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_option.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_option.ForeColor = System.Drawing.Color.White;
            this.btn_option.Location = new System.Drawing.Point(0, 450);
            this.btn_option.Name = "btn_option";
            this.btn_option.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_option.Size = new System.Drawing.Size(249, 52);
            this.btn_option.TabIndex = 4;
            this.btn_option.Text = "Option";
            this.btn_option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_option.UseVisualStyleBackColor = true;
            this.btn_option.Click += new System.EventHandler(this.btn_option_Click);
            // 
            // management_menu
            // 
            this.management_menu.Controls.Add(this.btn_managelogin);
            this.management_menu.Controls.Add(this.btn_statisticcal);
            this.management_menu.Controls.Add(this.btn_customer);
            this.management_menu.Controls.Add(this.btn_employee);
            this.management_menu.Controls.Add(this.btn_product);
            this.management_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.management_menu.Location = new System.Drawing.Point(0, 183);
            this.management_menu.Name = "management_menu";
            this.management_menu.Size = new System.Drawing.Size(249, 267);
            this.management_menu.TabIndex = 3;
            // 
            // btn_managelogin
            // 
            this.btn_managelogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_managelogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_managelogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_managelogin.ForeColor = System.Drawing.Color.White;
            this.btn_managelogin.Location = new System.Drawing.Point(0, 210);
            this.btn_managelogin.Name = "btn_managelogin";
            this.btn_managelogin.Padding = new System.Windows.Forms.Padding(57, 0, 0, 0);
            this.btn_managelogin.Size = new System.Drawing.Size(249, 54);
            this.btn_managelogin.TabIndex = 7;
            this.btn_managelogin.Text = "Manage Account";
            this.btn_managelogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_managelogin.UseVisualStyleBackColor = true;
            this.btn_managelogin.Click += new System.EventHandler(this.btn_managelogin_Click);
            // 
            // btn_statisticcal
            // 
            this.btn_statisticcal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_statisticcal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statisticcal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statisticcal.ForeColor = System.Drawing.Color.White;
            this.btn_statisticcal.Location = new System.Drawing.Point(0, 156);
            this.btn_statisticcal.Name = "btn_statisticcal";
            this.btn_statisticcal.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.btn_statisticcal.Size = new System.Drawing.Size(249, 54);
            this.btn_statisticcal.TabIndex = 6;
            this.btn_statisticcal.Text = "Statistical";
            this.btn_statisticcal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_statisticcal.UseVisualStyleBackColor = true;
            this.btn_statisticcal.Click += new System.EventHandler(this.btn_statisticcal_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer.ForeColor = System.Drawing.Color.White;
            this.btn_customer.Location = new System.Drawing.Point(0, 104);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.btn_customer.Size = new System.Drawing.Size(249, 52);
            this.btn_customer.TabIndex = 5;
            this.btn_customer.Text = "Customer";
            this.btn_customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.ForeColor = System.Drawing.Color.White;
            this.btn_employee.Location = new System.Drawing.Point(0, 52);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.btn_employee.Size = new System.Drawing.Size(249, 52);
            this.btn_employee.TabIndex = 4;
            this.btn_employee.Text = "Employee";
            this.btn_employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_product
            // 
            this.btn_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.ForeColor = System.Drawing.Color.White;
            this.btn_product.Location = new System.Drawing.Point(0, 0);
            this.btn_product.Name = "btn_product";
            this.btn_product.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.btn_product.Size = new System.Drawing.Size(249, 52);
            this.btn_product.TabIndex = 3;
            this.btn_product.Text = "Product";
            this.btn_product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_management
            // 
            this.btn_management.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_management.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_management.ForeColor = System.Drawing.Color.White;
            this.btn_management.Location = new System.Drawing.Point(0, 131);
            this.btn_management.Name = "btn_management";
            this.btn_management.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_management.Size = new System.Drawing.Size(249, 52);
            this.btn_management.TabIndex = 2;
            this.btn_management.Text = "Management";
            this.btn_management.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_management.UseVisualStyleBackColor = true;
            this.btn_management.Click += new System.EventHandler(this.btn_management_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.button1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(249, 131);
            this.panel_logo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palace Script MT", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(249, 131);
            this.button1.TabIndex = 3;
            this.button1.Text = "EAT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.cea7874eafc75c2da7fae8b3937d636e_jpg_720x720q80;
            this.pictureBox1.Location = new System.Drawing.Point(246, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_manage);
            this.Name = "ManageForm";
            this.Text = "ManageForm";
            this.Load += new System.EventHandler(this.manageform_Load);
            this.panel_manage.ResumeLayout(false);
            this.option_menu.ResumeLayout(false);
            this.management_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_manage;
        private System.Windows.Forms.Panel management_menu;
        private System.Windows.Forms.Button btn_statisticcal;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_management;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button btn_option;
        private System.Windows.Forms.Panel option_menu;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_managelogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}