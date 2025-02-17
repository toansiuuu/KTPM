using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheThuVienDAO
    {
        public List<TheThuVien> getAllTheThuVien()
        {
            List<TheThuVien> list = new List<TheThuVien>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM THETHUVIEN", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TheThuVien ttv = new TheThuVien();
                        ttv.SGMaThe = reader.GetString(0);
                        ttv.SGMaDocGia = reader.GetString(1);
                        ttv.SGNgayLapThe = reader.GetDateTime(2);
                        ttv.SGNgayHetHan = reader.GetDateTime(3);
                        list.Add(ttv);
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

        public TheThuVien getTheByDocGia(String madg)
        {
            TheThuVien theThuVien = new TheThuVien();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from THETHUVIEN where MaDocGia = @MaDocGia", connection);
                command.Parameters.AddWithValue("@MaDocGia", madg);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    theThuVien.SGMaThe = reader.GetString(0);
                    theThuVien.SGMaDocGia = reader.GetString(1);
                    theThuVien.SGNgayLapThe = reader.GetDateTime(2);
                    theThuVien.SGNgayHetHan = reader.GetDateTime(3);
                }
                connection.Close();
            }
            return theThuVien;
        }

        public TheThuVien getTheByMa(String mathe)
        {
            TheThuVien theThuVien = new TheThuVien();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from THETHUVIEN where MaThe = @MaThe", connection);
                command.Parameters.AddWithValue("@MaThe", mathe);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    theThuVien.SGMaThe = reader.GetString(0);
                    theThuVien.SGMaDocGia = reader.GetString(1);
                    theThuVien.SGNgayLapThe = reader.GetDateTime(2);
                    theThuVien.SGNgayHetHan = reader.GetDateTime(3);
                }
                connection.Close();
            }
            return theThuVien;
        }

        public Boolean checkDocGia(String maDocGia)
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM THETHUVIEN WHERE MaDocGia = @MaDocGia", connection);
                    command.Parameters.AddWithValue("@MaDocGia", maDocGia);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }

                return false;
            }
        }
        public String getLastMaThe()
        {
            String mathe = "";
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select top 1 MaThe from TheThuVien order by MaThe desc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mathe = reader.GetString(0);
                }
                connection.Close();
            }
            return mathe;
        }

        public Boolean addTheThuVien(TheThuVien ttv)
        {
            int rowAffected = 0;

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO THETHUVIEN(MaThe, MaDocGia, NgayLapThe, NgayHetHan) VALUES (@MaThe, @MaDocGia, @NgayLapThe, @NgayHetHan)";
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@MaThe", ttv.SGMaThe);
                    command.Parameters.AddWithValue("@MaDocGia", ttv.SGMaDocGia);
                    command.Parameters.AddWithValue("@NgayLapThe", ttv.SGNgayLapThe);
                    command.Parameters.AddWithValue("@NgayHetHan", ttv.SGNgayHetHan);

                    rowAffected = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return rowAffected > 0;
        }
        public Boolean updateTheThuVien(TheThuVien ttv)
        {
            int rowAffected = 0;

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    string insertQuery = "update THETHUVIEN set NgayLapThe = @NgayLapThe, NgayHetHan = @NgayHetHan where MaThe = @MaThe";
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@NgayLapThe", ttv.SGNgayLapThe);
                    command.Parameters.AddWithValue("@NgayHetHan", ttv.SGNgayHetHan);
                    command.Parameters.AddWithValue("@MaThe", ttv.SGMaThe);
                    rowAffected = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return rowAffected > 0;
        }
    }
}
