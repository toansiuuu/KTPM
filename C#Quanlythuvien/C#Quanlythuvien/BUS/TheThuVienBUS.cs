using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TheThuVienBUS
    {
        private TheThuVienDAO ttv_DAO = new TheThuVienDAO();
        public List<TheThuVien> getAllTheThuVien()
        {
            return ttv_DAO.getAllTheThuVien();
        }
        public String getLastMaThe()
        {
            String mathe = ttv_DAO.getLastMaThe();
            int index = Convert.ToInt32(mathe.Substring(3));
            return "TTV" + (index + 1).ToString("D3");
        }

        public TheThuVien getTheByDocGia(String madg)
        {
            return ttv_DAO.getTheByDocGia(madg);
        }

        public TheThuVien getTheByMa(String mathe)
        {
            return ttv_DAO.getTheByMa(mathe);
        }

        public Boolean checkDocGia(String madocgia)
        {
            return ttv_DAO.checkDocGia(madocgia);
        }

        public Boolean addTheThuVien(TheThuVien ttv)
        {
            return ttv_DAO.addTheThuVien(ttv);
        }

        public Boolean updateTheThuVien(TheThuVien ttv)
        {
            return ttv_DAO.updateTheThuVien(ttv);
        }

    }
}
