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
    public class TaiKhoanBUS
    {
        TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        public List<TaiKhoan> getALLTaiKhoan()
        {
            return tkDAO.getALLTaiKhoan();
        }
        public DataTable getAllTaiKhoanDataTable()
        {
            return tkDAO.getAllTaiKhoanDataTable();
        }
        public int updateTTTaiKhoan(string matk, bool trangthai)
        {
            return tkDAO.updateTTTaiKhoan(matk,trangthai);
        }
        public int updateQuyenTaiKhoan(string matk, string maQuyen)
        {
            return tkDAO.updateQuyenTaiKhoan(matk, maQuyen);
        }
        public int insertTaiKhoan(TaiKhoan tk)
        {
            return tkDAO.insertTaiKhoan(tk);
        }
        public NhanVienDTO getInFoNVByMa(String maNV)
        {
            return tkDAO.getInFoNVByMa(maNV);
        }
    }
}
