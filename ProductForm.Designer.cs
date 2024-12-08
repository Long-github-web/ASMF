namespace WindowsFormsApp1
{
    partial class ProductForm
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
            this.datagridview_product = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pid = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_iq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_filter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.txt_sell = new System.Windows.Forms.TextBox();
            this.btn_addstock = new System.Windows.Forms.Button();
            this.btn_sellstock = new System.Windows.Forms.Button();
            this.pic_product = new System.Windows.Forms.PictureBox();
            this.txt_image = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview_product
            // 
            this.datagridview_product.BackgroundColor = System.Drawing.Color.White;
            this.datagridview_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagridview_product.GridColor = System.Drawing.Color.Gray;
            this.datagridview_product.Location = new System.Drawing.Point(0, 0);
            this.datagridview_product.Name = "datagridview_product";
            this.datagridview_product.RowHeadersWidth = 51;
            this.datagridview_product.RowTemplate.Height = 24;
            this.datagridview_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_product.Size = new System.Drawing.Size(1399, 150);
            this.datagridview_product.TabIndex = 0;
            this.datagridview_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_product_CellClick);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(735, 180);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(83, 34);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(735, 291);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(83, 34);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(735, 398);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(83, 34);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(735, 503);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 34);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inventory Quantity";
            // 
            // txt_pid
            // 
            this.txt_pid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pid.Location = new System.Drawing.Point(269, 180);
            this.txt_pid.Multiline = true;
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.Size = new System.Drawing.Size(261, 30);
            this.txt_pid.TabIndex = 9;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(269, 238);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(261, 30);
            this.txt_name.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(269, 298);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(261, 30);
            this.txt_price.TabIndex = 11;
            // 
            // txt_iq
            // 
            this.txt_iq.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iq.Location = new System.Drawing.Point(269, 355);
            this.txt_iq.Multiline = true;
            this.txt_iq.Name = "txt_iq";
            this.txt_iq.Size = new System.Drawing.Size(261, 30);
            this.txt_iq.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search Product";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(269, 413);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(261, 30);
            this.txt_search.TabIndex = 14;
            // 
            // btn_filter
            // 
            this.btn_filter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter.Location = new System.Drawing.Point(735, 601);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(83, 34);
            this.btn_filter.TabIndex = 15;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Filter Product";
            // 
            // txt_filter
            // 
            this.txt_filter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filter.Location = new System.Drawing.Point(269, 479);
            this.txt_filter.Multiline = true;
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.Size = new System.Drawing.Size(261, 30);
            this.txt_filter.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Goods In Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 608);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Goods Out Of Stock";
            // 
            // txt_add
            // 
            this.txt_add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add.Location = new System.Drawing.Point(269, 545);
            this.txt_add.Multiline = true;
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(261, 30);
            this.txt_add.TabIndex = 20;
            // 
            // txt_sell
            // 
            this.txt_sell.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sell.Location = new System.Drawing.Point(269, 605);
            this.txt_sell.Multiline = true;
            this.txt_sell.Name = "txt_sell";
            this.txt_sell.Size = new System.Drawing.Size(261, 30);
            this.txt_sell.TabIndex = 21;
            // 
            // btn_addstock
            // 
            this.btn_addstock.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addstock.Location = new System.Drawing.Point(441, 730);
            this.btn_addstock.Name = "btn_addstock";
            this.btn_addstock.Size = new System.Drawing.Size(115, 34);
            this.btn_addstock.TabIndex = 22;
            this.btn_addstock.Text = "Add Stock";
            this.btn_addstock.UseVisualStyleBackColor = true;
            this.btn_addstock.Click += new System.EventHandler(this.btn_addstock_Click);
            // 
            // btn_sellstock
            // 
            this.btn_sellstock.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sellstock.Location = new System.Drawing.Point(235, 730);
            this.btn_sellstock.Name = "btn_sellstock";
            this.btn_sellstock.Size = new System.Drawing.Size(115, 34);
            this.btn_sellstock.TabIndex = 23;
            this.btn_sellstock.Text = "Sell Stock";
            this.btn_sellstock.UseVisualStyleBackColor = true;
            // 
            // pic_product
            // 
            this.pic_product.Location = new System.Drawing.Point(934, 238);
            this.pic_product.Name = "pic_product";
            this.pic_product.Size = new System.Drawing.Size(393, 357);
            this.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_product.TabIndex = 24;
            this.pic_product.TabStop = false;
            // 
            // txt_image
            // 
            this.txt_image.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_image.Location = new System.Drawing.Point(269, 675);
            this.txt_image.Multiline = true;
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(261, 30);
            this.txt_image.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 678);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Image";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1067, 628);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Product Image";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 790);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_image);
            this.Controls.Add(this.pic_product);
            this.Controls.Add(this.btn_sellstock);
            this.Controls.Add(this.btn_addstock);
            this.Controls.Add(this.txt_sell);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_filter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_iq);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_pid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.datagridview_product);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview_product;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pid;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_iq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_filter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.TextBox txt_sell;
        private System.Windows.Forms.Button btn_addstock;
        private System.Windows.Forms.Button btn_sellstock;
        private System.Windows.Forms.PictureBox pic_product;
        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}