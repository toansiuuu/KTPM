using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheLoaiDAO
    {
        public List<TheLoaiDTO> getAllTheLoai()
        {
            List<TheLoaiDTO> list = new List<TheLoaiDTO>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM TheLoai", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TheLoaiDTO tl = new TheLoaiDTO();
                    tl.MaTL = reader.GetString(0);
                    tl.TenTL = reader.GetString(1);                   
                    tl.MoTa = reader.GetString(2);
                    list.Add(tl);
                }

                connection.Close();
            }
                return list;
        }

        public TheLoaiDTO getTlByID(String id)
        {
            List<TheLoaiDTO> list = getAllTheLoai();
            TheLoaiDTO tl = new TheLoaiDTO();
            foreach (TheLoaiDTO x in list)
            {
                if (x.MaTL == id)
                {
                    tl.MaTL = x.MaTL;
                    tl.TenTL = x.TenTL;
                    tl.MoTa = x.MoTa;
                    return tl;
                }
            }
            return tl;
        }

        public String getLastMaTL()
        {
            String mapm = "";
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select top 1 matheloai from theloai order by matheloai desc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mapm = reader.GetString(0);
                }
                connection.Close();
            }
            return mapm;
        }
        public int insertTL(TheLoaiDTO tl)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO TheLoai (matheloai, tentheloai,moTa) VALUES (@maTL,@tenTL,@moTa)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@maTL", tl.MaTL);
                    command.Parameters.AddWithValue("@tenTL", tl.TenTL);
                    command.Parameters.AddWithValue("@moTa", tl.MoTa);
                    ;

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int updateTheLoai(TheLoaiDTO tl)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string updateQuery = "UPDATE TheLoai SET tentheloai = @tenTL, moTa = @moTa WHERE matheloai = @maTL";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@maTL", tl.MaTL);
                    command.Parameters.AddWithValue("@tenTL", tl.TenTL);
                    command.Parameters.AddWithValue("@moTa", tl.MoTa);

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}
