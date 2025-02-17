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
    public class NhaCungCapDAO
    {
        SqlDataAdapter da;
        DataSet ds;
        public static SqlConnection sqlConn = DataBaseConnection.Connect();
        public DataTable getAllNhaCungCapDataTable()
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                String sqlStr = "Select * from NhaCungCap";
                da = new SqlDataAdapter(sqlStr, connection);
                ds = new DataSet();
                da.Fill(ds);
                connection.Close();
                return ds.Tables[0];
            }
        }
        public String getLastMaNCC()
        {
            String mapm = "";
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select top 1 maNCC from nhacungcap order by maNCC desc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mapm = reader.GetString(0);
                }
                connection.Close();
            }
            return mapm;
        }
        public List<NhaCungCap> getALLNhaCungCap()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                Console.WriteLine(connection);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM NhaCungCap", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhaCungCap ncc = new NhaCungCap();
                    ncc.SGMaNCC = reader.GetString(0);
                    ncc.SGTenNCC = reader.GetString(1);
                    ncc.SGDiaChi = reader.GetString(2);
                    ncc.SGEmail = reader.GetString(3);
                    ncc.SGTrangThai = reader.GetBoolean(4);
                    list.Add(ncc);
                }
                connection.Close();
            }
            return list;
        }
        public int insertNhaCungCap(NhaCungCap ncc)
        {
            int rowAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO NhaCungCap(mancc,tenncc,diaChi,email,trangThai) values (@mancc,@tenncc,@diaChi,@email,@trangThai)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@mancc", ncc.SGMaNCC);
                command.Parameters.AddWithValue("@tenncc", ncc.SGTenNCC);
                command.Parameters.AddWithValue("@diaChi", ncc.SGDiaChi);
                command.Parameters.AddWithValue("@email", ncc.SGEmail);
                command.Parameters.AddWithValue("@trangThai", ncc.SGTrangThai);
                rowAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            return rowAffected;
        }
        public int getSLNCC()
        {
            int sl = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM NhaCungCap", connection);
                sl = (int)command.ExecuteScalar();
                connection.Close();
            }
            return sl;
        }
        public NhaCungCap getNhaCungCapByMa(string maNCC)
        {
            NhaCungCap ncc = new NhaCungCap();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string query = "SELECT * FROM NhaCungCap WHERE manhacungcap = @maNCC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@mancc", maNCC);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ncc.SGMaNCC = reader.GetString(0);
                    ncc.SGTenNCC = reader.GetString(1);
                    ncc.SGDiaChi = reader.GetString(2);
                    ncc.SGEmail = reader.GetString(3);
                    ncc.SGTrangThai = reader.GetBoolean(4);
                }
                connection.Close();

            }
            return ncc;
        }
        public int updateNhaCungCap(NhaCungCap ncc)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string updateQuery = "UPDATE NhaCungCap SET tenNCC = @tenNCC, diaChi = @diaChi, email=@email, trangThai = @trangThai Where maNCC = @maNCC";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@tenncc", ncc.SGTenNCC);
                    command.Parameters.AddWithValue("@diaChi", ncc.SGDiaChi);
                    command.Parameters.AddWithValue("@email", ncc.SGEmail);
                    command.Parameters.AddWithValue("@trangThai", ncc.SGTrangThai);
                    command.Parameters.AddWithValue("@mancc", ncc.SGMaNCC);
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int deleteNhaCungCap(string maNCC)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string deleteQuery = "DELETE FROM NhaCungCap WHERE manhacungcap = @maNCC";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@mancc", maNCC);
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}
