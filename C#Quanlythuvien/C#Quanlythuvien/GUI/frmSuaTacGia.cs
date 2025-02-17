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

    public partial class frmSuaTacGia : Form
    {
        private static String path_anh = "images.jpg";
        private static String duongdananh = "";
        TacGiaBus bus=new TacGiaBus();
        public frmSuaTacGia(bool isVisibleFix)
        {
            InitializeComponent();
            if (!isVisibleFix)
            {
                btn_CapNhat.Visible = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSuaTacGia_Load(object sender, EventArgs e)
        {
        }
        public void setThongTin(TacGiaDTO tg)
        {
            
            txt_ma.Text = tg.MaTG;
            txt_ma.ReadOnly= true;
            txt_ten.Text = tg.TenTG;
            if (tg.TinhTrang)
            {
                rd_dang.Checked= true;
            }
            else
            {
                rd_dung.Checked= true;
            }
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "TacGia", tg.Img);
            pictureBox1.Image = new Bitmap(imagePath);
            path_anh=tg.Img;
            duongdananh = imagePath;
            richtxt_moTa.Text = tg.MoTa;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                    TacGiaDTO tg = bus.getTacGiaByMa(txt_ma.Text);
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
                    string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
                    string imagePath = Path.Combine(projectDirectory2, "Image", "TacGia", tg.Img);
                    pictureBox1.Image = new Bitmap(imagePath);
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
        public event EventHandler resetGUI;
        public void OnresetGUI()
        {
            resetGUI?.Invoke(this, EventArgs.Empty);

        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (checkValidateForm())
            {
                TacGiaDTO tg = getModel();
                if (bus.updateTacGia(tg) > 0)
                {
                    String sourcePath = duongdananh;
                    String destinationPath = getPath();
                    int lastBackslash = destinationPath.LastIndexOf('\\');
                    string temp = destinationPath.Substring(lastBackslash + 1);
                    if (sourcePath != destinationPath)
                    {
                        File.Copy(sourcePath, destinationPath, true);
                    }
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnresetGUI();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        public bool checkValidateForm()
        {
            if (txt_ten.Text.Trim().Length == 0|| richtxt_moTa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsOnlyLetters(txt_ten.Text)){
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
            if(rd_dang.Checked)
            {
                tg.TinhTrang = true;
            }
            else
            {
                tg.TinhTrang=false;
            }
            return tg;
        }
        static bool IsOnlyLetters(string str)
        {
            string pattern = "^[A-Za-zÀ-ỹ ]*$";
            return Regex.IsMatch(str, pattern);
        }

    }
}
