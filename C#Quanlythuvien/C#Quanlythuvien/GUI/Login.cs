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
    public partial class Login : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        List<TaiKhoan> listTK = new List<TaiKhoan>();
        List<NhanVienDTO> listNV = new List<NhanVienDTO>();
        public Login()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
            listTK = tkBUS.getALLTaiKhoan();
            listNV = nvBUS.getAllNhanVien();
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(109, 107, 153);
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(131, 117, 220);
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(109, 107, 153);
            if (txtPass.Text == "")
            {
                txtPass.PasswordChar = '\0';
                txtPass.Text = "Password";
            }
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(131, 117, 220);
            if (txtPass.Text == "Password")
            {
                txtPass.PasswordChar = '●';
                txtPass.Text = "";
            }
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(109, 107, 153);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(58, 52, 95);
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(109, 107, 153);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(58, 52, 95);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        public bool isExitTK(String username)
        {
            bool flag = false;
            foreach (TaiKhoan tk in listTK)
            {
                if (username.Equals(tk.SGTenDangNhap.Trim().ToLower()))
                {
                    flag = true;
                }
            }
            return flag;
        }
        public bool isCorrectPwd(String username, String pwd)
        {
            bool flag = false;
            foreach (TaiKhoan tk in listTK)
            {
                if (username.Equals(tk.SGTenDangNhap.Trim().ToLower())
                    && tk.SGMatKhau.Equals(pwd))
                {
                    flag = true;
                }
            }
            return flag;
        }
        public bool isLockNV(String maNV)
        {
            bool flag = false;
            foreach (NhanVienDTO nv in listNV)
            {
                if (maNV.Equals(nv.MaNhanVien.Trim().ToLower())
                    && !nv.TrangThai)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public bool isLock(String username)
        {
            bool flag = false;
            foreach (TaiKhoan tk in listTK)
            {
                if (username.Equals(tk.SGTenDangNhap.Trim().ToLower()))
                {
                    if (!tk.SgTrangThai || isLockNV(username))
                    {
                        flag = true;
                    }
                }
            }
            return flag;
        }
        public void SetUp(String username)
        {
            string maNV = "";
            string maQuyen = "";
            foreach (TaiKhoan tk in listTK)
            {
                if (username.Equals(tk.SGTenDangNhap.Trim().ToLower()))
                {
                    maQuyen = tk.SGMaQuyen;
                }
            }
            foreach (NhanVienDTO nv in listNV)
            {
                if (username.Equals(nv.MaNhanVien.Trim().ToLower()))
                {
                    maNV = nv.MaNhanVien;
                }
            }
            UI_ThuThu newForm = new UI_ThuThu(maNV,maQuyen);
            newForm.Show(this);
            this.Hide();
        }
        private void bttn_Login_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Equals("") || txtUsername.Text.Equals("Username"))
            {
                MessageBox.Show("Vui Lòng Nhập Vào Tài Khoản!");
                return;
            }
            if (!isExitTK(txtUsername.Text.Trim().ToLower()))
            {
                MessageBox.Show("Tài Khoản Không Tồn Tại!");
                return;
            }
            if (txtPass.Text.Equals("") || txtPass.Text.Equals("Password"))
            {
                MessageBox.Show("Vui Lòng Nhập Vào Mật Khẩu!");
                return;
            }
            if (!isCorrectPwd(txtUsername.Text.Trim().ToLower(), txtPass.Text))
            {
                MessageBox.Show("Sai Mật Khẩu!");
                return;
            }
            if (isLock(txtUsername.Text.Trim().ToLower()))
            {
                MessageBox.Show("Tài Khoản Đã Bị Khóa Hoặc Nhân Viên Đang Trong Trạng Thái Ngừng Hoạt Động!");
                return;
            }
            SetUp(txtUsername.Text.Trim().ToLower());
        }
    }
}
