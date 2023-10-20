using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTin
{
    internal class Global
    {

        public static String getConnectionString()
        {
            String str = ConfigurationManager.ConnectionStrings["thongTin"].ConnectionString;
            return str;
        }

        public static SqlConnection getConnection()
        {
            String connString = getConnectionString();
            SqlConnection conn = new SqlConnection(connString);
            if(conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }

        public static int ToInt(object obj)
        {
            int i = 0; 
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
}
