using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucNang
    {
        private String MaCN;
        private String TenCN;

        public ChucNang()
        {

        }

        public ChucNang(string maCN, string tenCN)
        {
            MaCN = maCN;
            TenCN = tenCN;
        }

        public string SGMaCN { get => MaCN; set => MaCN = value; }
        public string SGTenCN { get => TenCN; set => TenCN = value; }
    }
}
