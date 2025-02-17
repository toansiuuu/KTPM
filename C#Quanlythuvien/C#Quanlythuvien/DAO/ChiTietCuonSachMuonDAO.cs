using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietCuonSachMuonDAO
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        public DataTable getALlCTCSM()
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                String sqlStr = "Select * from chitietcuonsachmuon";
                da = new SqlDataAdapter(sqlStr, connection);
                ds = new DataSet();
                da.Fill(ds);
                connection.Close();
                return ds.Tables[0];
            }
        }
        public List<String> getCTCSMNotBorrowedFirst(String sql)
        {
            List<String> list = new List<string>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
                connection.Close();
            }
            return list;
        }
        public bool addCTCSM(List<ChiTietCuonSachMuon> listctcsm)
        {
            bool flag = false;
            int count = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO ChiTietCuonSachMuon(MaPhieuMuon,MaTuaSach,MaCuonSach) values (@mapm,@matuasach,@macuonsach)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    foreach (ChiTietCuonSachMuon ctcsm in listctcsm)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@mapm", ctcsm.SGMaPhieuMuon);
                        command.Parameters.AddWithValue("@matuasach", ctcsm.SGMaTuaSach);
                        command.Parameters.AddWithValue("@macuonsach", ctcsm.SGMaCuonSach);
                        int rowAffected = command.ExecuteNonQuery();
                        count += rowAffected;
                    }
                }
                if (count == listctcsm.Count)
                {
                    flag = true;
                }
                connection.Close();
            }
            return flag;
        }
    }
}
