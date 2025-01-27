using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class foodDAO
    {
        private static foodDAO instance;
        public static foodDAO Instance
        {
            get { if (instance == null) instance = new foodDAO(); return foodDAO.instance; }
            private set { foodDAO.instance = value; }
        }
        private foodDAO() { }
        public List<food> GetfoodbycategoryID(int id)
        {
            List<food> list = new List<food>();
            string query = "select * from food where idcategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                food food = new food(item);
                list.Add(food);
            } 
                
            return list;
        }
    }
}
