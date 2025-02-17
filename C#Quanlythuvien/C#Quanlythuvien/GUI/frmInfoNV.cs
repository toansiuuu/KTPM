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
    public partial class frmInfoNV : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        public frmInfoNV(string maNV)
        {
            InitializeComponent();
            setThongTin(maNV);
        }
        public void setThongTin(string maNV)
        {
            NhanVienDTO nhanVien = nvBUS.getNhanVienByMa(maNV);
            txt_ma.Text = nhanVien.MaNhanVien;
            txt_ten.Text = nhanVien.TenNhanVien;
            txt_diachi.Text = nhanVien.DiaChi;
            txt_chucvu.Text = nhanVien.ChucVu;
            txt_sdt.Text = nhanVien.Sdt;
            if (!nhanVien.GioiTinh)
            {
                rd_nu.Checked = true;
            }
            dp_ngaysinh.Value = nhanVien.NgaySinh;
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "NhanVien", nhanVien.Img);
            pictureBox1.Image = new Bitmap(imagePath);
        }
    }
}
