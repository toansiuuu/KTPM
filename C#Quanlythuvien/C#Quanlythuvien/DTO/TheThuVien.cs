using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheThuVien
    {
        private String MaThe;
        private String MaDocGia;
        private DateTime NgayLapThe;
        private DateTime NgayHetHan;

        public TheThuVien()
        {

        }

        public TheThuVien(string maThe, string maDocGia, DateTime ngayLapThe, DateTime ngayHetHan)
        {
            MaThe = maThe;
            MaDocGia = maDocGia;
            NgayLapThe = ngayLapThe;
            NgayHetHan = ngayHetHan;
        }

        public string SGMaThe { get => MaThe; set => MaThe = value; }
        public string SGMaDocGia { get => MaDocGia; set => MaDocGia = value; }
        public DateTime SGNgayLapThe { get => NgayLapThe; set => NgayLapThe = value; }
        public DateTime SGNgayHetHan { get => NgayHetHan; set => NgayHetHan = value; }
    }
}