namespace WindowsFormsApp1
{
    partial class dangnhap
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
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonlogging = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonexit);
            this.panel1.Controls.Add(this.buttonlogging);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 182);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonexit
            // 
            this.buttonexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonexit.Location = new System.Drawing.Point(357, 124);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(108, 38);
            this.buttonexit.TabIndex = 3;
            this.buttonexit.Text = "Thoát";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.exit_Click);
            // 
            // buttonlogging
            // 
            this.buttonlogging.Location = new System.Drawing.Point(245, 124);
            this.buttonlogging.Name = "buttonlogging";
            this.buttonlogging.Size = new System.Drawing.Size(106, 38);
            this.buttonlogging.TabIndex = 2;
            this.buttonlogging.Text = "Đăng Nhập";
            this.buttonlogging.UseVisualStyleBackColor = true;
            this.buttonlogging.Click += new System.EventHandler(this.logging_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbpassword);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(6, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 48);
            this.panel3.TabIndex = 1;
            // 
            // txbpassword
            // 
            this.txbpassword.Location = new System.Drawing.Point(139, 12);
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.Size = new System.Drawing.Size(317, 20);
            this.txbpassword.TabIndex = 1;
            this.txbpassword.Text = "1";
            this.txbpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbusername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 48);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txbusername
            // 
            this.txbusername.Location = new System.Drawing.Point(139, 12);
            this.txbusername.Name = "txbusername";
            this.txbusername.Size = new System.Drawing.Size(317, 20);
            this.txbusername.TabIndex = 1;
            this.txbusername.Text = "dailoc";
            this.txbusername.TextChanged += new System.EventHandler(this.txbusername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dangnhap
            // 
            this.AcceptButton = this.buttonlogging;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonexit;
            this.ClientSize = new System.Drawing.Size(502, 209);
            this.Controls.Add(this.panel1);
            this.Name = "dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dangnhap_FormClosing);
            this.Load += new System.EventHandler(this.dangnhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbusername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonlogging;
        private System.Windows.Forms.Button buttonexit;
    }
}

