namespace WindowsFormsApp1
{
    partial class thongtindangnhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxtendangnhap = new System.Windows.Forms.TextBox();
            this.labeltendangnhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxtenhienthi = new System.Windows.Forms.TextBox();
            this.labeltenhienthi = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxmatkhau = new System.Windows.Forms.TextBox();
            this.labelmatkhau = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxmatkhaumoi = new System.Windows.Forms.TextBox();
            this.labelmatkhaumoi = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelnhaplaimatkhaumoi = new System.Windows.Forms.Label();
            this.buttoncapnhatmatkhau = new System.Windows.Forms.Button();
            this.buttonthoatcapnhatmatkhau = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxtendangnhap);
            this.panel1.Controls.Add(this.labeltendangnhap);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 44);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxtendangnhap
            // 
            this.textBoxtendangnhap.Location = new System.Drawing.Point(139, 12);
            this.textBoxtendangnhap.Name = "textBoxtendangnhap";
            this.textBoxtendangnhap.ReadOnly = true;
            this.textBoxtendangnhap.Size = new System.Drawing.Size(190, 20);
            this.textBoxtendangnhap.TabIndex = 1;
            this.textBoxtendangnhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labeltendangnhap
            // 
            this.labeltendangnhap.AutoSize = true;
            this.labeltendangnhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltendangnhap.Location = new System.Drawing.Point(3, 11);
            this.labeltendangnhap.Name = "labeltendangnhap";
            this.labeltendangnhap.Size = new System.Drawing.Size(130, 19);
            this.labeltendangnhap.TabIndex = 0;
            this.labeltendangnhap.Text = "Tên đăng nhập:";
            this.labeltendangnhap.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxtenhienthi);
            this.panel2.Controls.Add(this.labeltenhienthi);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 44);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBoxtenhienthi
            // 
            this.textBoxtenhienthi.Location = new System.Drawing.Point(139, 12);
            this.textBoxtenhienthi.Name = "textBoxtenhienthi";
            this.textBoxtenhienthi.Size = new System.Drawing.Size(190, 20);
            this.textBoxtenhienthi.TabIndex = 1;
            // 
            // labeltenhienthi
            // 
            this.labeltenhienthi.AutoSize = true;
            this.labeltenhienthi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltenhienthi.Location = new System.Drawing.Point(3, 11);
            this.labeltenhienthi.Name = "labeltenhienthi";
            this.labeltenhienthi.Size = new System.Drawing.Size(104, 19);
            this.labeltenhienthi.TabIndex = 0;
            this.labeltenhienthi.Text = "Tên hiển thị:";
            this.labeltenhienthi.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxmatkhau);
            this.panel3.Controls.Add(this.labelmatkhau);
            this.panel3.Location = new System.Drawing.Point(12, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 44);
            this.panel3.TabIndex = 4;
            // 
            // textBoxmatkhau
            // 
            this.textBoxmatkhau.Location = new System.Drawing.Point(139, 12);
            this.textBoxmatkhau.Name = "textBoxmatkhau";
            this.textBoxmatkhau.Size = new System.Drawing.Size(190, 20);
            this.textBoxmatkhau.TabIndex = 1;
            this.textBoxmatkhau.UseSystemPasswordChar = true;
            // 
            // labelmatkhau
            // 
            this.labelmatkhau.AutoSize = true;
            this.labelmatkhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmatkhau.Location = new System.Drawing.Point(3, 11);
            this.labelmatkhau.Name = "labelmatkhau";
            this.labelmatkhau.Size = new System.Drawing.Size(84, 19);
            this.labelmatkhau.TabIndex = 0;
            this.labelmatkhau.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxmatkhaumoi);
            this.panel4.Controls.Add(this.labelmatkhaumoi);
            this.panel4.Location = new System.Drawing.Point(12, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 44);
            this.panel4.TabIndex = 5;
            // 
            // textBoxmatkhaumoi
            // 
            this.textBoxmatkhaumoi.Location = new System.Drawing.Point(139, 12);
            this.textBoxmatkhaumoi.Name = "textBoxmatkhaumoi";
            this.textBoxmatkhaumoi.Size = new System.Drawing.Size(190, 20);
            this.textBoxmatkhaumoi.TabIndex = 1;
            this.textBoxmatkhaumoi.UseSystemPasswordChar = true;
            // 
            // labelmatkhaumoi
            // 
            this.labelmatkhaumoi.AutoSize = true;
            this.labelmatkhaumoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmatkhaumoi.Location = new System.Drawing.Point(3, 11);
            this.labelmatkhaumoi.Name = "labelmatkhaumoi";
            this.labelmatkhaumoi.Size = new System.Drawing.Size(117, 19);
            this.labelmatkhaumoi.TabIndex = 0;
            this.labelmatkhaumoi.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.labelnhaplaimatkhaumoi);
            this.panel5.Location = new System.Drawing.Point(12, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(347, 44);
            this.panel5.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelnhaplaimatkhaumoi
            // 
            this.labelnhaplaimatkhaumoi.AutoSize = true;
            this.labelnhaplaimatkhaumoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnhaplaimatkhaumoi.Location = new System.Drawing.Point(3, 11);
            this.labelnhaplaimatkhaumoi.Name = "labelnhaplaimatkhaumoi";
            this.labelnhaplaimatkhaumoi.Size = new System.Drawing.Size(77, 19);
            this.labelnhaplaimatkhaumoi.TabIndex = 0;
            this.labelnhaplaimatkhaumoi.Text = "Nhập lại:";
            // 
            // buttoncapnhatmatkhau
            // 
            this.buttoncapnhatmatkhau.Location = new System.Drawing.Point(194, 262);
            this.buttoncapnhatmatkhau.Name = "buttoncapnhatmatkhau";
            this.buttoncapnhatmatkhau.Size = new System.Drawing.Size(75, 23);
            this.buttoncapnhatmatkhau.TabIndex = 7;
            this.buttoncapnhatmatkhau.Text = "Cập nhật";
            this.buttoncapnhatmatkhau.UseVisualStyleBackColor = true;
            this.buttoncapnhatmatkhau.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonthoatcapnhatmatkhau
            // 
            this.buttonthoatcapnhatmatkhau.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonthoatcapnhatmatkhau.Location = new System.Drawing.Point(284, 262);
            this.buttonthoatcapnhatmatkhau.Name = "buttonthoatcapnhatmatkhau";
            this.buttonthoatcapnhatmatkhau.Size = new System.Drawing.Size(75, 23);
            this.buttonthoatcapnhatmatkhau.TabIndex = 8;
            this.buttonthoatcapnhatmatkhau.Text = "Thoát";
            this.buttonthoatcapnhatmatkhau.UseVisualStyleBackColor = true;
            this.buttonthoatcapnhatmatkhau.Click += new System.EventHandler(this.buttonthoatcapnhatmatkhau_Click);
            // 
            // thongtindangnhap
            // 
            this.AcceptButton = this.buttoncapnhatmatkhau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonthoatcapnhatmatkhau;
            this.ClientSize = new System.Drawing.Size(373, 301);
            this.Controls.Add(this.buttonthoatcapnhatmatkhau);
            this.Controls.Add(this.buttoncapnhatmatkhau);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "thongtindangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Đăng Nhập";
            this.Load += new System.EventHandler(this.thongtindangnhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxtendangnhap;
        private System.Windows.Forms.Label labeltendangnhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxtenhienthi;
        private System.Windows.Forms.Label labeltenhienthi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxmatkhau;
        private System.Windows.Forms.Label labelmatkhau;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxmatkhaumoi;
        private System.Windows.Forms.Label labelmatkhaumoi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelnhaplaimatkhaumoi;
        private System.Windows.Forms.Button buttoncapnhatmatkhau;
        private System.Windows.Forms.Button buttonthoatcapnhatmatkhau;
    }
}