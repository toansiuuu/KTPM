using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DataBaseConnection
    {
        public static SqlConnection Connect()
        {
            string strconn = "Data Source=localhost;Initial Catalog=QLTV;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
    }
}
