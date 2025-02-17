using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGiaDTO
    {
        string maTG;
        string tenTG;
        string moTa;
        bool tinhTrang;
        string img;

        public TacGiaDTO()
        {
        }

        public TacGiaDTO(string maTG, string tenTG, string moTa, bool tinhTrang, string img)
        {
            this.maTG = maTG;
            this.tenTG = tenTG;
            this.moTa = moTa;
            this.tinhTrang = tinhTrang;
            this.img = img;
        }

        public string MaTG { get => maTG; set => maTG = value; }
        public string TenTG { get => tenTG; set => tenTG = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string Img { get => img; set => img = value; }
    }
}
