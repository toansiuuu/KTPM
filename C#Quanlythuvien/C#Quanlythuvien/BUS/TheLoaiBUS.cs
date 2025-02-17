using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TheLoaiBUS
    {
        TheLoaiDAO dao = new TheLoaiDAO();
        public List<TheLoaiDTO> getAllTheLoai()
        {
            return dao.getAllTheLoai();
        }

        public TheLoaiDTO getTlByID(String id)
        {
            return dao.getTlByID(id);
        }

        public String getLastMaTL()
        {
            String mapm = dao.getLastMaTL();
            int index = Convert.ToInt32(mapm.Substring(2));
            return "TL" + (index + 1).ToString("D3");
        }
        public int insertTL(TheLoaiDTO tl)
        {
            return dao.insertTL(tl);
        }
        public int updateTL(TheLoaiDTO tl)
        {
            return dao.updateTheLoai(tl);
        }
    }
}
