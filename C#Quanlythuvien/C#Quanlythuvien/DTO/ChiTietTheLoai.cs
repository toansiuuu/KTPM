using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietTheLoai
    {
        private String MaTheLoai;
        private String MaTuaSach;

        public ChiTietTheLoai()
        {
        }

        public ChiTietTheLoai(string maTheLoai, string maTuaSach)
        {
            MaTheLoai = maTheLoai;
            MaTuaSach = maTuaSach;
        }

        public string SGMaTheLoai { get => MaTheLoai; set => MaTheLoai = value; }
        public string SGMaTuaSach { get => MaTuaSach; set => MaTuaSach = value; }
    }
}
