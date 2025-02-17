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
    public class ChiTietPhieuMuonDAO
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        public DataTable getALlCTPM()
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                String sqlStr = "SELECT chitietphieumuon.MaPhieuMuon, chitietphieumuon.MaTuaSach, " +
    "chitietphieumuon.SoLuong, docgia.MaDocGia,phieumuon.TrangThai " +
    "FROM chitietphieumuon, phieumuon, thethuvien, docgia " +
    "WHERE chitietphieumuon.maphieumuon = phieumuon.maphieumuon " +
    "AND phieumuon.mathe = thethuvien.mathe AND thethuvien.madocgia = docgia.madocgia " +
    "ORDER BY chitietphieumuon.maphieumuon";
                da = new SqlDataAdapter(sqlStr, connection);
                ds = new DataSet();
                da.Fill(ds);
                connection.Close();
                return ds.Tables[0];
            }
        }
        public bool addCTPM(List<ChiTietPhieuMuon> listctpm)
        {
            bool flag = false;
            int count = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO ChiTietPhieuMuon(MaPhieuMuon,MaTuaSach,SoLuong) values (@mapm,@matuasach,@soluong)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    foreach (ChiTietPhieuMuon ctpm in listctpm)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@mapm", ctpm.SGMaPhieuMuon);
                        command.Parameters.AddWithValue("@matuasach", ctpm.SGMaTuaSach);
                        command.Parameters.AddWithValue("@soluong", ctpm.SGSoLuong);
                        int rowAffected = command.ExecuteNonQuery();
                        count += rowAffected;
                    }
                }
                if (count == listctpm.Count)
                {
                    flag = true;
                }
                connection.Close();
            }
            return flag;
        }
    }
}
