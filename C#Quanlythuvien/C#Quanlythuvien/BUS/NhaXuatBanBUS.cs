using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaXuatBanBUS
    {
        private NhaXuatBanDAO dao = new NhaXuatBanDAO();
        public NhaXuatBan getNhaXuatBanByID(string ts)
        {
            return dao.getNhaXuatBanByID(ts);
        }
        public DataTable getALlNXB()
        {
            return dao.getALlNXB();
        }
        public List<NhaXuatBan> getAllListNXB()
        {
            return dao.getAllListNXB();
        }
        public String getLastMaNXB()
        {
            String mapm = dao.getLastMaNXB();
            int index = Convert.ToInt32(mapm.Substring(3));
            return "NXB" + (index + 1).ToString("D3");
        }
        public bool addNXB(NhaXuatBan nxb)
        {
            return dao.addNXB(nxb);
        }
        public bool fixNXB(NhaXuatBan nxb)
        {
            return dao.fixNXB(nxb);
        }
    }
}
