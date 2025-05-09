﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmSuaNhanVien : Form
    {
        private static String path_anh = "images.jpg";
        private static String duongdananh = "";
        NhanVienBUS bus = new NhanVienBUS();
        private readonly BUS.RoleService _roleService;
        private string _currentRole;

        public frmSuaNhanVien(bool isVisibleBttnSua)
        {
            InitializeComponent();
            _roleService = new BUS.RoleService();
            if (!isVisibleBttnSua)
            {
                btn_CapNhat.Visible = false;
            }
        }
        
        private void thongTinChiTiet_Load(object sender, EventArgs e)
        {
               
        }

        private void rd_dang_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        public event EventHandler btn_CapNhat_Clicked;

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (checkValidForm())
            {
                string selectedRole = cb_role.SelectedItem.ToString();
                if (selectedRole != _currentRole && !_roleService.ValidateRoleAssignment(selectedRole, _currentRole))
                {
                    MessageBox.Show($"Không thể chuyển sang chức vụ {selectedRole}! Kiểm tra lại số lượng nhân viên cho mỗi chức vụ.", 
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_role.SelectedItem = _currentRole;
                    return;
                }

                NhanVienDTO nv = getModel();
                if (bus.updateNhanVien(nv) > 0)
                {
                    String sourcePath = duongdananh;
                    String destinationPath = getPath();
                    int lastBackslash = destinationPath.LastIndexOf('\\');
                    string temp = destinationPath.Substring(lastBackslash + 1);
                    if (sourcePath != destinationPath)
                    {
                        File.Copy(sourcePath, destinationPath, true);
                    }
                    MessageBox.Show("Cập nhật thành công");
                    Onbtn_CapNhat_Clicked();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }
        private void Onbtn_CapNhat_Clicked()
        {
            btn_CapNhat_Clicked?.Invoke(this, EventArgs.Empty);
        }
        private void DisplayImage(string imagePath)
        {
            try
            {
                // Tạo một đối tượng hình ảnh từ đường dẫn tệp
                Image selectedImage = Image.FromFile(imagePath);

                // Hiển thị hình ảnh trong PictureBox
                pictureBox1.Image = selectedImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Có thể điều chỉnh theo ý muốn

                // Có thể cần điều chỉnh kích thước PictureBox để vừa với hình ảnh
                // pictureBox1.Size = selectedImage.Size;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn hình ảnh";
                openFileDialog.Filter = "Tệp hình ảnh|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Tất cả các tệp|*.*";

                // Nếu người dùng chọn một tệp hợp lệ
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn của tệp hình ảnh được chọn
                    string selectedImagePath = openFileDialog.FileName;
                    path_anh = openFileDialog.SafeFileName;
                    duongdananh = selectedImagePath;
                    // Gọi hàm để hiển thị hình ảnh trong PictureBox
                    DisplayImage(selectedImagePath);
                }
                else
                {
                    NhanVienDTO nv = bus.getNhanVienByMa(txt_ma.Text);
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
                    string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
                    string imagePath = Path.Combine(projectDirectory2, "Image", "NhanVien", nv.Img) ;
                    pictureBox1.Image=new Bitmap(imagePath);
                }
            }
        }
        public void setThongTin(NhanVienDTO nv)
        {
            txt_ma.Text = nv.MaNhanVien;
            txt_ma.ReadOnly = true;
            txt_ten.Text = nv.TenNhanVien;
            if (nv.GioiTinh)
            {
                rd_nam.Checked= true;
            }
            else
            {
                rd_nu.Checked = true;
            }
            dp_ngaysinh.Value = nv.NgaySinh;
            txt_diachi.Text = nv.DiaChi;
            txt_sdt.Text = nv.Sdt;
            if (nv.TrangThai)
            {
                rd_dang.Checked = true;
            }else { rd_nghi.Checked = true;}


            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "NhanVien", nv.Img);
            pictureBox1.Image = new Bitmap(imagePath);
            path_anh = nv.Img;
            _currentRole = nv.ChucVu;
            LoadAvailableRoles(_currentRole);
            cb_role.SelectedItem = _currentRole;
            duongdananh = imagePath;
        }
        public NhanVienDTO getModel()
        {
            NhanVienDTO nv = new NhanVienDTO();
            string ten = txt_ten.Text;
            string diaChi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            ten = ten.Trim();
            diaChi = diaChi.Trim();
            sdt = sdt.Trim();
            ten = Regex.Replace(ten, @"\s+", " ");
            diaChi = Regex.Replace(diaChi, @"\s+", " ");
            sdt = Regex.Replace(sdt, @"\s+", " ");
           

            nv.MaNhanVien = txt_ma.Text;
            nv.TenNhanVien = ten;
            if (rd_nam.Checked)
            {
                nv.GioiTinh = true;
            }
            else
            {
                nv.GioiTinh = false;
            }
            nv.NgaySinh = dp_ngaysinh.Value;
            nv.DiaChi = diaChi;
            if (rd_dang.Checked)
            {
                nv.TrangThai = true;
            }
            else
            {
                nv.TrangThai = false;
            }
            nv.ChucVu = cb_role.SelectedItem.ToString();
            nv.Img = path_anh ;
            nv.Sdt = sdt;
            return nv;
        }
        public bool checkValidForm()
        {
            if (txt_ten.Text.Trim().Length == 0 || txt_diachi.Text.Trim().Length == 0 ||/* txt_chucvu.Text.Trim().Length == 0 ||*/ txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsOnlyLetters(txt_ten.Text))
            {
                MessageBox.Show("Tên chỉ được chứa chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(!IsValidAddress(txt_diachi.Text)){
                MessageBox.Show("Độ dài địa chỉ 5 đến 255 và chỉ được chứa chữ cái, số, khoảng trắng, dấu phẩy (,) và dấu gạch chéo (/)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsOnlyDigits(txt_sdt.Text))
            {
                MessageBox.Show("SDT chỉ được chứa số và phải đủ 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (!checkNgaySinh(dp_ngaysinh.Value))
            {
                MessageBox.Show("Tuổi của NV không chính xác. Tuổi không thể <18", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        static bool IsOnlyLetters(string str)
        {
            string pattern = "^[A-Za-zÀ-ỹ ]*$";
            return Regex.IsMatch(str, pattern);
        }
        static bool IsValidAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                return false; // Địa chỉ không được để trống
            }

            if (address.Length < 5 || address.Length > 255)
            {
                return false; // Địa chỉ phải từ 5 đến 255 ký tự
            }

            // Chỉ cho phép chữ cái, số, khoảng trắng, dấu phẩy (,) và dấu gạch chéo (/)
            string pattern = @"^[a-zA-ZÀ-ỹ0-9\s,/]+$";
            if (!Regex.IsMatch(address, pattern))
            {
                return false; // Địa chỉ chứa ký tự không hợp lệ
            }

            return true;
        }
        static bool IsOnlyDigits(string str)
        {
            if (str.Length != 10)
            {
                return false;
            }
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsRoleValid(string str)
        {
            string lowercaseStr = str.ToLower();

            return lowercaseStr == "nhân viên" || lowercaseStr == "quản lý" || lowercaseStr == "thủ thư" || lowercaseStr == "quản lý kho";
        }
        public bool checkNgaySinh(DateTime ngaySinh)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dp_ngaysinh.Value.Year;
            if (dp_ngaysinh.Value.Date > today.AddYears(-age)) age--;
            if (age < 18)
            {
                return false;
            }

            return true;
        }
        private String getPath()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "NhanVien", path_anh);
            return imagePath;
        }

        private void LoadAvailableRoles(string currentRole)
        {
            cb_role.Items.Clear();
            var availableRoles = _roleService.GetAvailableRoles(currentRole);
            availableRoles.Add(currentRole); // Luôn cho phép giữ nguyên role hiện tại
            cb_role.Items.AddRange(availableRoles.Distinct().ToArray());
        }
    }
}
