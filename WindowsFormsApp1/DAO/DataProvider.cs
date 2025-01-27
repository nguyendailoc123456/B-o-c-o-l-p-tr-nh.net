using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;//ctrl+r+e
       

        public static DataProvider Instance {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
        private set { DataProvider.instance = value; }
        }
        private DataProvider() { }

        private string connectionSTR = string.Empty; //dán cơ sở dữ liệu vào


        public int ExcutenunQuery(string query, object[] parameter = null)
        {
            object data = 0;
            using ( SqlConnection connection = new SqlConnection(connectionSTR))
            { 
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] lispara = query.Split(' ');
                    int i = 0;
                    foreach (string ỉtem in lispara) 
                    {
                        if ( item.contains('@') )
                        {
                            command.Parameters.adddwithvalue( item, parameter[i]);
                            i++;
                        }    
                    }
                }
            data= command.ExecuteScalar();    
            connection.Close();
             }
            return data;
        }
       }
    }
    
