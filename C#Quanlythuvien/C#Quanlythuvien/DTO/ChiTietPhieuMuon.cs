using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuMuon
    {
        private String MaPhieuMuon;
        private String MaTuaSach;
        private int SoLuong;

        public ChiTietPhieuMuon()
        {
        }

        public ChiTietPhieuMuon(string maPhieuMuon, string maTuaSach, int soLuong)
        {
            MaPhieuMuon = maPhieuMuon;
            MaTuaSach = maTuaSach;
            SoLuong = soLuong;
        }

        public string SGMaPhieuMuon { get => MaPhieuMuon; set => MaPhieuMuon = value; }
        public string SGMaTuaSach { get => MaTuaSach; set => MaTuaSach = value; }
        public int SGSoLuong { get => SoLuong; set => SoLuong = value; }
    }
}
