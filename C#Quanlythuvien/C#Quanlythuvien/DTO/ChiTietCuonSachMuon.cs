using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietCuonSachMuon
    {
        private String MaPhieuMuon;
        private String MaTuaSach;
        private String MaCuonSach;

        public ChiTietCuonSachMuon()
        {
        }

        public ChiTietCuonSachMuon(string maPhieuMuon, string maTuaSach, string maCuonSach)
        {
            MaPhieuMuon = maPhieuMuon;
            MaTuaSach = maTuaSach;
            MaCuonSach = maCuonSach;
        }

        public string SGMaPhieuMuon { get => MaPhieuMuon; set => MaPhieuMuon = value; }
        public string SGMaTuaSach { get => MaTuaSach; set => MaTuaSach = value; }
        public string SGMaCuonSach { get => MaCuonSach; set => MaCuonSach = value; }
    }
}
