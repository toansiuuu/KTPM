using System;
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
using BUS;
using DTO;

namespace GUI
{
    public partial class formThemNhanVien : Form
    {
        NhanVienBUS bus = new NhanVienBUS();
        private readonly BUS.RoleService _roleService;
        private String path_anh = "images.jpg";
        private String duongdananh = "";
        public formThemNhanVien()
        {
            InitializeComponent();
            _roleService = new BUS.RoleService();
            setCungMaNV();
            LoadAvailableRoles();
        }
        public event EventHandler btn_Them_Clicked;
        private void Onbtn_Them_Clicked()
        {
            btn_Them_Clicked?.Invoke(this, EventArgs.Empty);
        }
        private String getPath()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "NhanVien", path_anh);
            return imagePath;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (checkValidForm())
            {
                string selectedRole = cb_role.SelectedItem.ToString();
                if (!_roleService.CanAssignRole(selectedRole))
                {
                    MessageBox.Show($"Không thể thêm nhân viên với chức vụ {selectedRole}! Đã đạt giới hạn số lượng.", 
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                NhanVienDTO nv = getModel();
                if (bus.insertNhanVien(nv) > 0)
                {
                    String sourcePath = duongdananh;
                    String destinationPath = getPath();
                    int lastBackslash = destinationPath.LastIndexOf('\\');
                    string temp = destinationPath.Substring(lastBackslash + 1);
                    if (sourcePath != destinationPath)
                    {
                        File.Copy(sourcePath, destinationPath, true);
                    }
                    MessageBox.Show("Thêm thành công");
                    Onbtn_Them_Clicked();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
        public void displayImage(string imgPath)
        {
            try
            {
                Image img = Image.FromFile(imgPath);
                pictureBox1.Image = img;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex);
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
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
                    string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
                    string imagePath = Path.Combine(projectDirectory2, "Image", "NhanVien", path_anh);
                    DisplayImage(imagePath);
                }
            }

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
        private void formThemNhanVien_Load(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "NhanVien", path_anh);
            pictureBox1.Image=new Bitmap (imagePath);
            duongdananh = imagePath;
        }
        public  void setCungMaNV()
        {
            txt_ma.Text = bus.getLastMaNV();
            txt_ma.ReadOnly = true;
        }
        public NhanVienDTO getModel()
        {
            NhanVienDTO nv = new NhanVienDTO();
            string ten = txt_ten.Text;
            string diaChi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            //string chucVu = txt_chucvu.Text;
            ten = ten.Trim();
            diaChi = diaChi.Trim();
            sdt = sdt.Trim();
           // chucVu = chucVu.Trim();
            ten = Regex.Replace(ten, @"\s+", " ");
            diaChi = Regex.Replace(diaChi, @"\s+", " ");
            sdt = Regex.Replace(sdt, @"\s+", " ");
           // chucVu = Regex.Replace(chucVu, @"\s+", " ");

            nv.MaNhanVien = txt_ma.Text;
            nv.TenNhanVien = ten;
            if(rd_nam.Checked)
            {
                nv.GioiTinh = true;
            }
            else
            {
                nv.GioiTinh=false;
            }
            nv.NgaySinh = dp_ngaysinh.Value;
            nv.DiaChi=diaChi;
            if (rd_dang.Checked)
            {
                nv.TrangThai = true;
            }
            else
            {
                nv.TrangThai = false;
            }
            nv.ChucVu=cb_role.SelectedItem.ToString();
            nv.Img = path_anh;
            nv.Sdt=sdt;
            return nv;
        }
        private bool ValidateAddress(string input)
        {
            // Kiểm tra độ dài
            if (input.Trim().Length < 5 || input.Trim().Length > 255)
            {
                MessageBox.Show("Địa chỉ phải từ 5 đến 255 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra ký tự hợp lệ - chỉ cho phép chữ, số, dấu phẩy (,) và dấu gạch chéo (/)
            string pattern = @"^[a-zA-ZÀ-ỹ0-9\s,/]+$";
            if (!Regex.IsMatch(input.Trim(), pattern))
            {
                MessageBox.Show("Địa chỉ chỉ được chứa chữ, số, dấu phẩy (,) và dấu gạch chéo (/)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool checkValidForm() {
           if(txt_ten.Text.Trim().Length==0 || txt_diachi.Text.Trim().Length==0 || txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra địa chỉ
            if (!ValidateAddress(txt_diachi.Text))
            {
                return false;
            }

            if (!IsOnlyLetters(txt_ten.Text))
            {
                MessageBox.Show("Tên chỉ được chứa chữ","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsOnlyDigits(txt_sdt.Text)){
                MessageBox.Show("SDT chỉ được chứa số và phải đủ 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (bus.isSDTExists(txt_sdt.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            /*
            if (!IsRoleValid(txt_chucvu.Text))
            {
                MessageBox.Show("Phải là 1 trong 4:Nhân viên,Quản lý, Thử thư, Quản lý kho ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            */

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
        static bool IsOnlyDigits(string str)
        {
            // Kiểm tra độ dài phải đúng 10 chữ số
            if (str.Length != 10)
            {
                return false;
            }

            // Kiểm tra ký tự đầu tiên có phải là '0' không
            if (str[0] != '0')
            {
                return false;
            }

            // Kiểm tra tất cả các ký tự có phải là chữ số hay không
            for (int i = 1; i < str.Length; i++)  // Bắt đầu từ index 1 vì đã kiểm tra ký tự đầu
            {
                if (!char.IsDigit(str[i]))
                {
                    return false;
                }
            }

            return true;
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

        private void LoadAvailableRoles()
        {
            cb_role.Items.Clear();
            var availableRoles = _roleService.GetAvailableRoles();
            if (availableRoles.Count == 0)
            {
                MessageBox.Show("Không có chức vụ nào khả dụng!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_them.Enabled = false;
                return;
            }
            cb_role.Items.AddRange(availableRoles.ToArray());
            cb_role.SelectedIndex = 0;
        }
    }
}
