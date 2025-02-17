using System;
using BUS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class GUI_TaiKhoan : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        DataTable dt;
        public GUI_TaiKhoan()
        {
            InitializeComponent();
            SetUpListView();
            LoadTK();
            rdo_maNV.Checked = true;
            cbbox_tinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_tinhTrang.SelectedIndex = 0;
            cb_taikhoan.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_taikhoan.SelectedIndex = 0;
            cb_ChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ChucVu.SelectedIndex = 0;
        }
        public GUI_TaiKhoan(String chiTiet)
        {
            InitializeComponent();
            SetUpListView();
            LoadTK();
            rdo_maNV.Checked = true;
            cbbox_tinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_tinhTrang.SelectedIndex = 0;
            cb_taikhoan.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_taikhoan.SelectedIndex = 0;
            cb_ChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ChucVu.SelectedIndex = 0;
            SetUpAccessPermissions(chiTiet);
        }
        public void SetUpAccessPermissions(String chiTiet)
        {
            if (chiTiet.Trim().Equals(""))
            {
                bttn_gan.Visible = false;
                bttn_khoa.Visible = false;
                bttn_mo.Visible = false;
            }
            else
            {
                if (!chiTiet.Contains("Sửa"))
                {
                    bttn_khoa.Visible = false;
                    bttn_mo.Visible = false;
                }
                if (!chiTiet.Contains("Gán"))
                {
                    bttn_gan.Visible = false;
                }
            }
        }
        public void SetUpListView()
        {
            lsTK.Columns[0].Width = 0;
            lsTK.Columns[1].Width = (int)(lsTK.Width * 0.16);
            lsTK.Columns[2].Width = (int)(lsTK.Width * 0.16);
            lsTK.Columns[3].Width = (int)(lsTK.Width * 0.16);
            lsTK.Columns[4].Width = (int)(lsTK.Width * 0.16);
            lsTK.Columns[5].Width = (int)(lsTK.Width * 0.16);
            lsTK.Columns[6].Width = (int)(lsTK.Width * 0.16);
            lsTK.View = View.Details;
            lsTK.GridLines = true;
            lsTK.FullRowSelect = true;
        }
        public void LoadTK()
        {
            lsTK.Items.Clear();
            dt = tkBUS.getAllTaiKhoanDataTable();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsTK.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                string matkhau = dt.Rows[i][4].ToString();
                string hidemk = "";
                for ( int j = 0;j < matkhau.Length; j++ )
                {
                    hidemk += "*";
                }
                lvi.SubItems.Add(hidemk);
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                string trangThai = "";
                if (dt.Rows[i][6] == DBNull.Value)
                {
                    trangThai = "";
                }
                else
                {
                    trangThai = Convert.ToBoolean(dt.Rows[i][6]) ? "Mở" : "Khóa";
                }
                lvi.SubItems.Add(trangThai);
            }
        }
        public void Filter()
        {
            lsTK.Items.Clear();
            dt = tkBUS.getAllTaiKhoanDataTable();
            FilterSearch();
            FilterStatus();
            FilterChucVu();
            FilterTaiKhoan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsTK.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                string matkhau = dt.Rows[i][4].ToString();
                string hidemk = "";
                for (int j = 0; j < matkhau.Length; j++)
                {
                    hidemk += "*";
                }
                lvi.SubItems.Add(hidemk);
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                string trangThai = "";
                if (dt.Rows[i][6] == DBNull.Value)
                {
                    trangThai = "";
                }
                else
                {
                    trangThai = Convert.ToBoolean(dt.Rows[i][6]) ? "Mở" : "Khóa";
                }
                lvi.SubItems.Add(trangThai);
            }
        }
        public void FilterSearch()
        {
            if (tb_timkiem.Text.Length != 0)
            {
                if (rdo_maNV.Checked)
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
                else if (rdo_tenNV.Checked)
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
                    if (Convert.ToString(dt.Rows[i][3]).Trim().Equals(""))
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
                    if (!Convert.ToString(dt.Rows[i][3]).Trim().Equals(""))
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
        public void FilterChucVu()
        {
            if (cb_ChucVu.SelectedIndex == 1)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToString(dt.Rows[i][2]).Trim().Equals("Quản Lý"))
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (cb_ChucVu.SelectedIndex == 2)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToString(dt.Rows[i][2]).Trim().Equals("Quản Trị Viên"))
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (cb_ChucVu.SelectedIndex == 3)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToString(dt.Rows[i][2]).Trim().Equals("Nhân Viên Kho"))
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (cb_ChucVu.SelectedIndex == 4)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToString(dt.Rows[i][2]).Trim().Equals("Thủ Thư"))
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
        public void FilterTaiKhoan()
        {
            if (cb_taikhoan.SelectedIndex == 1)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string trangThai = dt.Rows[i][6] == DBNull.Value? "": Convert.ToBoolean(dt.Rows[i][6]) ? "Mở" : "Khóa";
                    if (!Convert.ToString(trangThai).Trim().Equals("Mở"))
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (cb_taikhoan.SelectedIndex == 2)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string trangThai = dt.Rows[i][6] == DBNull.Value ? "" : Convert.ToBoolean(dt.Rows[i][6]) ? "Mở" : "Khóa";
                    if (!Convert.ToString(trangThai).Trim().Equals("Khóa"))
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

        private void cb_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cb_taikhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
        public void setDefault()
        {
            rdo_maNV.Checked = true;
            tb_timkiem.Text = "";
            cb_ChucVu.SelectedIndex = 0;
            cb_taikhoan.SelectedIndex = 0;
            cbbox_tinhTrang.SelectedIndex = 0;
            LoadTK();
        }
        private void bttn_khoa_Click(object sender, EventArgs e)
        {
            if (lsTK.SelectedItems.Count > 0)
            {
                if (lsTK.SelectedItems[0].SubItems[3].Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tài Khoản Chưa Được Cấp!");
                }
                else
                {
                    if (lsTK.SelectedItems[0].SubItems[6].Text.Trim().Equals("Khóa"))
                    {
                        MessageBox.Show("Tài Khoản Đã Được Khóa!");
                    }
                    else
                    {
                        tkBUS.updateTTTaiKhoan(lsTK.SelectedItems[0].SubItems[3].Text, false);
                        MessageBox.Show("Khóa Tài Khoản Thành Công!");
                        setDefault();
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn Một Tài Khoản Để Khóa!");
            }
        }

        private void bttn_mo_Click(object sender, EventArgs e)
        {
            if (lsTK.SelectedItems.Count > 0)
            {
                if (lsTK.SelectedItems[0].SubItems[3].Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tài Khoản Chưa Được Cấp!");
                }
                else
                {
                    if (lsTK.SelectedItems[0].SubItems[6].Text.Trim().Equals("Mở"))
                    {
                        MessageBox.Show("Tài Khoản Đang Được Mở!");
                    }
                    else
                    {
                        tkBUS.updateTTTaiKhoan(lsTK.SelectedItems[0].SubItems[3].Text, true);
                        MessageBox.Show("Mở Khóa Tài Khoản Thành Công!");
                        setDefault();
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn Một Tài Khoản Để Mở Khóa!");
            }
        }

        private void bttn_gan_Click(object sender, EventArgs e)
        {
            if (lsTK.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsTK.SelectedItems[0];
                frmGanQuyen form = new frmGanQuyen(selectedItem.SubItems[3].Text, selectedItem.SubItems[2].Text, selectedItem.SubItems[5].Text, selectedItem.SubItems[0].Text);
                form.FormClosed += FormCon_FormClosed;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn Một Tài Khoản Để Gán Quyền!");
            }
        }
        public void FormCon_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTK();
        }
    }
}
