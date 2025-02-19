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
    public partial class frmCapTaiKhoan : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        private string maNV;

        public frmCapTaiKhoan(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            LoadThongTinNhanVien();
            txt_matKhau.PasswordChar = '*';
            txt_matKhau.MaxLength = 20;
            txt_tenDangNhap.MaxLength = 20;
        }

        private void LoadThongTinNhanVien()
        {
            NhanVienDTO nv = tkBUS.getInFoNVByMa(maNV);
            if (nv != null)
            {
                txt_maNV.Text = nv.MaNhanVien;
                txt_tenNV.Text = nv.TenNhanVien;
                txt_chucvu.Text = nv.ChucVu;
                
                // Set tên đăng nhập mặc định là mã nhân viên
                txt_tenDangNhap.Text = nv.MaNhanVien;
                txt_tenDangNhap.ReadOnly = true; // Không cho phép sửa tên đăng nhập
            }
        }

        private void btn_capTK_Click(object sender, EventArgs e)
        {
            if (checkValidForm())
            {
                string tenDangNhap = maNV;
                string matKhau = txt_matKhau.Text.Trim();
                string maQuyen = GetMaQuyenByChucVu(txt_chucvu.Text);

                // Kiểm tra tên đăng nhập đã tồn tại chưa
                if (tkBUS.KiemTraTenDangNhap(tenDangNhap))
                {
                    MessageBox.Show("Nhân viên đã có tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TaiKhoan tk = new TaiKhoan(tenDangNhap, matKhau, maQuyen, true);
                
                if (tkBUS.insertTaiKhoan(tk) > 0)
                {
                    MessageBox.Show("Cấp tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cấp tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool checkValidForm()
        {
            if (string.IsNullOrWhiteSpace(txt_tenDangNhap.Text) || string.IsNullOrWhiteSpace(txt_matKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidUsername(txt_tenDangNhap.Text))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ! Chỉ được chứa chữ cái, số và dấu gạch dưới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_matKhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPassword(txt_matKhau.Text))
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất 1 chữ cái viết hoa, 1 chữ cái viết thường và 1 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidUsername(string username)
        {
            string pattern = "^[a-zA-Z0-9_]+$";
            return Regex.IsMatch(username, pattern);
        }

        private bool IsValidPassword(string password)
        {
            // Kiểm tra có ít nhất 1 chữ cái viết hoa
            bool hasUpperCase = password.Any(char.IsUpper);
            // Kiểm tra có ít nhất 1 chữ cái viết thường
            bool hasLowerCase = password.Any(char.IsLower);
            // Kiểm tra có ít nhất 1 số
            bool hasNumber = password.Any(char.IsDigit);

            return hasUpperCase && hasLowerCase && hasNumber;
        }

        private string GetMaQuyenByChucVu(string chucVu)
        {
            // Chuẩn hóa chuỗi chức vụ
            chucVu = chucVu.Trim();
            string maQuyen = "";
            
            // Chuẩn hóa chuỗi để so sánh
            chucVu = chucVu.ToLower().Replace(" ", "");
            
            switch (chucVu)
            {
                case "quanlý":
                case "quanly":
                    maQuyen = "Q01";
                    break;
                case "quảntrịviên":
                case "quantrivien":
                    maQuyen = "Q02";
                    break;
                case "nhânviênkho":
                case "nhanvienkho":
                    maQuyen = "Q03";
                    break;
                case "thủthư":
                case "thuthu":
                    maQuyen = "Q04";
                    break;
                default:
                    MessageBox.Show($"Chức vụ không hợp lệ: '{chucVu}'\nCác chức vụ hợp lệ: Quản lý, Quản trị viên, Nhân viên kho, Thủ thư", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
            }

            return maQuyen;
        }
    }
} 
