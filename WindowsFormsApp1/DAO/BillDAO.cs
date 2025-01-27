using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO(); return instance;)
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        /// <summary>
        /// Thành công = bill ID
        /// Thất bại = -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUnchecBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select*from dbo.bill where idtable = " + id + " and status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.iD;
            }
            return -1;
        }
        public void Insertbill(int id)
        {
            DataProvider.Instance.ExecuteQuery("exec usp_Insertbill @idtable", new object[] {id});

        }
        public int GetMaxidbill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar(" select MAX (id) from dbo.bill");
            }
            catch
            {
                return 1;
            }
        }
    }
}
