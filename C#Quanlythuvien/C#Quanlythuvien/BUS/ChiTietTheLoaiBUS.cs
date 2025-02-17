using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietTheLoaiBUS
    {
        private ChiTietTheLoaiDAO ChiTietTheLoaiDAO = new ChiTietTheLoaiDAO();
        public List<ChiTietTheLoai> GetChiTietTheLoaiByID(String id)
        {
            return ChiTietTheLoaiDAO.GetChiTietTheLoaiByIDSach(id);
        }

        public List<ChiTietTheLoai> getCttlByIDTheLoai(String matheloai)
        {
            return ChiTietTheLoaiDAO.GetCttlByIDTheLoai(matheloai);
        }

        public List<ChiTietTheLoai> GetChiTietTheLoaiByIDSach(String matuasach)
        {
            return ChiTietTheLoaiDAO.GetChiTietTheLoaiByIDSach(matuasach);
        }

        public Boolean addChiTietTheloai(String maSach, String maTheLoai)
        {
            return ChiTietTheLoaiDAO.addChiTietTheLoai(maSach, maTheLoai);
        }
        public Boolean deleteChiTietTheLoaibyID(String maSach, String matl)
        {
            return ChiTietTheLoaiDAO.deleteChiTietTheLoaibyID(maSach, matl);
        }

        public Boolean deleteChiTietTheLoaibyID(String maSach)
        {
            return ChiTietTheLoaiDAO.deleteChiTietTheLoaibyID(maSach);
        }


    }
}
