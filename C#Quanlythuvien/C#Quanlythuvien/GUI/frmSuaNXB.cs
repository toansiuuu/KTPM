using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSuaNXB : Form
    {
        NhaXuatBan nhaxuatban = null;
        NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();
        public frmSuaNXB()
        {
            InitializeComponent();
        }
        public frmSuaNXB(NhaXuatBan nxb)
        {
            InitializeComponent();
            cb_tinhtrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tinhtrang.SelectedIndex = 0;
            nhaxuatban = nxb;
            tb_maNXB.Text = nhaxuatban.SGMaNXB;
            tb_tenNXB.Text = nhaxuatban.SGTenNXB;
            tb_diachi.Text = nhaxuatban.SGDiaChiNXB;
            tb_Email.Text = nhaxuatban.SGEmailNXB;
            if (nhaxuatban.SGTrangThai)
            {
                cb_tinhtrang.SelectedIndex = 0;
            }
            else
            {
                cb_tinhtrang.SelectedIndex = 1;
            }
        }

        private void bttn_lammoi_Click(object sender, EventArgs e)
        {
            tb_maNXB.Text = nhaxuatban.SGMaNXB;
            tb_tenNXB.Text = nhaxuatban.SGTenNXB;
            tb_diachi.Text = nhaxuatban.SGDiaChiNXB;
            tb_Email.Text = nhaxuatban.SGEmailNXB;
            if (nhaxuatban.SGTrangThai)
            {
                cb_tinhtrang.SelectedIndex = 0;
            }
            else
            {
                cb_tinhtrang.SelectedIndex = 1;
            }
        }
        public bool ValidateTenNXB(string input)
        {
            string pattern = @"^[\p{L}\s']+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
        public bool ValidateEmail(string input)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
        private void bttn_hoanthanh_Click(object sender, EventArgs e)
        {
            if (!ValidateTenNXB(tb_tenNXB.Text))
            {
                MessageBox.Show("Tên Không Đúng Định Dạng!");
                return;
            }
            if (tb_diachi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Địa Chỉ Không Đúng Định Dạng!");
                return;
            }
            if (!ValidateEmail(tb_Email.Text))
            {
                MessageBox.Show("Email Không Đúng Định Dạng!");
                return;
            }
            nhaxuatban.SGTenNXB = tb_tenNXB.Text.Trim();
            nhaxuatban.SGDiaChiNXB= tb_diachi.Text.Trim();
            nhaxuatban.SGEmailNXB = tb_Email.Text.Trim();
            if (cb_tinhtrang.SelectedIndex == 0)
            {
                nhaxuatban.SGTrangThai = true;
            }
            else
            {
                nhaxuatban.SGTrangThai = false;
            }
            if (nxbBUS.fixNXB(nhaxuatban))
            {
                MessageBox.Show("Sửa Thành Công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại!");
            }
        }
    }
}
