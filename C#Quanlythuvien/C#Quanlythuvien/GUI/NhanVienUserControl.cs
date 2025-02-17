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
    public partial class NhanVienUserControl : UserControl
    {

        public NhanVienUserControl()
        {
            InitializeComponent();
            this.Click += thongTin1_Click;


        }
        #region Properties
        private string maNV;
        private string tenNV;
        private string diaChi;
        private string sdt;
        private string icon;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Icon { get => icon; set => icon = value; }

        //[Category("Custom Props")]
        //public string MaNV

        //{ get { return maNV; }
        //    set { maNV = value; }
        //}  

        //[Category("Custom Props")]

        //public string TenNV
        //{
        //    get { return tenNV; }
        //    set { tenNV = value; lbl_ten.Text = value; }
        //}
        //[Category("Custom Props")]

        //public string DiaChi
        //{
        //    get { return diaChi; }
        //    set { diaChi = value; lbl_diachi.Text = value; }
        //}
        //[Category("Custom Props")]

        //public string Sdt
        //{
        //    get { return sdt; }
        //    set { sdt = value; lbl_sdt.Text = value; }
        //}
        //[Category("Custom Props")]

        //public string Icon
        //{
        //    get { return icon; }
        //    set { icon = value; pictureBox1.Image = new Bitmap(value);
        //        ;
        //    }
        //}

        public void setThongTin()
        {
            lbl_diachi.Text = DiaChi;
            lbl_sdt.Text = Sdt;
            lbl_ten.Text = TenNV;

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "NhanVien", icon);
            pictureBox1.Image = new Bitmap(imagePath);
        }


        #endregion
        public event EventHandler ThongTin1Clicked;

        public delegate NhanVienDTO ThongTinClickedDelegate(string maNV);
        public ThongTinClickedDelegate thongTinClickedDelegate;
        private void OnThongTin1Clicked()
        {
            ThongTin1Clicked?.Invoke(this, EventArgs.Empty);
        }

        // Xử lý sự kiện click của thongTin1
        private void thongTin1_Click(object sender, EventArgs e)
        {
            OnThongTin1Clicked();
        }
        private void thongTin1_Load(object sender, EventArgs e)
        {
          
        }

        private void thongTin1_MouseEnter(object sender, EventArgs e)
        {
           
            Color pinkColor = Color.FromArgb(26, 25, 62);
            this.BackColor = pinkColor;
        }

        private void thongTin1_MouseLeave(object sender, EventArgs e)
        {
            Color pinkColor = Color.FromArgb(255, 192, 192);
            this.BackColor = pinkColor;
        }

       
        private void thongTin1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        

    }
}
