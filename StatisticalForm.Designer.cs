namespace WindowsFormsApp1
{
    partial class StatisticalForm
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
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.dgv_statistical = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.lb_statistical = new System.Windows.Forms.Label();
            this.btn_statistical = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_statistical)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_from
            // 
            this.dtp_from.Location = new System.Drawing.Point(369, 78);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(200, 22);
            this.dtp_from.TabIndex = 1;
            // 
            // dgv_statistical
            // 
            this.dgv_statistical.BackgroundColor = System.Drawing.Color.White;
            this.dgv_statistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_statistical.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_statistical.GridColor = System.Drawing.Color.Gray;
            this.dgv_statistical.Location = new System.Drawing.Point(0, 299);
            this.dgv_statistical.Name = "dgv_statistical";
            this.dgv_statistical.RowHeadersWidth = 51;
            this.dgv_statistical.RowTemplate.Height = 24;
            this.dgv_statistical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_statistical.Size = new System.Drawing.Size(977, 259);
            this.dgv_statistical.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 22;
            this.label1.Text = "Statistical";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "To";
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(369, 145);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 22);
            this.dtp_to.TabIndex = 27;
            // 
            // lb_statistical
            // 
            this.lb_statistical.AutoSize = true;
            this.lb_statistical.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statistical.Location = new System.Drawing.Point(12, 223);
            this.lb_statistical.Name = "lb_statistical";
            this.lb_statistical.Size = new System.Drawing.Size(236, 19);
            this.lb_statistical.TabIndex = 28;
            this.lb_statistical.Text = "Quantity remaining in stock:";
            // 
            // btn_statistical
            // 
            this.btn_statistical.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistical.Location = new System.Drawing.Point(782, 214);
            this.btn_statistical.Name = "btn_statistical";
            this.btn_statistical.Size = new System.Drawing.Size(106, 39);
            this.btn_statistical.TabIndex = 29;
            this.btn_statistical.Text = "Statistic";
            this.btn_statistical.UseVisualStyleBackColor = true;
            this.btn_statistical.Click += new System.EventHandler(this.btn_statistical_Click_1);
            // 
            // StatisticalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 558);
            this.Controls.Add(this.btn_statistical);
            this.Controls.Add(this.lb_statistical);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_statistical);
            this.Controls.Add(this.dtp_from);
            this.Name = "StatisticalForm";
            this.Text = "StatisticalForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_statistical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.DataGridView dgv_statistical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Label lb_statistical;
        private System.Windows.Forms.Button btn_statistical;
    }
}