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
    public partial class frmThemNCC : Form
    {
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        public frmThemNCC()
        {
            InitializeComponent();
            tb_maNCC.Text = nccBUS.getLastMaNCC();
        }

        private void bttn_lammoi_Click(object sender, EventArgs e)
        {
            tb_tenNCC.Text = "";
            tb_diachi.Text = "";
            tb_Email.Text = "";
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
            if (nccBUS.isTenNCCExists(tb_tenNCC.Text))
            {
                MessageBox.Show("Tên Nhà Cung Cấp Đã Tồn Tại!");
                return;
            }
            NhaCungCap ncc = new NhaCungCap(tb_maNCC.Text, tb_tenNCC.Text, tb_diachi.Text, tb_Email.Text, true);
            if (nccBUS.insertNhaCungCap(ncc) > 0)
            {
                MessageBox.Show("Thêm Thành Công!");
                tb_tenNCC.Text = "";
                tb_diachi.Text = "";
                tb_Email.Text = "";
                tb_maNCC.Text = nccBUS.getLastMaNCC();
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại!");
            }
        }

        
        
    }
}
