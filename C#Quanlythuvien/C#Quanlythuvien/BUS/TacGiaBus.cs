using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TacGiaBus
    {
        TacGiaDAO dao = new TacGiaDAO();
        public List<TacGiaDTO> getAllTacGia()
        {
            return dao.getAllTacGia();
        }
        public TacGiaDTO getTacGiaByMa(string maTG)
        {
            return dao.getTacGiaByMa(maTG);
        }
        public int updateTacGia(TacGiaDTO tg)
        {
            int a = dao.updateTacGia(tg);
            return a;
        }
        public String getLastMaTG()
        {
            String mapm = dao.getLastMaTG();
            int index = Convert.ToInt32(mapm.Substring(2));
            return "TG" + (index + 1).ToString("D3");
        }
        public int insertTG(TacGiaDTO tg)
        {
            return dao.insertTacGia(tg);
        }
    }
}
