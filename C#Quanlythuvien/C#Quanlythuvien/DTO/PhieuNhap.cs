using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap
    {
        private String MaPhieuNhap;
        private String MaNCC;
        private String MaNhanVien;
        private DateTime NgayNhap;
        private float TongTien;
        private Boolean TinhTrang;

        public PhieuNhap()
        {

        }

        public PhieuNhap(string maPhieuNhap, string maNCC, string maNhanVien, DateTime ngayNhap, float tongTien, bool tinhTrang)
        {
            MaPhieuNhap = maPhieuNhap;
            MaNCC = maNCC;
            MaNhanVien = maNhanVien;
            NgayNhap = ngayNhap;
            TongTien = tongTien;
            TinhTrang = tinhTrang;
        }

        public string SGMaPhieuNhap { get => MaPhieuNhap; set => MaPhieuNhap = value; }
        public string SGMaNCC { get => MaNCC; set => MaNCC = value; }
        public string SGMaNhanVien { get => MaNhanVien; set => MaNhanVien = value; }
        public DateTime SGNgayNhap { get => NgayNhap; set => NgayNhap = value; }
        public float SGTongTien { get => TongTien; set => TongTien = value; }
        public bool SGTinhTrang { get => TinhTrang; set => TinhTrang = value; }
    }
}
