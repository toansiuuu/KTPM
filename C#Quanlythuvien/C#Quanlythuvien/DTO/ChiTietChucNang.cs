using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietChucNang
    {
        private String MaCN;
        private String MaQuyen;
        private String ChiTiet;

        public ChiTietChucNang()
        {
        }

        public ChiTietChucNang(string maCN, string maQuyen, string chiTiet)
        {
            MaCN = maCN;
            MaQuyen = maQuyen;
            ChiTiet = chiTiet;
        }

        public string SGMaCN { get => MaCN; set => MaCN = value; }
        public string SGMaQuyen { get => MaQuyen; set => MaQuyen = value; }
        public string SGChiTiet { get => ChiTiet; set => ChiTiet = value; }
    }
}
