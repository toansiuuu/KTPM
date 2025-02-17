using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChucNangDAO
    {
        public List<ChucNang> getAllChucNang()
        {
            List<ChucNang> list = new List<ChucNang>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM CHUCNANG", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChucNang cn = new ChucNang();
                    cn.SGMaCN = reader.GetString(0);
                    cn.SGTenCN = reader.GetString(1);
                    list.Add(cn);
                }
                connection.Close();
            }
            return list;
        }
    }
}
