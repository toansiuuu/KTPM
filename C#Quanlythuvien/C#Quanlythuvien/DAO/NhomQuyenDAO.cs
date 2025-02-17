using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhomQuyenDAO
    {
        public List<NhomQuyen> getAllNhomQuyen()
        {
            List<NhomQuyen> list = new List<NhomQuyen>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM NHOMQUYEN", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhomQuyen nq = new NhomQuyen();
                    nq.SGMaQuyen = reader.GetString(0);
                    nq.SGTenQuyen = reader.GetString(1);
                    nq.SGMoTa = reader.GetString(2);
                    list.Add(nq);
                }
                connection.Close();
            }

            return list;
        }
    }
}
