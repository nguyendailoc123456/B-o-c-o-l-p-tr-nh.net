using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbusername_TextChanged(object sender, EventArgs e)
        {

        }
        private void logging_Click(object sender, EventArgs e)
        {
            string username = txbusername.Text;
            string password = txbpassword.Text;    
            if (login(username, password))
            {

            Tablemanager f = new Tablemanager ();
            this.Hide();
            f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("sai tên hiển thị hoặc tài khoản!");
            }
        }
    bool login(string username, string password)
        {
            return AccountDAO.instance.login(username, password);   
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Thông Báo" , MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

    }
}