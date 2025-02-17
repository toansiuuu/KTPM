using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoaiDTO
    {
        string maTL;
        string tenTL;
        string moTa;

        public TheLoaiDTO()
        {
        }

        public TheLoaiDTO(string maTL, string tenTL, string moTa)
        {
            this.MaTL = maTL;
            this.TenTL = tenTL;
            this.MoTa = moTa;
        }

        public string MaTL { get => maTL; set => maTL = value; }
        public string TenTL { get => tenTL; set => tenTL = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
