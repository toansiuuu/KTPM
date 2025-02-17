using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia
    {
        private String MaDocGia;
        private String TenDG;
        private DateTime NgaySinh;
        private String DiaChi;
        private String Email;
        private String SDT;
        private Boolean TrangThai;

        public DocGia()
        {

        }

        public DocGia(string maDocGia, string tenDG, DateTime ngaySinh, string diaChi, string email, string sDT, bool trangThai)
        {
            MaDocGia = maDocGia;
            TenDG = tenDG;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            Email = email;
            SDT = sDT;
            TrangThai = trangThai;
        }

        public string SGMaDocGia { get => MaDocGia; set => MaDocGia = value; }
        public string SGTenDG { get => TenDG; set => TenDG = value; }
        public DateTime SGNgaySinh { get => NgaySinh; set => NgaySinh = value; }
        public string SGDiaChi { get => DiaChi; set => DiaChi = value; }
        public string SGEmail { get => Email; set => Email = value; }
        public string SGSDT { get => SDT; set => SDT = value; }
        public bool SGTrangThai { get => TrangThai; set => TrangThai = value; }
    }
}
