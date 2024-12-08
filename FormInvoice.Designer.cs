namespace WindowsFormsApp1
{
    partial class FormInvoice
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
            this.lb_od = new System.Windows.Forms.Label();
            this.lb_ta = new System.Windows.Forms.Label();
            this.lb_invoice = new System.Windows.Forms.Label();
            this.lb_dash = new System.Windows.Forms.Label();
            this.lb_dash2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_od
            // 
            this.lb_od.AutoSize = true;
            this.lb_od.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_od.Location = new System.Drawing.Point(227, 126);
            this.lb_od.Name = "lb_od";
            this.lb_od.Size = new System.Drawing.Size(114, 19);
            this.lb_od.TabIndex = 34;
            this.lb_od.Text = "Order Details";
            // 
            // lb_ta
            // 
            this.lb_ta.AutoSize = true;
            this.lb_ta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ta.Location = new System.Drawing.Point(227, 305);
            this.lb_ta.Name = "lb_ta";
            this.lb_ta.Size = new System.Drawing.Size(115, 19);
            this.lb_ta.TabIndex = 35;
            this.lb_ta.Text = "Total Amount";
            // 
            // lb_invoice
            // 
            this.lb_invoice.AutoSize = true;
            this.lb_invoice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_invoice.Location = new System.Drawing.Point(352, 46);
            this.lb_invoice.Name = "lb_invoice";
            this.lb_invoice.Size = new System.Drawing.Size(80, 19);
            this.lb_invoice.TabIndex = 36;
            this.lb_invoice.Text = "INVOICE";
            // 
            // lb_dash
            // 
            this.lb_dash.AutoSize = true;
            this.lb_dash.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dash.Location = new System.Drawing.Point(227, 79);
            this.lb_dash.Name = "lb_dash";
            this.lb_dash.Size = new System.Drawing.Size(303, 19);
            this.lb_dash.TabIndex = 37;
            this.lb_dash.Text = "------------------------------------------";
            // 
            // lb_dash2
            // 
            this.lb_dash2.AutoSize = true;
            this.lb_dash2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dash2.Location = new System.Drawing.Point(227, 272);
            this.lb_dash2.Name = "lb_dash2";
            this.lb_dash2.Size = new System.Drawing.Size(303, 19);
            this.lb_dash2.TabIndex = 38;
            this.lb_dash2.Text = "------------------------------------------";
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_dash2);
            this.Controls.Add(this.lb_dash);
            this.Controls.Add(this.lb_invoice);
            this.Controls.Add(this.lb_ta);
            this.Controls.Add(this.lb_od);
            this.Name = "FormInvoice";
            this.Text = "FormInvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_od;
        private System.Windows.Forms.Label lb_ta;
        private System.Windows.Forms.Label lb_invoice;
        private System.Windows.Forms.Label lb_dash;
        private System.Windows.Forms.Label lb_dash2;
    }
}