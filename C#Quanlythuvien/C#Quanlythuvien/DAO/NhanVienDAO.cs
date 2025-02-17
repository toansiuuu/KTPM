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
    public class NhanVienDAO
    {
        public static SqlConnection sqlConn = DataBaseConnection.Connect();
        public List<NhanVienDTO> getALlNhanVien()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            using(SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM NhanVien", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO();
                    nv.MaNhanVien=reader.GetString(0);
                    nv.TenNhanVien=reader.GetString(1);
                    nv.GioiTinh=reader.GetBoolean(2);
                    nv.NgaySinh=reader.GetDateTime(3);
                    nv.DiaChi = reader.GetString(4);
                    nv.ChucVu = reader.GetString(5);
                    nv.Sdt=reader.GetString(6);
                    nv.TrangThai=reader.GetBoolean(7);
                    nv.Img=reader.GetString(8);
                    list.Add(nv);

                }


                connection.Close();
            }

            return list;
        }
        public int insertNhanVien(NhanVienDTO nv)
        {
            int rowAffected = 0;

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO NhanVien(manhanvien,tenNV,gioiTinh,ngaySinh,diaChi,sdt,chucVu,trangThai,Image) values (@maNV,@tenNV,@gioiTinh,@ngaySinh,@diaChi,@sdt,@chucVu,@trangThai,@Image)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@maNV", nv.MaNhanVien);
                command.Parameters.AddWithValue("@tenNV", nv.TenNhanVien);
                command.Parameters.AddWithValue("@gioiTinh", nv.GioiTinh);
                command.Parameters.Add(new SqlParameter("@ngaySinh", SqlDbType.Date)).Value = nv.NgaySinh;
                command.Parameters.AddWithValue("@diaChi", nv.DiaChi);
                command.Parameters.AddWithValue("@sdt", nv.Sdt);
                command.Parameters.AddWithValue("@trangThai", nv.TrangThai);
                command.Parameters.AddWithValue("@chucVu", nv.ChucVu);
                command.Parameters.AddWithValue("@Image", nv.Img);
                rowAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            return rowAffected;
        }
        public String getLastMaNV()
        {
            String mapm = "";
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select top 1 manhanvien from nhanvien order by manhanvien desc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mapm = reader.GetString(0);
                }
                connection.Close();
            }
            return mapm;
        }
        public NhanVienDTO getNhanVienByMa(string maNV)
        {
            NhanVienDTO nv = new NhanVienDTO();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string query = "SELECT * FROM NhanVien WHERE manhanvien = @maNV";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maNV", maNV);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    nv.MaNhanVien = reader.GetString(0);
                    nv.TenNhanVien = reader.GetString(1);
                    nv.GioiTinh = reader.GetBoolean(2);
                    nv.NgaySinh = reader.GetDateTime(3);
                    nv.DiaChi = reader.GetString(4);
                    nv.ChucVu = reader.GetString(5);
                    nv.Sdt = reader.GetString(6);
                    nv.TrangThai = reader.GetBoolean(7);
                    nv.Img = reader.GetString(8);
                }
                connection.Close();

            }
            return nv;
        }
        public int updateNhanVien(NhanVienDTO nv)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string updateQuery = "UPDATE NhanVien SET tenNV = @tenNV, gioiTinh = @gioiTinh, ngaySinh = @ngaySinh, diaChi = @diaChi, sdt = @sdt, chucVu = @chucVu, trangThai = @trangThai, Image = @Img WHERE manhanvien = @maNV";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@maNV", nv.MaNhanVien);
                    command.Parameters.AddWithValue("@tenNV", nv.TenNhanVien);
                    command.Parameters.AddWithValue("@gioiTinh", nv.GioiTinh);
                    command.Parameters.Add(new SqlParameter("@ngaySinh", SqlDbType.Date)).Value = nv.NgaySinh;
                    command.Parameters.AddWithValue("@diaChi", nv.DiaChi);
                    command.Parameters.AddWithValue("@sdt", nv.Sdt);
                    command.Parameters.AddWithValue("@trangThai", nv.TrangThai);
                    command.Parameters.AddWithValue("@chucVu", nv.ChucVu);
                    command.Parameters.AddWithValue("@Img", nv.Img);

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}
