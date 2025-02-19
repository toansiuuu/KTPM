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
    public partial class frmSuaNCC : Form
    {
        NhaCungCap nhacungcap = null;
        NhaCungCapBUS nccbBUS = new NhaCungCapBUS();
        public frmSuaNCC()
        {
            InitializeComponent();
        }
        public frmSuaNCC(NhaCungCap ncc)
        {
            InitializeComponent();
            cb_tinhtrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tinhtrang.SelectedIndex = 0;
            nhacungcap = ncc;
            tb_maNCC.Text = nhacungcap.SGMaNCC;
            tb_tenNCC.Text = nhacungcap.SGTenNCC;
            tb_diachi.Text = nhacungcap.SGDiaChi;
            tb_Email.Text = nhacungcap.SGEmail;
            if (nhacungcap.SGTrangThai)
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
            tb_maNCC.Text = nhacungcap.SGMaNCC;
            tb_tenNCC.Text = nhacungcap.SGTenNCC;
            tb_diachi.Text = nhacungcap.SGDiaChi;
            tb_Email.Text = nhacungcap.SGEmail;
            if (nhacungcap.SGTrangThai)
            {
                cb_tinhtrang.SelectedIndex = 0;
            }
            else
            {
                cb_tinhtrang.SelectedIndex = 1;
            }
        }
        public bool ValidateTenNCC(string input)
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
        public bool ValidateAddress(string input)
        {
            // Kiểm tra độ dài
            if (input.Trim().Length < 5 || input.Trim().Length > 255)
            {
                MessageBox.Show("Địa chỉ phải từ 5 đến 255 ký tự!");
                return false;
            }

            // Kiểm tra ký tự hợp lệ
            string pattern = @"^[a-zA-ZÀ-ỹ0-9\s,/#]+$";
            if (!Regex.IsMatch(input.Trim(), pattern))
            {
                MessageBox.Show("Địa chỉ chỉ được chứa chữ, số, dấu phẩy, khoảng trắng, dấu / và #!");
                return false;
            }
            return true;
        }

        private void bttn_hoanthanh_Click(object sender, EventArgs e)
        {
            if (!ValidateTenNCC(tb_tenNCC.Text))
            {
                MessageBox.Show("Tên Không Đúng Định Dạng!");
                return;
            }
            if (!ValidateAddress(tb_diachi.Text))
            {
                return; // Thông báo lỗi đã được hiển thị trong ValidateAddress
            }
            if (!ValidateEmail(tb_Email.Text))
            {
                MessageBox.Show("Email Không Đúng Định Dạng!");
                return;
            }
            nhacungcap.SGTenNCC = tb_tenNCC.Text.Trim();
            nhacungcap.SGDiaChi = tb_diachi.Text.Trim();
            nhacungcap.SGEmail = tb_Email.Text.Trim();
            if (cb_tinhtrang.SelectedIndex == 0)
            {
                nhacungcap.SGTrangThai = true;
            }
            else
            {
                nhacungcap.SGTrangThai = false;
            }
            if (nccbBUS.updateNhaCungCap(nhacungcap) > 0)
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
