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
    public class PhieuMuonBUS
    {
        PhieuMuonDAO pmDAO = new PhieuMuonDAO();
        public List<PhieuMuon> getALlPhieuMuon()
        {
            return pmDAO.getALlPhieuMuon();
        }
        public String getLastMaPM()
        {
            String mapm = pmDAO.getLastMaPM();
            int index = Convert.ToInt32(mapm.Substring(2));
            return "PM" + (index + 1).ToString("D3");
        }
        public bool addPM(PhieuMuon pm)
        {
            return pmDAO.addPM(pm);
        }
        public DataTable getALPMChuaTra()
        {
            return pmDAO.getALPMChuaTra();
        }
    }
}
