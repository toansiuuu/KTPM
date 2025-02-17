using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChucNangBUS
    {
        ChucNangDAO dao = new ChucNangDAO();
        public List<ChucNang> getAllChucNang()
        {
            return dao.getAllChucNang();
        }
    }
}
