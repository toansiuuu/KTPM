using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        ChiTietPhieuNhapDAO dao = new ChiTietPhieuNhapDAO();
        public int insertCTPN(List<ChiTietPhieuNhap> list)
        {
            return dao.InsertChiTietPhieuNhapList(list);
        }
        public List<ChiTietPhieuNhap> getAllPhieuNhapByMaPN(string mapn)
        {
            return dao.getAllPhieuNhapByMaPN(mapn);
        }
        public int updateSoLuongTuaSachNhap(List<ChiTietPhieuNhap> list)
        {
            return dao.updateSoLuongTuaSachNhap(list);
        }
        public int insertCuonSachByFromCTPN(List<ChiTietPhieuNhap> ctpnList)
        {
            return dao.insertCuonSachByFromCTPN(ctpnList);
        }
    }
}
