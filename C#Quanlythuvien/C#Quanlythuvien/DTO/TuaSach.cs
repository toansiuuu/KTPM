using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TuaSach
    {
        private String MaTuaSach;
        private String TenTuaSach;
        private String MaNXB;
        private int SoLuong;
        private int NamXB;
        private String Image;
        private String MoTa;
        private String MaTacGia;
        private Boolean TrangThai;

        public TuaSach()
        {

        }

        public TuaSach(string maTuaSach, string tenTuaSach, string maNXB, int soLuong, int namXB, string image, string moTa, string maTacGia, bool trangThai)
        {
            MaTuaSach = maTuaSach;
            TenTuaSach = tenTuaSach;
            MaNXB = maNXB;
            SoLuong = soLuong;
            NamXB = namXB;
            Image = image;
            MoTa = moTa;
            MaTacGia = maTacGia;
            TrangThai = trangThai;
        }

        public string SGMaTuaSach { get => MaTuaSach; set => MaTuaSach = value; }
        public string SGTenTuaSach { get => TenTuaSach; set => TenTuaSach = value; }
        public string SGMaNXB { get => MaNXB; set => MaNXB = value; }
        public int SGSoLuong { get => SoLuong; set => SoLuong = value; }
        public int SGNamXB { get => NamXB; set => NamXB = value; }
        public string SGImage { get => Image; set => Image = value; }
        public string SGMoTa { get => MoTa; set => MoTa = value; }
        public string SGMaTacGia { get => MaTacGia; set => MaTacGia = value; }
        public bool SGTrangThai { get => TrangThai; set => TrangThai = value; }
        
    }
}
