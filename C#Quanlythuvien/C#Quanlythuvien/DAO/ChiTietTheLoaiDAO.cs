using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietTheLoaiDAO
    {
        public List<ChiTietTheLoai> getAllChiTietTheLoai()
        {
            List<ChiTietTheLoai> list_cttl = new List<ChiTietTheLoai>();

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM CHITIETTHELOAI", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ChiTietTheLoai cttl = new ChiTietTheLoai();
                        cttl.SGMaTheLoai = reader.GetString(0);
                        cttl.SGMaTuaSach = reader.GetString(1);
                    }
                    return list_cttl;
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
            return list_cttl;
        }

        public List<ChiTietTheLoai> GetCttlByIDTheLoai(String matheloai)
        {
            List<ChiTietTheLoai> list = new List<ChiTietTheLoai>();

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM CHITIETTHELOAI where MaTheLoai = @MaTheLoai", connection);
                    command.Parameters.AddWithValue("@MaTheLoai", matheloai);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ChiTietTheLoai cttl = new ChiTietTheLoai();
                        cttl.SGMaTheLoai = reader.GetString(0);
                        cttl.SGMaTuaSach = reader.GetString(1);
                        list.Add(cttl);
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

        public List<ChiTietTheLoai> GetChiTietTheLoaiByIDSach(String id)
        {
            List<ChiTietTheLoai> list_cttl = new List<ChiTietTheLoai>();

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM CHITIETTHELOAI where MaTuaSach = @MaTuaSach", connection);
                    command.Parameters.AddWithValue("@MaTuaSach", id);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ChiTietTheLoai cttl = new ChiTietTheLoai();
                        cttl.SGMaTheLoai = reader.GetString(0);
                        cttl.SGMaTuaSach = reader.GetString(1);
                        list_cttl.Add(cttl);
                    }
                    return list_cttl;
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
            return list_cttl;
        }

        public Boolean addChiTietTheLoai(String maTuaSach, String maTheLoai)
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();

                    string sqlInsert = "INSERT INTO CHITIETTHELOAI(MaTuaSach,MaTheLoai) VALUES(@MaTuaSach,@MaTheLoai)";

                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        command.Parameters.AddWithValue("@MaTuaSach", maTuaSach);
                        command.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error! " + ex.ToString());
                    return false;
                }
            }
        }

        public Boolean deleteChiTietTheLoaibyID(String maTuaSach, String maTheLoai)
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM CHITIETTHELOAI WHERE MaTuaSach = @MaTuaSach and MaTheLoai = @MaTheLoai", connection);
                    command.Parameters.AddWithValue("@MaTuaSach", maTuaSach);
                    command.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error! " + ex.ToString());
                    return false;
                }
            }
        }
        public Boolean deleteChiTietTheLoaibyID(String maTuaSach)
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM CHITIETTHELOAI WHERE MaTuaSach = @MaTuaSach", connection);
                    command.Parameters.AddWithValue("@MaTuaSach", maTuaSach);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error! " + ex.ToString());
                    return false;
                }
            }
        }
    }
}
