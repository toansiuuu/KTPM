using FontAwesome.Sharp;
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
    public partial class TacGiaUserControl : UserControl
    {
        public TacGiaUserControl()
        {
            InitializeComponent();
        }
        string maTG;
        string tenTG;
        string moTa;
        bool tinhTrang;
        string img;

        public string MaTG { get => maTG; set => maTG = value; }
        public string TenTG { get => tenTG; set => tenTG = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string Img { get => img; set => img = value; }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void setThongTin()
        {
            lbl_ma.Text = this.maTG;
            lbl_ten.Text = this.tenTG;
            if(tinhTrang)
            {
                lbl_trangThai.Text = "Đang hoạt động";

            }
            else
            {
                lbl_trangThai.Text = "Ngừng hoạt động";
            }
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "TacGia", this.img);
            pictureBox1.Image = new Bitmap(imagePath);
        }
        public event EventHandler clickThongTin;
        public void OnClickThongTin()
        {
            clickThongTin?.Invoke(this, EventArgs.Empty);
        }

        private void TacGiaUserControl_Click(object sender, EventArgs e)
        {
            OnClickThongTin();
        }

        private void TacGiaUserControl_MouseEnter(object sender, EventArgs e)
        {
            Color pinkColor = Color.FromArgb(26, 25, 62);
            this.BackColor = pinkColor;
        }

        private void TacGiaUserControl_Load(object sender, EventArgs e)
        {

        }

        private void TacGiaUserControl_MouseLeave(object sender, EventArgs e)
        {
            Color pinkColor = Color.FromArgb(255, 192, 192);
            this.BackColor = pinkColor;
        }
    }
}
