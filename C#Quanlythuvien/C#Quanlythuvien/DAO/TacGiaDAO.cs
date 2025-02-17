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
    public class TacGiaDAO
    {
        public List<TacGiaDTO> getAllTacGia()
        {
            List<TacGiaDTO> list = new List<TacGiaDTO>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM TacGia", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TacGiaDTO tg = new TacGiaDTO();
                    tg.MaTG=reader.GetString(0);
                    tg.TenTG=reader.GetString(1);
                    tg.MoTa=reader.GetString(2);
                    tg.TinhTrang = reader.GetBoolean(3);
                    tg.Img = reader.GetString(4);
                    list.Add(tg);
                }
                connection.Close();
            }
            return list;
        }
        public TacGiaDTO getTacGiaByMa(string maTG)
        {
            TacGiaDTO t = new TacGiaDTO();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string query = "SELECT * FROM TacGia WHERE matacgia = @maTG";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maTG", maTG);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    t.MaTG = reader.GetString(0);
                    t.TenTG = reader.GetString(1);
                    t.MoTa = reader.GetString(2);
                    t.TinhTrang=reader.GetBoolean(3);
                    t.Img = reader.GetString(4);
                }
                connection.Close();

            }
            return t;
        }
        public int updateTacGia(TacGiaDTO tg)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string updateQuery = "UPDATE TacGia SET tentacgia = @tenTG, moTa = @moTa, trangthai = @tinhTrang, image = @Img WHERE matacgia = @maTG";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@maTG", tg.MaTG);
                    command.Parameters.AddWithValue("@tenTG", tg.TenTG);
                    command.Parameters.AddWithValue("@moTa", tg.MoTa);
                    command.Parameters.AddWithValue("@tinhTrang", tg.TinhTrang);
                    command.Parameters.AddWithValue("@Img", tg.Img);

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public String getLastMaTG()
        {
            String mapm = "";
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select top 1 matacgia from tacgia order by matacgia desc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mapm = reader.GetString(0);
                }
                connection.Close();
            }
            return mapm;
        }
        public int insertTacGia(TacGiaDTO tg)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO TacGia (matacgia, tentacgia, moTa, trangthai, image) VALUES (@maTG,@tenTG, @moTa, @tinhTrang, @Img)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@maTG", tg.MaTG);
                    command.Parameters.AddWithValue("@tenTG", tg.TenTG);
                    command.Parameters.AddWithValue("@moTa", tg.MoTa);
                    command.Parameters.AddWithValue("@tinhTrang", tg.TinhTrang);
                    command.Parameters.AddWithValue("@Img", tg.Img);

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

    }
}
