using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DocGiaDAO
    {
        public List<DocGia> getAllDocGia()
        {
            List<DocGia> list = new List<DocGia>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM DOCGIA", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DocGia dg = new DocGia();
                        dg.SGMaDocGia = reader.GetString(0);
                        dg.SGTenDG = reader.GetString(1);
                        dg.SGNgaySinh = reader.GetDateTime(2);
                        dg.SGDiaChi = reader.GetString(3);
                        dg.SGEmail = reader.GetString(4);
                        dg.SGSDT = reader.GetString(5);
                        dg.SGTrangThai = reader.GetBoolean(6);
                        list.Add(dg);
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

        public DocGia getDocGiaByMa(String madg)
        {
            DocGia dg = new DocGia();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM DOCGIA where MaDocGia = @MaDocGia", connection);
                    command.Parameters.AddWithValue("@MaDocGia", madg);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dg.SGMaDocGia = reader.GetString(0);
                        dg.SGTenDG = reader.GetString(1);
                        dg.SGNgaySinh = reader.GetDateTime(2);
                        dg.SGDiaChi = reader.GetString(3);
                        dg.SGEmail = reader.GetString(4);
                        dg.SGSDT = reader.GetString(5);
                        dg.SGTrangThai = reader.GetBoolean(6);
                    }
                    return dg;
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
            return dg;
        }
        public Boolean updateTinhTrang(DocGia dg)
        {
            int rowAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "UPDATE DOCGIA SET TrangThai = @TrangThai where MaDocGia = @MaDocGia";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@TrangThai", dg.SGTrangThai);
                command.Parameters.AddWithValue("@MaDocGia", dg.SGMaDocGia);

                rowAffected = command.ExecuteNonQuery();
            }
            return rowAffected > 0;
        }

        public String getLastMaDocGia()
        {

            String mats = "";
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select top 1 MaDocGia from DOCGIA order by MaDocGia desc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mats = reader.GetString(0);
                }
                connection.Close();
            }
            return mats;
        }

        public Boolean addDocGia(DocGia dg)
        {
            int rowAffected = 0;

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO DOCGIA(MaDocGia,TenDg,NgaySinh,DiaChi,Email,SDT,TrangThai) values(@MaDocGia,@TenDocGia,@NgaySinh,@DiaChi,@Email,@SDT,@TrangThai)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@MaDocGia", dg.SGMaDocGia);
                command.Parameters.AddWithValue("@TenDocGia", dg.SGTenDG);
                command.Parameters.AddWithValue("@NgaySinh", dg.SGNgaySinh);
                command.Parameters.AddWithValue("@DiaChi", dg.SGDiaChi);
                command.Parameters.AddWithValue("@Email", dg.SGEmail);
                command.Parameters.AddWithValue("@SDT", dg.SGSDT);
                command.Parameters.AddWithValue("@TrangThai", dg.SGTrangThai);
                rowAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            return rowAffected > 0;
        }

        public Boolean editDocGia(DocGia dg)
        {
            int rowAffected = 0;

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "UPDATE DOCGIA SET TenDg = @TenDocGia,NgaySinh = @NgaySinh,DiaChi = @DiaChi,Email = @Email,SDT = @SDT,TrangThai = @TrangThai where MaDocGia = @MaDocGia ";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@TenDocGia", dg.SGTenDG);
                command.Parameters.AddWithValue("@NgaySinh", dg.SGNgaySinh);
                command.Parameters.AddWithValue("@DiaChi", dg.SGDiaChi);
                command.Parameters.AddWithValue("@Email", dg.SGEmail);
                command.Parameters.AddWithValue("@SDT", dg.SGSDT);
                command.Parameters.AddWithValue("@TrangThai", dg.SGTrangThai);
                command.Parameters.AddWithValue("@MaDocGia", dg.SGMaDocGia);
                rowAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            return rowAffected > 0;
        }
        public bool isExitDG(String maDG)
        {
            bool flag = false;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM DOCGIA WHERE MaDocGia = @MaDocGia", connection);
                    command.Parameters.AddWithValue("@MaDocGia", maDG);
                    int rowCount = Convert.ToInt32(command.ExecuteScalar());
                    if (rowCount > 0)
                    {
                        flag = true;
                    }
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
            return flag;
        }
    }
}
