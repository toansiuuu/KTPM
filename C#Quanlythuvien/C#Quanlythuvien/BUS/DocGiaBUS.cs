using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DocGiaBUS
    {
        private DocGiaDAO dg_DAO = new DocGiaDAO();
        public List<DocGia> getAllDocGia()
        {
            return dg_DAO.getAllDocGia();
        }
        public DocGia getDocGiaByMa(String ma)
        {
            return dg_DAO.getDocGiaByMa(ma);
        }

        public Boolean updateTinhTrang(DocGia dg)
        {
            return dg_DAO.updateTinhTrang(dg);
        }

        public Boolean addDocGia(DocGia dg)
        {
            return dg_DAO.addDocGia(dg);
        }

        public Boolean editDocGia(DocGia dg)
        {
            return dg_DAO.editDocGia(dg);
        }

        public String getLastMa()
        {
            String madg = dg_DAO.getLastMaDocGia();
            int index = Convert.ToInt32(madg.Substring(2));
            return "DG" + (index + 1).ToString("D3");
        }
        public bool isExitDG(String maDG)
        {
            return dg_DAO.isExitDG(maDG);
        }
    }
}
