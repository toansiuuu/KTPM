using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietCuonSachBUS
    {
        ChiTietCuonSachMuonDAO ctcsDAO = new ChiTietCuonSachMuonDAO();
        public DataTable getALlCTCSM()
        {
            return ctcsDAO.getALlCTCSM();
        }
        public List<String> getCTCSMNotBorrowedFirst(String sql)
        {
            return ctcsDAO.getCTCSMNotBorrowedFirst(sql);
        }
        public bool addCTCSM(List<ChiTietCuonSachMuon> listctcsm)
        {
            return ctcsDAO.addCTCSM(listctcsm);
        }

    }
}
