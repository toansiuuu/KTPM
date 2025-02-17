using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO dao = new NhanVienDAO();
        public List<NhanVienDTO> getAllNhanVien()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            list = dao.getALlNhanVien();
            return list;
        }
        public int insertNhanVien(NhanVienDTO nv)
        {
            int rowAffected = 0;
            rowAffected = dao.insertNhanVien(nv);          
            return rowAffected;
        }
        public String getLastMaNV()
        {
            String mapm = dao.getLastMaNV();
            int index = Convert.ToInt32(mapm.Substring(2));
            return "NV" + (index + 1).ToString("D3");
        }
        public NhanVienDTO getNhanVienByMa(string maNV) {
            return dao.getNhanVienByMa(maNV);
        }
        public int updateNhanVien(NhanVienDTO nv)
        {
            return dao.updateNhanVien(nv);
        }
    }
}
