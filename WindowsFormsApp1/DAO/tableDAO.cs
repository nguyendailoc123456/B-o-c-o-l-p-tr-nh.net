using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class tableDAO
    {
        private static tableDAO instance;

        public static tableDAO instance
        {
            get { if (instance == null) instance = new tableDAO(); return tableDAO.instance; }
            private set { tableDAO.instance = value; }
        }
        public static int Tablewidth = 100;
        public static int Tableheight = 100;  
        private tableDAO() { }
        public List<table> Loadtablelist()
        { 

            List<table> tablelist = new List<table>();
            DataTable data = DataProvider.instance.ExecuteQuery("usp_gettablelist");
            foreach (DataRow row in data.Rows)
            {
                table table = new table( item );
                tablelist.Add(table);
            }    
            return tablelist;
        }
    }
}
