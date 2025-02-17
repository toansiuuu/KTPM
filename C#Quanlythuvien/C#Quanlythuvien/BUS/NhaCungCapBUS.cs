using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAO dao = new NhaCungCapDAO();
        public List<NhaCungCap> getAllNhaCungCap()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            list = dao.getALLNhaCungCap();
            return list;
        }
        public String getLastMaNCC()
        {
            String mapm = dao.getLastMaNCC();
            int index = Convert.ToInt32(mapm.Substring(3));
            return "NCC" + (index + 1).ToString("D3");
        }
        public DataTable getAllNhaCungCapDataTable()
        {
            return dao.getAllNhaCungCapDataTable();
        }
        public int insertNhaCungCap(NhaCungCap ncc)
        {
            int rowAffected = 0;
            rowAffected = dao.insertNhaCungCap(ncc);
            return rowAffected;
        }
        public int getSoLuongNhaCungCap()
        {
            return dao.getSLNCC();
        }
        public NhaCungCap getNhaCungCapByMa(string maNCC)
        {
            return dao.getNhaCungCapByMa(maNCC);
        }
        public int updateNhaCungCap(NhaCungCap ncc)
        {
            return dao.updateNhaCungCap(ncc);
        }
        public int deleteNhaCungCap(string maNCC)
        {
            return dao.deleteNhaCungCap(maNCC);
        }
    }
}
