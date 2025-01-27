using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class Tablemanager : Form
    {
        public Tablemanager()
        {
            InitializeComponent();

            Loadtable();
            Loadcategory();

        }
        #region method
        void Loadcategory()
        {
            List<category> listcategory = CategoryDAO.Instance.Getlistcategory();
            cbCategory.DataSource = listcategory;
            cbCategory.DisplayMember = "Name";
        }
        void LoadfoodlistbycategoryID(int id)
        {
            List<food> listfood = foodDAO.Instance.GetfoodbycategoryID(id);
            cbFood.DataSource = listfood;
            cbFood.DisplayMember = "Name";
        }
        void Loadtable()
        {
            List<table> tablelist = tableDAO.instance.Loadtablelist();
            foreach (table item in tablelist)
            {
                Button btn = new Button() { Width = tableDAO.Tablewidth, Height = tableDAO.Tableheight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click +- btn_Click;
                btn.Tag = item; 

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.DeepPink;
                        break;
                    default:
                        btn.BackColor = Color.HotPink;
                        break;
                }    

                flpTable.Controls.Add(btn);


            }
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<WindowsFormsApp1.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id)
            float totalPrice = 0;
            foreach (WindowsFormsApp1.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Foodname.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
    
            txbTotalPrice.Text = totalPrice.ToString("c".ToLower culture);
        }

        #endregion
        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            int tableid = ((sender as Button).Tag as table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableid);

        }
        #endregion

        private void Tablemanager_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            thongtindangnhap f = new thongtindangnhap();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formadmin formadmin = new Formadmin();
            formadmin.ShowDialog();
        }

        private void buttonswicttable_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            category selected = cb.SelectedItem as category;
            id = selected.ID;

            LoadfoodlistbycategoryID(id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            table table = lsvbill.Tag as table;
            int idbill = BillDAO.Instance.GetUnchecBillIDByTableID(table.ID);
            int foodid = (cbFood.SelectedItem as food).ID;
            int count = (int)nmfoodcount.Value;
            if (idbill == -1)
            {
                BillDAO.Instance.Insertbill(table.ID);
                BillInfoDAO.Instance.Insertbillinfo(BillInfoDAO.Instance.GetMaxidbill(), foodid, count);
            }    
            else
            {
                BillInfoDAO.Instance.Insertbillinfo(idbill, foodid, count);
            }    
            ShowBill(table.ID);
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
