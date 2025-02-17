using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CuonSachBUS
    {
        private CuonSachDAO cs_DAO = new CuonSachDAO();
        public List<CuonSach> getAllCuonSach()
        {
            return cs_DAO.getAllCuonSach();
        }
        public List<CuonSach> getAllCuonSachByMa(String mats)
        {
            return cs_DAO.getAllCuonSachByMa(mats);
        }

        public CuonSach getCuonSachByMa(String macs, String mats)
        {
            return cs_DAO.getCuonSaschByMa(macs, mats);
        }

        public Boolean updateTTCuonSach(CuonSach cs)
        {
            return cs_DAO.updateTTCuonSach(cs);
        }
        public bool suaTTMuonCuonSach(List<String> list)
        {
            return cs_DAO.suaTTMuonCuonSach(list);
        }


    }
}
