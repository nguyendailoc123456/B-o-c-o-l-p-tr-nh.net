using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? datacheckin, DateTime? datacheckout, int status)
        {
            this.iD= id;
            this.datecheckin= datacheckin;
            this.datecheckout= datacheckout;
            this.status= status;    
        }
        public Bill(DataRow row) 
        {
            this.iD = (int) row["id"];
            this.datecheckin = (DateTime?) row["datecheckin"];
            var datecheckouttemp = row["datacheckout"];
            if (datecheckouttemp.ToString() != "")
                this.datecheckout = (DateTime?)datecheckouttemp;
            this.status = (int) row ["status"];
        }

        private int status;9*
        public int status
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime? datecheckout;
        {
            get { return datecheckout; }
            set { datacheckout = value; }
        }
        private DateTime? datecheckin;
        public DateTime? datecheckin
        {
            get { return datecheckin; }
            set { datacheckin = value; }
        }
            private int iD;
        public int iD
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
