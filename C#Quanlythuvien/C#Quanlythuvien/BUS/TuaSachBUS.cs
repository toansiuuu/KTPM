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
    public class TuaSachBUS
    {
        TuaSachDAO ts_Dao = new TuaSachDAO();
        public List<TuaSach> getAllTuaSach()
        {
            List<TuaSach> list = new List<TuaSach>();
            list = ts_Dao.getAllTuaSach();
            return list;
        }
        public DataTable getALlTuaSachChoMuon()
        {
            return ts_Dao.getALlTuaSachChoMuon();
        }
        public TuaSach getTuaSachBangMa(String ma)
        {
            return ts_Dao.GetTuaSachBangMa(ma);
        }
        public String getLastMaTuaSach()
        {
            String mats = ts_Dao.getLastMaTuaSach();
            int index = Convert.ToInt32(mats.Substring(2));
            return "TS" + (index + 1).ToString("D3");
        }

        public int addTuaSach(TuaSach tuaSach)
        {
            if (ts_Dao.kiemTraTrungMa(tuaSach))
            {
                return 3;
            }
            return ts_Dao.addTuaSach(tuaSach);
        }

        public int editTuaSach(TuaSach tuasach)
        {
            return ts_Dao.editTuaSach(tuasach);
        }

        public bool updateTTTuaSach(TuaSach tuaSach)
        {
            if (ts_Dao.updateTTTuaSach(tuaSach) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
