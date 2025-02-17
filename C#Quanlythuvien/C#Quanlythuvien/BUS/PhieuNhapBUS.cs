using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuNhapBUS
    {
        PhieuNhapDAO dao = new PhieuNhapDAO();
        public List<TuaSach> getAllTuaSach()
        {
            return dao.getAllTuaSach();
        }
        public String getLastMaPN()
        {
            String mapn = dao.getLastMaPN();
            int index = Convert.ToInt32(mapn.Substring(2));
            return "PN" + (index + 1).ToString("D3");
        }
        public List<string> getAllNCC()
        {
            return dao.getAllNCC(); ;
        }
        public int insertPhieuNhap(PhieuNhap pn)
        {
            return dao.insertPhieuNhap(pn);
        }
        public List<PhieuNhap> getAllPhieuNhap()
        {
            return dao.getAllPhieuNhap();
        }
        public List<PhieuNhap> getAllPhieuNhapByMaNV(String maNV)
        {
            return dao.getAllPhieuNhapByMaNV(maNV);
        }
        public int deletePhieuNhapByMa(string mapn)
        {
            return dao.xoaPhieuNhapByMa(mapn);
        }
        public PhieuNhap getPhieuNhapByMa(string ma)
        {
            return dao.getPhieuNhapByMa(ma);
        }
        public int deleteCTPNofPNByMa(string mapn)
        {
            return dao.deleteCTPNofPNByMa(mapn);
        }
        public int updateTongTien(string ma, float tongtien)
        {
            return dao.updateTongTienPhieuNhap(ma, tongtien);
        }
        public int updateTinhTrangByMa(string ma)
        {
            return dao.updateTrangThaiByMa(ma);
        }
        public List<PhieuNhap> getAllPhieuNhapTTTrue()
        {
            return dao.getAllPhieuNhapTinhTrangTrue();
        }
    }
}
