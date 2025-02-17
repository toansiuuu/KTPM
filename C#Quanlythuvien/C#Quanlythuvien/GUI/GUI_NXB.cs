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
    public partial class GUI_NXB : Form
    {
        NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();
        List<NhaXuatBan> listNXB = new List<NhaXuatBan>();
        DataTable dt;
        public GUI_NXB(String chiTiet)
        {
            InitializeComponent();
            SetUpListView();
            LoadNXB();
            rdo_maNXB.Checked = true;
            cbbox_tinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_tinhTrang.SelectedIndex = 0;
            SetUpAccessPermissions(chiTiet);
        }
        public void SetUpAccessPermissions(String chiTiet)
        {
            if (chiTiet.Trim().Equals(""))
            {
                bttn_them.Visible = false;
                bttn_sua.Visible = false;
            }
            else
            {
                if (!chiTiet.Contains("Thêm"))
                {
                    bttn_them.Visible = false;
                }
                if (!chiTiet.Contains("Sửa"))
                {
                    bttn_sua.Visible = false;
                }
            }
        }
        public void SetUpListView()
        {
            lsNXB.Columns[0].Width = (int)(lsNXB.Width * 0.20);
            lsNXB.Columns[1].Width = (int)(lsNXB.Width * 0.20);
            lsNXB.Columns[2].Width = (int)(lsNXB.Width * 0.20);
            lsNXB.Columns[3].Width = (int)(lsNXB.Width * 0.20);
            lsNXB.Columns[4].Width = (int)(lsNXB.Width * 0.20);
            lsNXB.View = View.Details;
            lsNXB.GridLines = true;
            lsNXB.FullRowSelect = true;
        }
        public void LoadNXB()
        {
            lsNXB.Items.Clear();
            dt = nxbBUS.getALlNXB();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsNXB.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                String trangThai = Convert.ToBoolean(dt.Rows[i][4]) ? "Đang Hoạt Động" : "Ngừng Hoạt Động";
                lvi.SubItems.Add(trangThai);
            }
        }
        public void Filter()
        {
            lsNXB.Items.Clear();
            dt = nxbBUS.getALlNXB();
            FilterSearch();
            FilterStatus();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsNXB.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                String trangThai = Convert.ToBoolean(dt.Rows[i][4]) ? "Đang Hoạt Động" : "Ngừng Hoạt Động";
                lvi.SubItems.Add(trangThai);
            }
        }
        public void FilterSearch()
        {
            if (tb_timkiem.Text.Length != 0)
            {
                if (rdo_maNXB.Checked)
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
                else if (rdo_tenNXB.Checked)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (!dt.Rows[i][1].ToString().ToLower().Contains(tb_timkiem.Text.ToLower().Trim()))
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
            if (cbbox_tinhTrang.SelectedIndex == 1)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToBoolean(dt.Rows[i][4]))
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (cbbox_tinhTrang.SelectedIndex == 2)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dt.Rows[i][4]))
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
        private void cbbox_tinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void bttn_them_Click(object sender, EventArgs e)
        {
            frmThemNXB form = new frmThemNXB();
            form.FormClosed += FormCon_FormClosed;
            form.ShowDialog();
        }
        public void FormCon_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadNXB();
        }

        private void bttn_sua_Click(object sender, EventArgs e)
        {
            if (lsNXB.SelectedItems.Count > 0)
            {
                string manxb = lsNXB.SelectedItems[0].SubItems[0].Text;
                string tennxb = lsNXB.SelectedItems[0].SubItems[1].Text;
                string diachi = lsNXB.SelectedItems[0].SubItems[2].Text;
                string email = lsNXB.SelectedItems[0].SubItems[3].Text;
                string trangThaiString = lsNXB.SelectedItems[0].SubItems[4].Text;
                bool trangThai = false;
                if (trangThaiString.Equals("Đang Hoạt Động"))
                {
                    trangThai = true;
                }
                NhaXuatBan nxb = new NhaXuatBan(manxb,tennxb,diachi,email,trangThai);
                frmSuaNXB form = new frmSuaNXB(nxb);
                form.FormClosed += FormCon_FormClosed;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Một Nhà Xuất Bản Để Sửa!");
            }
        }
    }
}
