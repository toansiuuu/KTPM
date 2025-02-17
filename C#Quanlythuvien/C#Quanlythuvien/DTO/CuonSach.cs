using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CuonSach
    {
        private String MaCuonSach;
        private String MaTuaSach;
        private int TrangThaiSach;

        public CuonSach()
        {
        }

        public CuonSach(string maCuonSach, string maTuaSach, int trangThaiSach)
        {
            MaCuonSach = maCuonSach;
            MaTuaSach = maTuaSach;
            TrangThaiSach = trangThaiSach;
        }

        public string SGMaCuonSach { get => MaCuonSach; set => MaCuonSach = value; }
        public string SGMaTuaSach { get => MaTuaSach; set => MaTuaSach = value; }
        public int SGTrangThaiSach { get => TrangThaiSach; set => TrangThaiSach = value; }
    }
}
