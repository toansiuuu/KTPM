using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DAO
{
    public class TuaSachDAO
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        public List<TuaSach> getAllTuaSach()
        {
            List<TuaSach> list = new List<TuaSach>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM TUASACH", connection);
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
        public String getLastMaTuaSach()
        {
            String mats = "";
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select top 1 MaTuaSach from TuaSach order by MaTuaSach desc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mats = reader.GetString(0);
                }
                connection.Close();
            }
            return mats;
        }
        public TuaSach GetTuaSachBangMa(string matuasach)
        {
            TuaSach ts = new TuaSach();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM TUASACH WHERE MaTuaSach = @MaTuaSach", connection);
                    command.Parameters.AddWithValue("@MaTuaSach", matuasach);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        ts.SGMaTuaSach = reader.GetString(0);
                        ts.SGTenTuaSach = reader.GetString(1);
                        ts.SGMaNXB = reader.GetString(2);
                        ts.SGSoLuong = reader.GetInt32(3);
                        ts.SGNamXB = reader.GetInt32(4);
                        ts.SGImage = reader.GetString(5);
                        ts.SGMoTa = reader.GetString(6);
                        ts.SGTrangThai = reader.GetBoolean(7);
                        ts.SGMaTacGia = reader.GetString(8);
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

            

            return ts;
        }

        public Boolean kiemTraTrungMa(TuaSach ts)
        {
            List<TuaSach> ls_ts = getAllTuaSach();
            foreach (TuaSach x in ls_ts)
            {
                if (x.SGMaTuaSach == ts.SGMaTuaSach) return true;
            }
            
            return false;
        }

        public int addTuaSach(TuaSach ts)
        {

            int rowAffected = 0;

            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO TuaSach(MaTuaSach,TenTuaSach,MaNXB,SoLuong,NamXB,Image,Mota,TrangThai,MaTacGia) values (@MaTuaSach,@TenTuaSach,@MaNXB,@SoLuong,@NamXB,@Image,@Mota,@TrangThai,@MaTacGia)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@MaTuaSach", ts.SGMaTuaSach);
                command.Parameters.AddWithValue("@TenTuaSach",ts.SGTenTuaSach);
                command.Parameters.AddWithValue("@MaNXB", ts.SGMaNXB);
                command.Parameters.AddWithValue("@SoLuong", ts.SGSoLuong);
                command.Parameters.AddWithValue("@NamXB", ts.SGNamXB);
                command.Parameters.AddWithValue("@Image", ts.SGImage);
                command.Parameters.AddWithValue("@Mota", ts.SGMoTa);
                command.Parameters.AddWithValue("@TrangThai", ts.SGTrangThai);
                command.Parameters.AddWithValue("@MaTacGia", ts.SGMaTacGia);
                rowAffected = command.ExecuteNonQuery();
                connection.Close();
            }
            return rowAffected;

        }

       public int editTuaSach(TuaSach ts)
        {
            int rowAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "UPDATE TUASACH SET TenTuaSach = @TenTuaSach, MaNXB = @MaNXB, SoLuong = @Soluong, NamXB = @NamXB, Image = @Image, Mota = @Mota,TrangThai = @TrangThai, MaTacGia = @MaTacGia WHERE MaTuaSach = @MaTuaSach";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@MaTuaSach", ts.SGMaTuaSach);
                command.Parameters.AddWithValue("@TenTuaSach", ts.SGTenTuaSach);
                command.Parameters.AddWithValue("@MaNXB", ts.SGMaNXB);
                command.Parameters.AddWithValue("@SoLuong", ts.SGSoLuong);
                command.Parameters.AddWithValue("@NamXB", ts.SGNamXB);
                command.Parameters.AddWithValue("@Image", ts.SGImage);
                command.Parameters.AddWithValue("@Mota", ts.SGMoTa);
                command.Parameters.AddWithValue("@TrangThai", ts.SGTrangThai);
                command.Parameters.AddWithValue("@MaTacGia", ts.SGMaTacGia);
                rowAffected = command.ExecuteNonQuery();
            }
            return rowAffected;
        }

        public int updateTTTuaSach(TuaSach ts)
        {
            int rowAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "UPDATE TUASACH SET TrangThai = @TrangThai WHERE MaTuaSach = @MaTuaSach";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@TrangThai", ts.SGTrangThai);
                command.Parameters.AddWithValue("@MaTuaSach", ts.SGMaTuaSach);
                rowAffected = command.ExecuteNonQuery();
            }
            return rowAffected;
        }
        public DataTable getALlTuaSachChoMuon()
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                String sqlStr = "select tuasach.MaTuaSach,tuasach.TenTuaSach,count (tuasach.tentuasach) as SoLuong\r\n " +
                "from tuasach,cuonsach \r\nwhere tuasach.matuasach = cuonsach.matuasach " +
                "and tuasach.trangthai = 1 and cuonsach.trangthaisach = 1 " +
                "\r\ngroup by tuasach.matuasach,tuasach.tentuasach";
                da = new SqlDataAdapter(sqlStr, connection);
                ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
        }
    }
}
