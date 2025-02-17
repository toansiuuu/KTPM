using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietPhieuNhapDAO
    {
        public int InsertChiTietPhieuNhapList(List<ChiTietPhieuNhap> list)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO CHITIETPHIEUNHAP(MaPhieuNhap, MaTuaSach, SoLuong, DonGia) VALUES ";

                // Tạo tham số cho mỗi bản ghi
                List<SqlParameter> parameters = new List<SqlParameter>();

                for (int i = 0; i < list.Count; i++)
                {
                    ChiTietPhieuNhap ctpn = list[i];
                    string values = $"(@mpn{i}, @mts{i}, @sl{i}, @dg{i})";

                    // Thêm các giá trị của bản ghi vào câu lệnh SQL
                    insertQuery += (i > 0 ? ", " : "") + values;

                    // Thêm tham số cho mỗi bản ghi
                    parameters.Add(new SqlParameter($"@mpn{i}", ctpn.SGMaPhieuNhap));
                    parameters.Add(new SqlParameter($"@mts{i}", ctpn.SGMaTuaSach));
                    parameters.Add(new SqlParameter($"@sl{i}", ctpn.SGSoLuong));
                    parameters.Add(new SqlParameter($"@dg{i}", ctpn.SGDonGia));
                }

                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddRange(parameters.ToArray());

                rowsAffected = command.ExecuteNonQuery();
                connection.Close();
            }

            return rowsAffected;
        }
        public List<ChiTietPhieuNhap> getAllPhieuNhapByMaPN(string mapn)
        {
            List<ChiTietPhieuNhap> list = new List<ChiTietPhieuNhap>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string query = "SELECT * FROM ChiTietPhieuNhap WHERE MaPhieuNhap = @mapn";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@mapn", mapn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                    ctpn.SGMaPhieuNhap = reader.GetString(0);
                    ctpn.SGMaTuaSach = reader.GetString(1);
                    ctpn.SGSoLuong = reader.GetInt32(2);
                    string a = reader.GetDouble(3).ToString();
                    ctpn.SGDonGia = float.Parse(a);
                    list.Add(ctpn);
                }
                connection.Close();
            }
            return list;
        }
        public int updateSoLuongTuaSachNhap(List<ChiTietPhieuNhap> ctpn)
        {
            int rowAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "UPDATE TuaSach set SoLuong = SoLuong + @sl WHERE MaTuaSach = @mts";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    foreach (ChiTietPhieuNhap ctpnItem in ctpn)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@mts", ctpnItem.SGMaTuaSach);
                        command.Parameters.AddWithValue("@sl", ctpnItem.SGSoLuong);
                        rowAffected = command.ExecuteNonQuery();
                    }
                }

                connection.Close();
            }
            return rowAffected;
        }
        public String getLastMaCS()
        {
            String mapm = "";
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select top 1 macuonsach from cuonsach order by macuonsach desc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mapm = reader.GetString(0);
                }
                connection.Close();
            }
            return mapm;
        }
        public String getNewMaCS()
        {
            String mapm = getLastMaCS();
            int index = Convert.ToInt32(mapm.Substring(1));
            return "S" + (index + 1).ToString("D4");
        }
        public int insertCuonSachByFromCTPN(List<ChiTietPhieuNhap> ctpnList)
        {
            string mcs = getNewMaCS();
            int rowAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "insert into CuonSach(MaCuonSach,MaTuaSach,TrangThaiSach) values(@mcs,@mts,@tts)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    foreach (ChiTietPhieuNhap ctpnItem in ctpnList)
                    {
                        for (int i = 0; i < ctpnItem.SGSoLuong; i++)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@mcs", mcs);
                            String mapm = mcs;
                            int index = Convert.ToInt32(mapm.Substring(1));
                            mcs = "S" + (index + 1).ToString("D4");
                            command.Parameters.AddWithValue("@mts", ctpnItem.SGMaTuaSach);
                            command.Parameters.AddWithValue("@tts", 1);
                            rowAffected = command.ExecuteNonQuery();
                        }
                    }
                }
                connection.Close();
            }
            return rowAffected;
        }
    }
}
