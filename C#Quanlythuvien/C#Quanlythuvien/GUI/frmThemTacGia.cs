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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThemTacGia : Form
    {
        private String path_anh = "1995571.png";
        private String duongdananh = "";
        TacGiaBus bus=new TacGiaBus();
        public frmThemTacGia()
        {
            InitializeComponent();
            setCungMaTacGia();
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
                    string imagePath = Path.Combine(projectDirectory2, "Image", "TacGia", path_anh);
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

        public void setCungMaTacGia()
        {
            txt_ma.Text = bus.getLastMaTG();
            txt_ma.ReadOnly = true;
        }
        public bool checkValidateForm()
        {
            if (txt_ten.Text.Trim().Length == 0 || richtxt_moTa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsOnlyLetters(txt_ten.Text))
            {
                MessageBox.Show("Tên chỉ được chứa chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public TacGiaDTO getModel()
        {
            TacGiaDTO tg = new TacGiaDTO();
            string ten = txt_ten.Text;
            ten = ten.Trim();
            ten = Regex.Replace(ten, @"\s+", " ");
            string moTa = richtxt_moTa.Text; moTa = moTa.Trim(); moTa = Regex.Replace(moTa, @"\s+", " ");
            tg.MaTG = txt_ma.Text;
            tg.TenTG = ten;
            tg.MoTa = moTa;
            tg.Img = path_anh;
            if (rd_dang.Checked)
            {
                tg.TinhTrang = true;
            }
            else
            {
                tg.TinhTrang = false;
            }

            return tg;
        }
        static bool IsOnlyLetters(string str)
        {
            string pattern = "^[A-Za-zÀ-ỹ ]*$";
            return Regex.IsMatch(str, pattern);
        }
        public event EventHandler resetGUIadd;
        public void OnresetGUIadd()
        {
            resetGUIadd?.Invoke(this, EventArgs.Empty);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (checkValidateForm())
            {
                TacGiaDTO tg = getModel();
                if (bus.insertTG(tg) > 0)
                {
                    String sourcePath = duongdananh;
                    String destinationPath = getPath();
                    int lastBackslash = destinationPath.LastIndexOf('\\');
                    string temp = destinationPath.Substring(lastBackslash + 1);
                    if (sourcePath != destinationPath)
                    {
                        File.Copy(sourcePath, destinationPath, true);
                    }
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnresetGUIadd();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {

            }
        }
        private String getPath()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "TacGia", path_anh);
            return imagePath;
        }
        private void frmThemTacGia_Load(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "TacGia", path_anh);
            pictureBox1.Image = new Bitmap(imagePath);
            duongdananh = imagePath;
        }
    }
}
