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
    public class PhieuTraDAO
    {
        SqlDataAdapter da;
        DataSet ds;
        public DataTable getALLPT()
        {
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                String sqlStr = "select phieutra.*,phieumuon.MaThe " +
                "from phieutra, phieumuon where phieutra.maphieumuon = phieumuon.maphieumuon";
                da = new SqlDataAdapter(sqlStr, connection);
                ds = new DataSet();
                da.Fill(ds);
                connection.Close();
                return ds.Tables[0];
            }
        }
        public bool addPT(PhieuTra pt)
        {
            bool flag = false;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "INSERT INTO PhieuTra(MaPhieuMuon,NgayTra,TienPhat,TrangThai) values (@mapm,@ngaytra,@tienphat,@trangthai)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@mapm", pt.SGMaPhieuMuon);
                command.Parameters.Add(new SqlParameter("@ngaytra", SqlDbType.Date)).Value = pt.SGNgayTra;
                command.Parameters.AddWithValue("@tienphat", pt.SGTienPhat);
                command.Parameters.AddWithValue("@trangthai", pt.SGTrangThai);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    flag = true;
                }
                connection.Close();
            }
            return flag;
        }
        public bool suaTTPM(String mapm)
        {
            bool flag = false;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "UPDATE PhieuMuon Set TrangThai = 1 WHERE MaPhieuMuon = @mapm";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@mapm", mapm);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    flag = true;
                }
                connection.Close();
            }
            return flag;
        }
        public List<String> getALLCSMOFPM(String mapm)
        {
            List<String> list = new List<String>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select chitietcuonsachmuon.macuonsach from phieumuon,chitietphieumuon,chitietcuonsachmuon where phieumuon.maphieumuon = '" + mapm + "' and phieumuon.maphieumuon = chitietphieumuon.maphieumuon and chitietphieumuon.maphieumuon = chitietcuonsachmuon.maphieumuon group by chitietcuonsachmuon.macuonsach", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
                connection.Close();
            }
            return list;
        }
        public bool suaTTCS(String mapm)
        {
            bool flag = false;
            int count = 0;
            List<String> list = getALLCSMOFPM(mapm);
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "UPDATE CuonSach Set TrangThaiSach = 1 WHERE MaCuonSach = @macuonsach";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    foreach (String cs in list)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@macuonsach", cs);
                        int rowAffected = command.ExecuteNonQuery();
                        count += rowAffected;
                    }
                }
                if (count == list.Count)
                {
                    flag = true;
                }
                connection.Close();
            }
            return flag;
        }
        public List<PhieuTra> getAllPhieuTra()
        {
            List<PhieuTra> list = new List<PhieuTra>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from PHIEUTRA where TrangThai = 0", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PhieuTra pt = new PhieuTra();
                    pt.SGMaPhieuMuon = reader.GetString(0);
                    pt.SGNgayTra = reader.GetDateTime(1);
                    pt.SGTienPhat = float.Parse(reader.GetDouble(2).ToString());
                    pt.SGTrangThai = reader.GetBoolean(3);
                    list.Add(pt);
                }
                connection.Close();
            }
            return list;
        }
    }
}
