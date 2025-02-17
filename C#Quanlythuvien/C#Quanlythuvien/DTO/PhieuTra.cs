using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuTra
    {
        private String MaPhieuMuon;
        private DateTime NgayTra;
        private float TienPhat;
        private Boolean TrangThai;
        public PhieuTra()
        {
        }

        public PhieuTra(string maPhieuMuon, DateTime ngayTra, float tienPhat, bool trangThai)
        {
            MaPhieuMuon = maPhieuMuon;
            NgayTra = ngayTra;
            TienPhat = tienPhat;
            TrangThai = trangThai;
        }

        public string SGMaPhieuMuon { get => MaPhieuMuon; set => MaPhieuMuon = value; }
        public DateTime SGNgayTra { get => NgayTra; set => NgayTra = value; }
        public float SGTienPhat { get => TienPhat; set => TienPhat = value; }
        public bool SGTrangThai { get => TrangThai; set => TrangThai = value; }
    }
}
