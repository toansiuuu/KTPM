using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        SqlDataAdapter da;
        DataSet ds;
        public List<TaiKhoan> getALLTaiKhoan()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM TaiKhoan", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TaiKhoan cs = new TaiKhoan();
                    cs.SGTenDangNhap = reader.GetString(0);
                    cs.SGMatKhau = reader.GetString(1);
                    cs.SGMaQuyen = reader.GetString(2);
                    cs.SgTrangThai = reader.GetBoolean(3);
                    list.Add(cs);
                }
                connection.Close();
            }
            return list;
        }
        public DataTable getAllTaiKhoanDataTable()
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                String sqlStr = "select Manhanvien,TenNV,ChucVu,Tendangnhap,MatKhau,Maquyen,taikhoan.TrangThai from nhanvien left join taikhoan  on tendangnhap = manhanvien";
                da = new SqlDataAdapter(sqlStr, connection);
                ds = new DataSet();
                da.Fill(ds);
                connection.Close();
                return ds.Tables[0];
            }
        }
        public static SqlConnection sqlConn = DataBaseConnection.Connect();
        public TaiKhoan GetTaiKhoanDTO(string manv)
        {
            TaiKhoan tk = new TaiKhoan();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string query = "SELECT * FROM NhanVien WHERE MaNhanVien = @manv";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@manv", manv);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tk.SgTrangThai = reader.GetBoolean(3);
                }
                connection.Close();

            }
            return tk;
        }
        //Sửa trạng thái của tài khoản
        public int updateTTTaiKhoan(string matk, bool trangthai)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string updateQuery = "UPDATE TaiKhoan SET trangThai = @trangThai Where tendangnhap = @matk";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@matk", matk);
                    command.Parameters.AddWithValue("@trangThai", trangthai);
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int updateQuyenTaiKhoan(string matk, string maQuyen)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string updateQuery = "UPDATE TaiKhoan SET maquyen = @maquyen Where tendangnhap = @matk";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@matk", matk);
                    command.Parameters.AddWithValue("@maquyen", maQuyen);
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public int insertTaiKhoan(TaiKhoan tk)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string updateQuery = "Insert into TaiKhoan(TenDangNhap,MatKhau,MaQuyen,TrangThai) values(@tdn,@mk,@mq,@tt)";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@tdn", tk.SGTenDangNhap);
                    command.Parameters.AddWithValue("@mk", tk.SGMatKhau);
                    command.Parameters.AddWithValue("@mq", tk.SGMaQuyen);
                    command.Parameters.AddWithValue("@tt", tk.SgTrangThai);
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
        public NhanVienDTO getInFoNVByMa(String maNV)
        {
            NhanVienDTO nv = new NhanVienDTO();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string query = "SELECT * FROM NhanVien WHERE MaNhanVien = @manv";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@manv", maNV);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    nv.MaNhanVien = reader.GetString(0);
                    nv.TenNhanVien = reader.GetString(1);
                    nv.GioiTinh = reader.GetBoolean(2);
                    nv.NgaySinh = reader.GetDateTime(3);
                    nv.DiaChi = reader.GetString(4);
                    nv.Sdt = reader.GetString(5);
                    nv.ChucVu = reader.GetString(6);
                    nv.TrangThai = reader.GetBoolean(7);
                    nv.Img = reader.GetString(8);
                }
                connection.Close();
            }
            return nv;
        }
    }
}
