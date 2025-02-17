using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuon
    {
        private String MaPhieuMuon;
        private String MaThe;
        private DateTime NgayMuon;
        private DateTime HanTra;
        private String MaNhanVien;
        private Boolean TrangThai;
        public PhieuMuon()
        {
        }

        public PhieuMuon(string maPhieuMuon, string maThe, DateTime ngayMuon, DateTime hanTra, string maNhanVien, bool trangThai)
        {
            MaPhieuMuon = maPhieuMuon;
            MaThe = maThe;
            NgayMuon = ngayMuon;
            HanTra = hanTra;
            MaNhanVien = maNhanVien;
            TrangThai = trangThai;
        }

        public string SGMaPhieuMuon { get => MaPhieuMuon; set => MaPhieuMuon = value; }
        public string SGMaThe { get => MaThe; set => MaThe = value; }
        public DateTime SGNgayMuon { get => NgayMuon; set => NgayMuon = value; }
        public DateTime SGHanTra { get => HanTra; set => HanTra = value; }
        public string SGMaNhanVien { get => MaNhanVien; set => MaNhanVien = value; }
        public bool SGTrangThai { get => TrangThai; set => TrangThai = value; }
    }
}
