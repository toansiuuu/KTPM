using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietChucNangDAO
    {
        public List<string> getMaCNbyMaQuyen(string maQ)
        {
            List<string> list = new List<string>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string selectQuery = "SELECT MaCN FROM CHITIETCHUCNANG WHERE MaQuyen = @maQ";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@maQ", maQ);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }
                connection.Close();
            }
            return list;
        }
        public List<ChiTietChucNang> getAllChiTietChucNangByMa(string maQ)
        {
            List<ChiTietChucNang> list = new List<ChiTietChucNang>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string selectQuery = "SELECT * FROM CHITIETCHUCNANG WHERE MaQuyen = @maQ";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@maQ", maQ);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ChiTietChucNang ctcn = new ChiTietChucNang();
                        ctcn.SGMaCN = reader.GetString(0);
                        ctcn.SGMaQuyen = reader.GetString(1);
                        ctcn.SGChiTiet = reader.GetString(2);
                        list.Add(ctcn);
                    }
                }
                connection.Close();
            }
            return list;
        }
        public void UpdateChiTietChucNang(ChiTietChucNang ctcn)
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string updateQuery = "UPDATE CHITIETCHUCNANG SET ChiTiet = @chiTiet WHERE MaCN = @maCN AND MaQuyen = @maQuyen";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@chiTiet", ctcn.SGChiTiet);
                    command.Parameters.AddWithValue("@maCN", ctcn.SGMaCN);
                    command.Parameters.AddWithValue("@maQuyen", ctcn.SGMaQuyen);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void InsertChiTietChucNang(ChiTietChucNang ctcn)
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();

                // Check if the referenced value exists before inserting
                if (IsMaCNValid(ctcn.SGMaCN, connection))
                {
                    string insertQuery = "INSERT INTO CHITIETCHUCNANG (MaCN, MaQuyen, ChiTiet) VALUES (@maCN, @maQuyen, @chiTiet)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@maCN", ctcn.SGMaCN);
                        command.Parameters.AddWithValue("@maQuyen", ctcn.SGMaQuyen);
                        command.Parameters.AddWithValue("@chiTiet", ctcn.SGChiTiet);
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Handle the case where the referenced value does not exist
                    Console.WriteLine("Invalid MaCN value");
                }

                connection.Close();
            }
        }

        private bool IsMaCNValid(string maCN, SqlConnection connection)
        {
            // Check if the value exists in the referenced table
            string query = "SELECT 1 FROM CHUCNANG WHERE MaCN = @maCN";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@maCN", maCN);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }
        public void DeleteChiTietChucNang(string maCN, string maQuyen)
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string deleteQuery = "DELETE FROM CHITIETCHUCNANG WHERE MaCN = @maCN AND MaQuyen = @maQuyen";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@maCN", maCN);
                    command.Parameters.AddWithValue("@maQuyen", maQuyen);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
