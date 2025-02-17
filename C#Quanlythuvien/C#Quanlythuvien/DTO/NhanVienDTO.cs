using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        string maNhanVien;
        string tenNhanVien;
        bool gioiTinh;
        DateTime ngaySinh;
        string diaChi;
        string sdt;
        string chucVu;
        bool trangThai;
        string img;

        public NhanVienDTO()
        {
        }

        public NhanVienDTO(string maNhanVien, string tenNhanVien, bool gioiTinh, DateTime ngaySinh, string diaChi, string sdt, string chucVu, bool trangThai, string img)
        {
            this.MaNhanVien = maNhanVien;
            this.TenNhanVien = tenNhanVien;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.ChucVu = chucVu;
            this.TrangThai = trangThai;
            this.Img = img;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public string Img { get => img; set => img = value; }
       
    }
}
