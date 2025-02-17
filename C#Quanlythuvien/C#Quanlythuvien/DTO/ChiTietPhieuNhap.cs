using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        private String MaPhieuNhap;
        private String MaTuaSach;
        private int SoLuong;
        private float DonGia;

        public ChiTietPhieuNhap()
        {
        }

        public ChiTietPhieuNhap(string maPhieuNhap, string maTuaSach, int soLuong, float donGia)
        {
            MaPhieuNhap = maPhieuNhap;
            MaTuaSach = maTuaSach;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public string SGMaPhieuNhap { get => MaPhieuNhap; set => MaPhieuNhap = value; }
        public string SGMaTuaSach { get => MaTuaSach; set => MaTuaSach = value; }
        public int SGSoLuong { get => SoLuong; set => SoLuong = value; }
        public float SGDonGia { get => DonGia; set => DonGia = value; }
    }
}
