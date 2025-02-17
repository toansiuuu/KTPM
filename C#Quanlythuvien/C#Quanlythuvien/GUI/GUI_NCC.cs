using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class GUI_NCC : Form
    {
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        List<NhaCungCap> listNCC = new List<NhaCungCap>();
        DataTable dt;
        public GUI_NCC()
        {
            InitializeComponent();
            SetUpListView();
            LoadNCC();
            rdo_maNCC.Checked = true;
            cbbox_tinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_tinhTrang.SelectedIndex = 0;
        }
        public GUI_NCC(String chiTiet)
        {
            InitializeComponent();
            SetUpListView();
            LoadNCC();
            rdo_maNCC.Checked = true;
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
            lsNCC.Columns[0].Width = (int)(lsNCC.Width * 0.20);
            lsNCC.Columns[1].Width = (int)(lsNCC.Width * 0.20);
            lsNCC.Columns[2].Width = (int)(lsNCC.Width * 0.20);
            lsNCC.Columns[3].Width = (int)(lsNCC.Width * 0.20);
            lsNCC.Columns[4].Width = (int)(lsNCC.Width * 0.20);
            lsNCC.View = View.Details;
            lsNCC.GridLines = true;
            lsNCC.FullRowSelect = true;
        }
        public void LoadNCC()
        {
            lsNCC.Items.Clear();
            dt = nccBUS.getAllNhaCungCapDataTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsNCC.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                String trangThai = Convert.ToBoolean(dt.Rows[i][4]) ? "Đang Hoạt Động" : "Ngừng Hoạt Động";
                lvi.SubItems.Add(trangThai);
            }
        }
        public void Filter()
        {
            lsNCC.Items.Clear();
            dt = nccBUS.getAllNhaCungCapDataTable();
            FilterSearch();
            FilterStatus();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsNCC.Items.Add(dt.Rows[i][0].ToString());
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
                if (rdo_maNCC.Checked)
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
                else if (rdo_tenNCC.Checked)
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

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cbbox_tinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void lsNCC_Click(object sender, EventArgs e)
        {
            if (lsNCC.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsNCC.SelectedItems[0];
                tb_mancc.Text = selectedItem.SubItems[0].Text;
                tb_tenncc.Text = selectedItem.SubItems[1].Text;
                tb_diachi.Text = selectedItem.SubItems[2].Text;
                tb_email.Text = selectedItem.SubItems[3].Text;
                tb_trangthai.Text = selectedItem.SubItems[4].Text;
            }
        }

        private void bttn_them_Click(object sender, EventArgs e)
        {
            frmThemNCC form = new frmThemNCC();
            form.FormClosed += FormCon_FormClosed;
            form.ShowDialog();
        }
        public void FormCon_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadNCC();
        }
        private void bttn_sua_Click(object sender, EventArgs e)
        {
            if (lsNCC.SelectedItems.Count > 0)
            {
                string mancc = lsNCC.SelectedItems[0].SubItems[0].Text;
                string tenncc = lsNCC.SelectedItems[0].SubItems[1].Text;
                string diachi = lsNCC.SelectedItems[0].SubItems[2].Text;
                string email = lsNCC.SelectedItems[0].SubItems[3].Text;
                string trangThaiString = lsNCC.SelectedItems[0].SubItems[4].Text;
                bool trangThai = false;
                if (trangThaiString.Equals("Đang Hoạt Động"))
                {
                    trangThai = true;
                }
                NhaCungCap ncc = new NhaCungCap(mancc, tenncc, diachi, email, trangThai);
                frmSuaNCC form = new frmSuaNCC(ncc);
                form.FormClosed += FormCon_FormClosed;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Một Nhà Cung Cấp Để Sửa!");
            }
        }
    }
}
