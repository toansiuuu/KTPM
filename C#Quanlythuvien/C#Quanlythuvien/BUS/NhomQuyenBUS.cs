using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhomQuyenBUS
    {
        NhomQuyenDAO dao = new NhomQuyenDAO();
        public List<NhomQuyen> getAllNhomQuyen()
        {
            return dao.getAllNhomQuyen();
        }
    }
}
