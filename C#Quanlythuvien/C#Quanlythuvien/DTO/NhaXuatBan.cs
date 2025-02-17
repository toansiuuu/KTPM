using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaXuatBan
    {
        private String MaNXB;
        private String TenNXB;
        private String DiaChiNXB;
        private String EmailNXB;
        private Boolean TrangThai;
        public NhaXuatBan()
        {

        }

        public NhaXuatBan(string maNXB, string tenNXB, string diaChiNXB, string emailNXB, bool trangThai)
        {
            MaNXB = maNXB;
            TenNXB = tenNXB;
            DiaChiNXB = diaChiNXB;
            EmailNXB = emailNXB;
            TrangThai = trangThai;
        }

        public string SGMaNXB { get => MaNXB; set => MaNXB = value; }
        public string SGTenNXB { get => TenNXB; set => TenNXB = value; }
        public string SGDiaChiNXB { get => DiaChiNXB; set => DiaChiNXB = value; }
        public string SGEmailNXB { get => EmailNXB; set => EmailNXB = value; }
        public bool SGTrangThai { get => TrangThai; set => TrangThai = value; }
    }
}
