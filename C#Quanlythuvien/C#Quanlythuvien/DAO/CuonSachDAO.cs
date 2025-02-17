using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CuonSachDAO
    {
        public bool suaTTMuonCuonSach(List<String> list)
        {
            bool flag = false;
            int count = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "UPDATE CuonSach Set TrangThaiSach = 2 WHERE MaCuonSach = @macuonsach";
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


        public List<CuonSach> getAllCuonSach()
        {
            List<CuonSach> list = new List<CuonSach>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM CUONSACH", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CuonSach cs = new CuonSach();
                        cs.SGMaCuonSach = reader.GetString(0);
                        cs.SGMaTuaSach = reader.GetString(1);
                        cs.SGTrangThaiSach = reader.GetInt32(2);

                        list.Add(cs);
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
        public List<CuonSach> getAllCuonSachByMa(String mats)
        {
            List<CuonSach> list = new List<CuonSach>();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM CUONSACH WHERE MATUASACH = @mats", connection);
                    command.Parameters.AddWithValue("@mats", mats);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CuonSach cs = new CuonSach();
                        cs.SGMaCuonSach = reader.GetString(0);
                        cs.SGMaTuaSach = reader.GetString(1);
                        cs.SGTrangThaiSach = reader.GetInt32(2);

                        list.Add(cs);
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

        public CuonSach getCuonSaschByMa(String macs, String mats)
        {
            CuonSach cs = new CuonSach();
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM CUONSACH where MaCuonSach = @MaCuonSach and MaTuaSach = @MaTuaSach", connection);
                    command.Parameters.AddWithValue("@MaCuonSach", macs);
                    command.Parameters.AddWithValue("@MaTuaSach", mats);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        cs.SGMaCuonSach = reader.GetString(0);
                        cs.SGMaTuaSach = reader.GetString(1);
                        cs.SGTrangThaiSach = reader.GetInt32(2);
                    }
                    return cs;
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
            return cs;
        }

        public Boolean updateTTCuonSach(CuonSach cs)
        {
            int rowAffected = 0;
            using (SqlConnection connection = DataBaseConnection.Connect())
            {
                connection.Open();
                string insertQuery = "UPDATE CUONSACH SET TrangThaiSach = @TrangThaiSach  WHERE MaCuonSach = @MaCuonSach and MaTuaSach = @MaTuaSach";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@TrangThaiSach", cs.SGTrangThaiSach);
                command.Parameters.AddWithValue("@MaCuonSach", cs.SGMaCuonSach);
                command.Parameters.AddWithValue("@MaTuaSach", cs.SGMaTuaSach);

                rowAffected = command.ExecuteNonQuery();
            }
            return rowAffected > 0;
        }
    }
}
