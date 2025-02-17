using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmXemChiTietCuonSachMuon : Form
    {
        ChiTietCuonSachBUS ctcsBUS = new ChiTietCuonSachBUS();
        List<ChiTietCuonSachMuon> listCTCSM = new List<ChiTietCuonSachMuon>();
        String mapm;
        String mats;
        public frmXemChiTietCuonSachMuon(String mapm, String mats)
        {
            InitializeComponent();
            this.mapm = mapm;
            this.mats = mats;
            SetUpListView();
            LoadCTCSM();
        }
        public void SetUpListView()
        {
            lsCTCSM.Columns[0].Width = (int)(lsCTCSM.Width * 0.33);
            lsCTCSM.Columns[1].Width = (int)(lsCTCSM.Width * 0.33);
            lsCTCSM.Columns[2].Width = (int)(lsCTCSM.Width * 0.33);
            lsCTCSM.View = View.Details;
            lsCTCSM.GridLines = true;
            lsCTCSM.FullRowSelect = true;
        }
        public void LoadCTCSM()
        {
            lsCTCSM.Items.Clear();
            DataTable dt = ctcsBUS.getALlCTCSM();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToString(dt.Rows[i][0]).Equals(mapm) &&
                    Convert.ToString(dt.Rows[i][1]).Equals(mats))
                {
                    ListViewItem lvi =
                    lsCTCSM.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                }
            }
        }
    }
}
