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
    public class ChiTietPhieuMuonBUS
    {
        ChiTietPhieuMuonDAO ctpmDAO = new ChiTietPhieuMuonDAO();
        public DataTable getALlCTPM()
        {
            return ctpmDAO.getALlCTPM();
        }
        public bool addCTPM(List<ChiTietPhieuMuon> listctpm)
        {
            return ctpmDAO.addCTPM(listctpm);
        }
    }
}
