using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaXuatBanDAO
    {
        SqlDataAdapter da;
        DataSet ds;
        public NhaXuatBan getNhaXuatBanByID(String manxb)
        {
            NhaXuatBan t = new NhaXuatBan();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string query = "SELECT * FROM NHAXUATBAN WHERE MaNXB = @MaNXB";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNXB", manxb);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    t.SGMaNXB = reader.GetString(0);
                    t.SGTenNXB = reader.GetString(1);
                    t.SGDiaChiNXB = reader.GetString(2);
                    t.SGEmailNXB = reader.GetString(3);
                    t.SGTrangThai = reader.GetBoolean(4);
                }
                connection.Close();

            }
            return t;
        }
        public List<NhaXuatBan> getAllListNXB()
        {
            List<NhaXuatBan> list = new List<NhaXuatBan>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM NHAXUATBAN", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        NhaXuatBan nxb = new NhaXuatBan();
                        nxb.SGMaNXB = reader.GetString(0);
                        nxb.SGTenNXB = reader.GetString(1);
                        nxb.SGDiaChiNXB = reader.GetString(2);
                        nxb.SGEmailNXB = reader.GetString(3);
                        nxb.SGTrangThai = reader.GetBoolean(4);
                        list.Add(nxb);
                    }
                    return list;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error! " + ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            return list;
        }
        public DataTable getALlNXB()
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                String sqlStr = "Select * from NhaXuatBan";
                da = new SqlDataAdapter(sqlStr, connection);
                ds = new DataSet();
                da.Fill(ds);
                connection.Close();
                return ds.Tables[0];
            }
        }
        public String getLastMaNXB()
        {
            String mapm = "";
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select top 1 maNXB from nhaxuatban order by maNXB desc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mapm = reader.GetString(0);
                }
                connection.Close();
            }
            return mapm;
        }
        public bool addNXB(NhaXuatBan nxb)
        {
            bool flag = false;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO NhaXuatBan(manxb,tennxb,diachinxb,emailnxb,trangThai) values (@manxb,@tennxb,@diachinxb,@emailnxb,@trangThai)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@manxb", nxb.SGMaNXB);
                command.Parameters.AddWithValue("@tennxb", nxb.SGTenNXB);
                command.Parameters.AddWithValue("@diachinxb", nxb.SGDiaChiNXB);
                command.Parameters.AddWithValue("@emailnxb", nxb.SGEmailNXB);
                command.Parameters.AddWithValue("@trangThai", nxb.SGTrangThai);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    flag = true;
                }
                connection.Close();
            }
            return flag;
        }
        public bool fixNXB(NhaXuatBan nxb)
        {
            bool flag = false;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "UPDATE NhaXuatBan Set TenNXB = @tennxb, DiaChiNXB = @diachinxb, EmailNXB = @emailnxb, TrangThai = @trangThai WHERE MaNXB = @manxb";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@tennxb", nxb.SGTenNXB);
                command.Parameters.AddWithValue("@diachinxb", nxb.SGDiaChiNXB);
                command.Parameters.AddWithValue("@emailnxb", nxb.SGEmailNXB);
                command.Parameters.AddWithValue("@trangThai", nxb.SGTrangThai);
                command.Parameters.AddWithValue("@manxb", nxb.SGMaNXB);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    flag = true;
                }
                connection.Close();
            }
            return flag;
        }

    }
}
