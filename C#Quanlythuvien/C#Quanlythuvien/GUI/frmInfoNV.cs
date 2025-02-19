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

            // Set thông tin và disable các controls
            txt_ma.Text = nhanVien.MaNhanVien;
            txt_ma.ReadOnly = true;

            txt_ten.Text = nhanVien.TenNhanVien;
            txt_ten.ReadOnly = true;

            txt_diachi.Text = nhanVien.DiaChi;
            txt_diachi.ReadOnly = true;

            txt_chucvu.Text = nhanVien.ChucVu;
            txt_chucvu.ReadOnly = true;

            txt_sdt.Text = nhanVien.Sdt;
            txt_sdt.ReadOnly = true;

            // Hiển thị ngày sinh dạng text
            txt_ngaysinh.Text = nhanVien.NgaySinh.ToString("dd/MM/yyyy");

            // Disable radio buttons
            rd_nam.Enabled = false;
            rd_nu.Enabled = false;

            if (!nhanVien.GioiTinh)
            {
                rd_nu.Checked = true;
            }
            else
            {
                rd_nam.Checked = true;
            }

            // Load ảnh
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "NhanVien", nhanVien.Img);
            pictureBox1.Image = new Bitmap(imagePath);
        }
    }
}
