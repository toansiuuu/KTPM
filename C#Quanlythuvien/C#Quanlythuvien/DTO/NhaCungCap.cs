using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private String MaNCC;
        private String TenNCC;
        private String DiaChi;
        private String Email;
        private Boolean TrangThai;
        public NhaCungCap()
        {

        }

        public NhaCungCap(string maNCC, string tenNCC, string diaChi, string email, bool trangThai)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            DiaChi = diaChi;
            Email = email;
            TrangThai = trangThai;
        }

        public string SGMaNCC { get => MaNCC; set => MaNCC = value; }
        public string SGTenNCC { get => TenNCC; set => TenNCC = value; }
        public string SGDiaChi { get => DiaChi; set => DiaChi = value; }
        public string SGEmail { get => Email; set => Email = value; }
        public bool SGTrangThai { get => TrangThai; set => TrangThai = value; }
    }
}
