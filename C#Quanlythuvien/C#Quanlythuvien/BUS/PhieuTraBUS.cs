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
    public class PhieuTraBUS
    {
        PhieuTraDAO ptDAO = new PhieuTraDAO();
        public DataTable getALLPT()
        {
            return ptDAO.getALLPT();
        }
        public bool addPT(PhieuTra pt)
        {
            return ptDAO.addPT(pt);
        }
        public bool suaTTPM(String mapm)
        {
            return ptDAO.suaTTPM(mapm);
        }
        public bool suaTTCS(String mapm)
        {
            return ptDAO.suaTTCS(mapm);
        }
        public List<PhieuTra> getAllPhieuTra()
        {
            return ptDAO.getAllPhieuTra();
        }
    }
}
