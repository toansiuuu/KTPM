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
    public class PhieuMuonDAO
    {
        SqlDataAdapter da;
        DataSet ds;
        public List<PhieuMuon> getALlPhieuMuon()
        {
            List<PhieuMuon> list = new List<PhieuMuon>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM phieumuon", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhieuMuon phieuMuon = new PhieuMuon();
                    phieuMuon.SGMaPhieuMuon = reader.GetString(0);
                    phieuMuon.SGMaThe = reader.GetString(1);
                    phieuMuon.SGNgayMuon = reader.GetDateTime(2);
                    phieuMuon.SGHanTra = reader.GetDateTime(3);
                    phieuMuon.SGMaNhanVien = reader.GetString(4);
                    phieuMuon.SGTrangThai = reader.GetBoolean(5);
                    list.Add(phieuMuon);

                }
                connection.Close();
            }
            return list;
        }
        public String getLastMaPM()
        {
            String mapm = "";
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select top 1 maphieumuon from phieumuon order by maphieumuon desc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    mapm = reader.GetString(0);
                }
                connection.Close();
            }
            return mapm;
        }
        public bool addPM(PhieuMuon pm)
        {
            bool flag = false;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO PhieuMuon(MaPhieuMuon,MaThe,NgayMuon,HanTra,MaNhanVien,TrangThai) values (@mapm,@mathe,@ngmuon,@hantra,@manv,@trangthai)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@mapm", pm.SGMaPhieuMuon);
                command.Parameters.AddWithValue("@mathe", pm.SGMaThe);
                command.Parameters.Add(new SqlParameter("@ngmuon", SqlDbType.Date)).Value = pm.SGNgayMuon;
                command.Parameters.Add(new SqlParameter("@hantra", SqlDbType.Date)).Value = pm.SGHanTra;
                command.Parameters.AddWithValue("@manv", pm.SGMaNhanVien);
                command.Parameters.AddWithValue("@trangthai", pm.SGTrangThai);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    flag = true;
                }
                connection.Close();
            }
            return flag;
        }
        public DataTable getALPMChuaTra()
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                String sqlStr = "select phieumuon.MaPhieuMuon,phieumuon.MaThe,phieumuon.NgayMuon,phieumuon.HanTra,phieumuon.MaNhanVien from phieumuon where trangthai = 0";
                da = new SqlDataAdapter(sqlStr, connection);
                ds = new DataSet();
                da.Fill(ds);
                connection.Close();
                return ds.Tables[0];
            }
        }

    }
}
