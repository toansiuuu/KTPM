using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietChucNangBUS
    {
        ChiTietChucNangDAO dao = new ChiTietChucNangDAO();
        public List<string> getMaCNbyMaQuyen(string maQ)
        {
            return dao.getMaCNbyMaQuyen(maQ);
        }
        public List<ChiTietChucNang> getAllChucNangByMaQuyen(string maNV)
        {
            return dao.getAllChiTietChucNangByMa(maNV);
        }
        public void insert(ChiTietChucNang ctcn)
        {
            dao.InsertChiTietChucNang(ctcn);
        }
        public void update(ChiTietChucNang cu)
        {
            dao.UpdateChiTietChucNang(cu);
        }
        public void delete(string maCN, string maQ)
        {
            dao.DeleteChiTietChucNang(maCN, maQ);
        }
    }
}
