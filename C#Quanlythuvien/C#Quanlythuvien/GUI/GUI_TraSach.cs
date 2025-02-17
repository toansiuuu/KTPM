using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_TraSach : Form
    {
        PhieuMuonBUS pmBUS = new PhieuMuonBUS();
        PhieuTraBUS ptBUS = new PhieuTraBUS();
        DocGiaBUS dgBUS = new DocGiaBUS();
        TheThuVienBUS ttvBUS = new TheThuVienBUS();

        List<PhieuMuon> listPM = new List<PhieuMuon>();
        List<DocGia> listDG = new List<DocGia>();
        List<TheThuVien> listTTV = new List<TheThuVien>();
        DataTable dt;
        DataTable dt_PM;

        public GUI_TraSach()
        {
            InitializeComponent();
            SetUpListView();
            LoadAll();
            cbbox_tinhtrang.SelectedIndex = 0;
            cbbox_tinhtrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_trangthai2.SelectedIndex = -1;
            cbbox_trangthai2.DropDownStyle = ComboBoxStyle.DropDownList;
            rdo_mapm.Checked = true;
            rdo_mapm2.Checked = true;
        }
        public GUI_TraSach(String chiTiet)
        {
            InitializeComponent();
            SetUpListView();
            LoadAll();
            cbbox_tinhtrang.SelectedIndex = 0;
            cbbox_tinhtrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_trangthai2.SelectedIndex = -1;
            cbbox_trangthai2.DropDownStyle = ComboBoxStyle.DropDownList;
            rdo_mapm.Checked = true;
            rdo_mapm2.Checked = true;
            SetUpAccessPermissions(chiTiet);
        }
        public void SetUpAccessPermissions(String chiTiet)
        {
            if (chiTiet.Trim().Equals(""))
            {
                tabControl1.TabPages.Remove(tabPage2);
            }
        }
        public void SetUpListView()
        {
            lsPT.Columns[0].Width = (int)(lsPT.Width * 0.25);
            lsPT.Columns[1].Width = (int)(lsPT.Width * 0.25);
            lsPT.Columns[2].Width = (int)(lsPT.Width * 0.25);
            lsPT.Columns[3].Width = (int)(lsPT.Width * 0.25);
            lsPT.Columns[4].Width = 0;
            lsPT.View = View.Details;
            lsPT.GridLines = true;
            lsPT.FullRowSelect = true;

            lsPM.Columns[0].Width = (int)(lsPM.Width * 0.20);
            lsPM.Columns[1].Width = (int)(lsPM.Width * 0.20);
            lsPM.Columns[2].Width = (int)(lsPM.Width * 0.20);
            lsPM.Columns[3].Width = (int)(lsPM.Width * 0.20);
            lsPM.Columns[4].Width = (int)(lsPM.Width * 0.20);
            lsPM.View = View.Details;
            lsPM.GridLines = true;
            lsPM.FullRowSelect = true;
        }
        public void LoadAll()
        {
            listPM = pmBUS.getALlPhieuMuon();
            listDG = dgBUS.getAllDocGia();
            listTTV = ttvBUS.getAllTheThuVien();
            LoadPT();
            LoadPMChuaTra();
        }
        public void LoadPT()
        {
            lsPT.Items.Clear();
            dt = ptBUS.getALLPT();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsPT.Items.Add(dt.Rows[i][0].ToString());
                DateTime date = Convert.ToDateTime(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(date.Date.ToString("MM/dd/yyyy"));
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                String tranThai = Convert.ToBoolean(dt.Rows[i][3]) ? "Đúng Hạn" : "Trễ Hạn";
                lvi.SubItems.Add(tranThai);
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }
        public void LoadPMChuaTra()
        {
            lsPM.Items.Clear();
            dt_PM = pmBUS.getALPMChuaTra();
            for (int i = 0; i < dt_PM.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsPM.Items.Add(dt_PM.Rows[i][0].ToString());
                lvi.SubItems.Add(dt_PM.Rows[i][1].ToString());
                DateTime date = Convert.ToDateTime(dt_PM.Rows[i][2].ToString());
                lvi.SubItems.Add(date.Date.ToString("MM/dd/yyyy"));
                DateTime dateht = Convert.ToDateTime(dt_PM.Rows[i][3].ToString());
                lvi.SubItems.Add(dateht.Date.ToString("MM/dd/yyyy"));
                lvi.SubItems.Add(dt_PM.Rows[i][4].ToString());
            }
        }

        private void lsPT_Click(object sender, EventArgs e)
        {
            if (lsPT.SelectedIndices.Count > 0)
            {
                String mapm = lsPT.SelectedItems[0].SubItems[0].Text;
                String mattv = lsPT.SelectedItems[0].SubItems[4].Text;
                String madg = "";
                foreach (PhieuMuon pm in listPM)
                {
                    if (pm.SGMaPhieuMuon.Equals(mapm))
                    {
                        tb_mathe.Text = pm.SGMaThe;
                        dtp_ngmuon.Value = pm.SGNgayMuon;
                        dtp_hantra.Value = pm.SGHanTra;
                        break;
                    }
                }
                foreach (TheThuVien ttv in listTTV)
                {
                    if (ttv.SGMaThe.Equals(mattv))
                    {
                        madg = ttv.SGMaDocGia;
                        break;
                    }
                }
                foreach (DocGia dg in listDG)
                {
                    if (dg.SGMaDocGia.Equals(madg))
                    {
                        tb_madg.Text = dg.SGMaDocGia;
                        tb_tendg.Text = dg.SGTenDG;
                        break;
                    }
                }
            }
        }
        public void Filter()
        {
            lsPT.Items.Clear();
            dt = ptBUS.getALLPT();
            FilterSearch();
            FilterStatus();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsPT.Items.Add(dt.Rows[i][0].ToString());
                DateTime date = Convert.ToDateTime(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(date.Date.ToString("MM/dd/yyyy"));
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                String tranThai = Convert.ToBoolean(dt.Rows[i][3]) ? "Đúng Hạn" : "Trễ Hạn";
                lvi.SubItems.Add(tranThai);
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }
        public void FilterSearch()
        {
            if (tb_timkiem.Text.Length != 0)
            {
                if (rdo_mapm.Checked)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (!dt.Rows[i][0].ToString().ToLower().Contains(tb_timkiem.Text.ToLower().Trim()))
                        {
                            dt.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (rdo_mathe.Checked)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (!dt.Rows[i][4].ToString().ToLower().Contains(tb_timkiem.Text.ToLower().Trim()))
                        {
                            dt.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }
        public void FilterStatus()
        {
            if (cbbox_tinhtrang.SelectedIndex == 1)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToBoolean(dt.Rows[i][3]))
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (cbbox_tinhtrang.SelectedIndex == 2)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dt.Rows[i][3]))
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
        public void FilterPM()
        {
            lsPM.Items.Clear();
            dt_PM = pmBUS.getALPMChuaTra();
            if (tb_timkiem2.Text.Length != 0)
            {
                if (rdo_mapm2.Checked)
                {
                    for (int i = 0; i < dt_PM.Rows.Count; i++)
                    {
                        if (!dt_PM.Rows[i][0].ToString().ToLower().Contains(tb_timkiem2.Text.ToLower().Trim()))
                        {
                            dt_PM.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (rdo_mathe2.Checked)
                {
                    for (int i = 0; i < dt_PM.Rows.Count; i++)
                    {
                        if (!dt_PM.Rows[i][1].ToString().ToLower().Contains(tb_timkiem2.Text.ToLower().Trim()))
                        {
                            dt_PM.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            for (int i = 0; i < dt_PM.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsPM.Items.Add(dt_PM.Rows[i][0].ToString());
                lvi.SubItems.Add(dt_PM.Rows[i][1].ToString());
                DateTime date = Convert.ToDateTime(dt_PM.Rows[i][2].ToString());
                lvi.SubItems.Add(date.Date.ToString("MM/dd/yyyy"));
                DateTime dateht = Convert.ToDateTime(dt_PM.Rows[i][3].ToString());
                lvi.SubItems.Add(date.Date.ToString("MM/dd/yyyy"));
                lvi.SubItems.Add(dt_PM.Rows[i][4].ToString());
            }
        }
        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cbbox_tinhtrang_Click(object sender, EventArgs e)
        {
            Filter();
        }
        private void cbbox_tinhtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void tb_timkiem2_TextChanged(object sender, EventArgs e)
        {
            FilterPM();
        }

        private void lsPM_Click(object sender, EventArgs e)
        {
            if (lsPM.SelectedIndices.Count > 0)
            {
                String mattv = lsPM.SelectedItems[0].SubItems[1].Text;
                String madg = "";
                DateTime HanTra = Convert.ToDateTime(lsPM.SelectedItems[0].SubItems[3].Text);
                dtp_ngmuon2.Value = Convert.ToDateTime(lsPM.SelectedItems[0].SubItems[2].Text);
                dtp_hantra2.Value = HanTra;
                foreach (TheThuVien ttv in listTTV)
                {
                    if (ttv.SGMaThe.Equals(mattv))
                    {
                        madg = ttv.SGMaDocGia;
                        break;
                    }
                }
                foreach (DocGia dg in listDG)
                {
                    if (dg.SGMaDocGia.Equals(madg))
                    {
                        tb_madg2.Text = dg.SGMaDocGia;
                        tb_tendg2.Text = dg.SGTenDG;
                        tb_sdt2.Text = dg.SGSDT;
                        break;
                    }
                }
                int result = dtp_ngaytra2.Value.Date.CompareTo(HanTra.Date);
                if (result > 0)
                {
                    TimeSpan difference = dtp_ngaytra2.Value.Date - HanTra.Date;
                    int daysDifference = difference.Days;
                    tb_tienphat.Text = (daysDifference * 10000).ToString();
                    cbbox_trangthai2.SelectedIndex = 1;
                }
                else
                {
                    cbbox_trangthai2.SelectedIndex = 0;
                    tb_tienphat.Text = "0";
                }
            }
        }

        private void bttn_hoantat_Click(object sender, EventArgs e)
        {
            if (lsPM.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui Lòng Chọn Ít Nhất Một Phiếu Mượn!");
                return;
            }
            String mapm = lsPM.SelectedItems[0].SubItems[0].Text;
            DateTime ngayTra = dtp_ngaytra2.Value;
            float tienPhat = float.Parse(tb_tienphat.Text);
            bool trangThai = cbbox_trangthai2.SelectedIndex == 0?true:false;
            PhieuTra pt = new PhieuTra(mapm,ngayTra,tienPhat,trangThai);
            if (!ptBUS.addPT(pt))
            {
                MessageBox.Show("Lỗi thêm phiếu trả");
                return;
            }
            if (!ptBUS.suaTTPM(mapm))
            {
                MessageBox.Show("Lỗi sửa tình trạng phiếu mượn");
                return;
            }
            if (!ptBUS.suaTTCS(mapm))
            {
                MessageBox.Show("Lỗi sửa tình trạng cuốn sách mượn");
                return;
            }
            
            MessageBox.Show("Thành Cônng!");
            setNull();
        }
        public void setNull()
        {
            dtp_hantra2.Value = DateTime.Now.Date;
            dtp_ngmuon2.Value = DateTime.Now.Date;
            dtp_ngaytra2.Value = DateTime.Now.Date;
            tb_tienphat.Text = "";
            cbbox_trangthai2.SelectedIndex = - 1;
            tb_madg2.Text = "";
            tb_tendg2.Text = "";
            tb_sdt2.Text = "";
            rdo_mapm2.Checked = true;
            tb_timkiem2.Text = "";
            LoadPMChuaTra();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPT();
        }
    }
}
