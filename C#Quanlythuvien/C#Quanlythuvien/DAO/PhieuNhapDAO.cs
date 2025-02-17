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
    public class PhieuNhapDAO
    {
        public List<TuaSach> getAllTuaSach()
        {
            List<TuaSach> list = new List<TuaSach>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM TUASACH where TrangThai = 1 ", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TuaSach ts = new TuaSach();
                        ts.SGMaTuaSach = reader.GetString(0);
                        ts.SGTenTuaSach = reader.GetString(1);
                        ts.SGMaNXB = reader.GetString(2);
                        ts.SGSoLuong = reader.GetInt32(3);
                        ts.SGNamXB = reader.GetInt32(4);
                        ts.SGImage = reader.GetString(5);
                        ts.SGMoTa = reader.GetString(6);
                        ts.SGTrangThai = reader.GetBoolean(7);
                        ts.SGMaTacGia = reader.GetString(8);
                        list.Add(ts);
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
        public String getLastMaPN()
        {
            String mapn = "";
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select top 1 maphieunhap from phieunhap order by maphieunhap desc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mapn = reader.GetString(0);
                }
                connection.Close();
            }
            return mapn;
        }
        public List<string> getAllNCC()
        {
            List<string> list = new List<string>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM NHACUNGCAP where TrangThai = 1", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    list.Add(reader.GetString(0));
                }

                connection.Close();
            }
            return list;
        }
        public int insertPhieuNhap(PhieuNhap pn)
        {
            int rowAffected = 0;

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO PhieuNhap(MaPhieuNhap,MaNCC,MaNhanVien,NgayNhap,TongTien,TinhTrang) values (@mpn,@mancc,@manv,@ngaynhap,@tongtien,@tinhtrang)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@mpn", pn.SGMaPhieuNhap);
                command.Parameters.Add(new SqlParameter("@ngaynhap", SqlDbType.Date)).Value = pn.SGNgayNhap;
                command.Parameters.AddWithValue("@mancc", pn.SGMaNCC);
                command.Parameters.AddWithValue("@manv", pn.SGMaNhanVien);
                command.Parameters.AddWithValue("@tongtien", pn.SGTongTien);
                command.Parameters.AddWithValue("@tinhtrang", pn.SGTinhTrang);


                rowAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            return rowAffected;
        }
        public List<PhieuNhap> getAllPhieuNhap()
        {
            List<PhieuNhap> list = new List<PhieuNhap>();

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM PhieuNhap", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhieuNhap pn = new PhieuNhap();
                    pn.SGMaPhieuNhap = reader.GetString(0);
                    pn.SGMaNCC = reader.GetString(1);
                    pn.SGMaNhanVien = reader.GetString(2);
                    pn.SGNgayNhap = reader.GetDateTime(3);
                    double a = reader.GetDouble(4);
                    string b = a.ToString();
                    float tongTien = float.Parse(b);
                    pn.SGTongTien = tongTien;
                    pn.SGTinhTrang = reader.GetBoolean(5);

                    list.Add(pn);
                }

                connection.Close();
            }

            return list;
        }
        public List<PhieuNhap> getAllPhieuNhapByMaNV(String maNV)
        {
            List<PhieuNhap> list = new List<PhieuNhap>();

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM PhieuNhap WHERE MaNhanVien = @manv", connection);
                command.Parameters.AddWithValue("@manv", maNV);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhieuNhap pn = new PhieuNhap();
                    pn.SGMaPhieuNhap = reader.GetString(0);
                    pn.SGMaNCC = reader.GetString(1);
                    pn.SGMaNhanVien = reader.GetString(2);
                    pn.SGNgayNhap = reader.GetDateTime(3);
                    double a = reader.GetDouble(4);
                    string b = a.ToString();
                    float tongTien = float.Parse(b);
                    pn.SGTongTien = tongTien;
                    pn.SGTinhTrang = reader.GetBoolean(5);

                    list.Add(pn);
                }

                connection.Close();
            }

            return list;
        }
        public int xoaPhieuNhapByMa(string maPN)
        {
            int rowAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "delete from PhieuNhap where maphieunhap=@maPN";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@maPN", maPN);
                rowAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            return rowAffected;
        }
        public PhieuNhap getPhieuNhapByMa(string ma)
        {
            PhieuNhap pn = new PhieuNhap();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM PhieuNhap where MaPhieuNhap = @ma", connection);
                command.Parameters.AddWithValue("@ma", ma);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    pn.SGMaPhieuNhap = reader.GetString(0);
                    pn.SGMaNCC = reader.GetString(1);
                    pn.SGMaNhanVien = reader.GetString(2);
                    pn.SGNgayNhap = reader.GetDateTime(3);
                    pn.SGTongTien = float.Parse(reader.GetDouble(4).ToString());
                    pn.SGTinhTrang = reader.GetBoolean(5);
                }

                connection.Close();
            }
            return pn;
        }
        public int deleteCTPNofPNByMa(string ma)
        {
            int rowAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "delete from ChiTietPhieuNhap where maphieunhap=@maPN";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@maPN", ma);
                rowAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            return rowAffected;
        }
        public int updateTongTienPhieuNhap(string ma, float tongTien)
        {
            int rowAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "update PhieuNhap set TongTien=@tt where maphieunhap=@maPN";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@maPN", ma);
                command.Parameters.AddWithValue("@tt", tongTien);

                rowAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            return rowAffected;

        }
        public int updateTrangThaiByMa(string ma)
        {
            int rowAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "update PhieuNhap set TinhTrang = @tt where maphieunhap = @maPN";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@maPN", ma);
                command.Parameters.AddWithValue("@tt", 1);
                rowAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            return rowAffected;
        }
        public List<PhieuNhap> getAllPhieuNhapTinhTrangTrue()
        {
            List<PhieuNhap> list = new List<PhieuNhap>();

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM PhieuNhap where TinhTrang = 1", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhieuNhap pn = new PhieuNhap();
                    pn.SGMaPhieuNhap = reader.GetString(0);
                    pn.SGMaNCC = reader.GetString(1);
                    pn.SGMaNhanVien = reader.GetString(2);
                    pn.SGNgayNhap = reader.GetDateTime(3);
                    double a = reader.GetDouble(4);
                    string b = a.ToString();
                    float tongTien = float.Parse(b);
                    pn.SGTongTien = tongTien;
                    pn.SGTinhTrang = reader.GetBoolean(5);

                    list.Add(pn);
                }

                connection.Close();
            }

            return list;
        }
    }
}
