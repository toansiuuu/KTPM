using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhomQuyen
    {
        private String MaQuyen;
        private String TenQuyen;
        private String MoTa;

        public NhomQuyen()
        {

        }

        public NhomQuyen(string maQuyen, string tenQuyen, string moTa)
        {
            MaQuyen = maQuyen;
            TenQuyen = tenQuyen;
            MoTa = moTa;
        }

        public string SGMaQuyen { get => MaQuyen; set => MaQuyen = value; }
        public string SGTenQuyen { get => TenQuyen; set => TenQuyen = value; }
        public string SGMoTa { get => MoTa; set => MoTa = value; }
    }
}
