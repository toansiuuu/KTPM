using BUS;
using DTO;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class UI_ThuThu : Form
    {
        private IconButton currentBtn;
        private Panel leftBtn;
        private Form currentChildForm;
        public string currentmaNV = "";
        public string currentmaQuyen = "";
        ChucNangBUS cnBUS = new ChucNangBUS();
        ChiTietChucNangBUS ctcnBUS = new ChiTietChucNangBUS();
        List<ChiTietChucNang> ctcnList = new List<ChiTietChucNang>();
        List<String> listCTCN = new List<String>();
        List <ChucNang> listCN = new List<ChucNang>();
        public UI_ThuThu(string maNV, string maQuyen)
        {
            InitializeComponent();
            leftBtn = new Panel();
            leftBtn.Size = new Size(7, 70);
            panel2.Controls.Add(leftBtn);
            currentmaNV = maNV;
            currentmaQuyen = maQuyen;
            listCN = cnBUS.getAllChucNang();
            listCTCN = ctcnBUS.getMaCNbyMaQuyen(currentmaQuyen);
            ctcnList = ctcnBUS.getAllChucNangByMaQuyen(currentmaQuyen);
            //form 
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            LoadAllItem();
        }
        public List<String> getCNList(List<ChucNang> listCN,List<String> listCTCN)
        {
            List<String> list = new List<String>();
            foreach (String item in listCTCN)
            {
                foreach (ChucNang c in listCN)
                {
                    if (item.Equals(c.SGMaCN))
                    {
                        list.Add(c.SGTenCN);
                    }
                }
            }
            return list;
        }
        public void LoadAllItem()
        {
            panel2.Controls.Clear();
            List<String> chucnanglist = getCNList(listCN, listCTCN);
            foreach (String item in chucnanglist)
            {
                LoadItem(item);
            }
        }
        public String getCTCNByMaCNnMaQ(String maCN)
        {
            string str = "";
            foreach (ChiTietChucNang item in ctcnList)
            {
                if (item.SGMaCN.Equals(maCN))
                {
                    str = item.SGChiTiet;
                }
            }
            return str;
        }
        public void LoadItem(String item)
        {
            IconButton iconButton = new IconButton();
            bool flag = false;
            switch (item)
            {
                case "Sách":
                    iconButton.Dock = System.Windows.Forms.DockStyle.Top;
                    iconButton.FlatAppearance.BorderSize = 0;
                    iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    iconButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    iconButton.ForeColor = System.Drawing.Color.White;
                    iconButton.IconChar = FontAwesome.Sharp.IconChar.Book;
                    iconButton.IconColor = System.Drawing.Color.White;
                    iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                    iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.Location = new System.Drawing.Point(0, 0);
                    iconButton.Name = "btnSach";
                    iconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
                    iconButton.Size = new System.Drawing.Size(285, 70);
                    iconButton.TabIndex = 10;
                    iconButton.Text = "Sách";
                    iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    iconButton.UseVisualStyleBackColor = true;
                    iconButton.Click += (object sender, EventArgs e) =>
                    {
                        lbIconChild.Text = "Sách";
                        ActivateButton(sender, RGBColors.color1);
                        OpenFormChild(new GUI_Sach(getCTCNByMaCNnMaQ("CN02"), currentmaQuyen));
                    };
                    break;

                case "Mượn Sách":
                    iconButton.Dock = System.Windows.Forms.DockStyle.Top;
                    iconButton.FlatAppearance.BorderSize = 0;
                    iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    iconButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
                    iconButton.ForeColor = System.Drawing.Color.White;
                    iconButton.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
                    iconButton.IconColor = System.Drawing.Color.White;
                    iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                    iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.Location = new System.Drawing.Point(0, 70);
                    iconButton.Name = "btnPhieumuon";
                    iconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
                    iconButton.Size = new System.Drawing.Size(285, 70);
                    iconButton.TabIndex = 11;
                    iconButton.Text = "Mượn Sách";
                    iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    iconButton.UseVisualStyleBackColor = true;
                    iconButton.Click += (object sender, EventArgs e) =>
                    {
                        lbIconChild.Text = "Phiếu mượn";
                        ActivateButton(sender, RGBColors.color2);
                        OpenFormChild(new GUI_MuonSach(getCTCNByMaCNnMaQ("CN03"),currentmaNV));
                    };
                    break;

                case "Trả Sách":
                    iconButton.Dock = System.Windows.Forms.DockStyle.Top;
                    iconButton.FlatAppearance.BorderSize = 0;
                    iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    iconButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
                    iconButton.ForeColor = System.Drawing.Color.White;
                    iconButton.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
                    iconButton.IconColor = System.Drawing.Color.White;
                    iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                    iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.Location = new System.Drawing.Point(0, 140);
                    iconButton.Name = "btnTrasach";
                    iconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
                    iconButton.Size = new System.Drawing.Size(285, 70);
                    iconButton.TabIndex = 12;
                    iconButton.Text = "Trả Sách";
                    iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    iconButton.UseVisualStyleBackColor = true;
                    iconButton.Click += (object sender, EventArgs e) =>
                    {
                        lbIconChild.Text = "Phiếu trả";
                        ActivateButton(sender, RGBColors.color3);
                        OpenFormChild(new GUI_TraSach(getCTCNByMaCNnMaQ("CN04")));
                    };
                    break;

                case "Nhà Cung Cấp":
                    iconButton.Dock = System.Windows.Forms.DockStyle.Top;
                    iconButton.FlatAppearance.BorderSize = 0;
                    iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    iconButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
                    iconButton.ForeColor = System.Drawing.Color.White;
                    iconButton.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
                    iconButton.IconColor = System.Drawing.Color.White;
                    iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                    iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.Location = new System.Drawing.Point(0, 210);
                    iconButton.Name = "btnNCC";
                    iconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
                    iconButton.Size = new System.Drawing.Size(285, 70);
                    iconButton.TabIndex = 26;
                    iconButton.Text = "Nhà Cung Cấp";
                    iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    iconButton.UseVisualStyleBackColor = true;
                    iconButton.Click += (object sender, EventArgs e) =>
                    {
                        lbIconChild.Text = "Nhà Cung Cấp";
                        ActivateButton(sender, RGBColors.color4);
                        OpenFormChild(new GUI_NCC(getCTCNByMaCNnMaQ("CN08")));
                    };
                    break;
                case "Độc Giả":
                    iconButton.Dock = System.Windows.Forms.DockStyle.Top;
                    iconButton.FlatAppearance.BorderSize = 0;
                    iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    iconButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
                    iconButton.ForeColor = System.Drawing.Color.White;
                    iconButton.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
                    iconButton.IconColor = System.Drawing.Color.White;
                    iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                    iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.Location = new System.Drawing.Point(0, 280);
                    iconButton.Name = "btnDocGia";
                    iconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
                    iconButton.Size = new System.Drawing.Size(285, 70);
                    iconButton.TabIndex = 27;
                    iconButton.Text = "Độc Giả";
                    iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    iconButton.UseVisualStyleBackColor = true;
                    iconButton.Click += (object sender, EventArgs e) =>
                    {
                        lbIconChild.Text = "Độc Giả";
                        ActivateButton(sender, RGBColors.color7);
                        OpenFormChild(new GUI_DocGia(getCTCNByMaCNnMaQ("CN01")));
                    };
                    break;

                case "Nhân Viên":
                    iconButton.Dock = System.Windows.Forms.DockStyle.Top;
                    iconButton.FlatAppearance.BorderSize = 0;
                    iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    iconButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
                    iconButton.ForeColor = System.Drawing.Color.White;
                    iconButton.IconChar = FontAwesome.Sharp.IconChar.UserTie;
                    iconButton.IconColor = System.Drawing.Color.White;
                    iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                    iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.Location = new System.Drawing.Point(0, 350);
                    iconButton.Name = "btnNhanVien";
                    iconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
                    iconButton.Size = new System.Drawing.Size(285, 70);
                    iconButton.TabIndex = 28;
                    iconButton.Text = "Nhân Viên";
                    iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    iconButton.UseVisualStyleBackColor = true;
                    iconButton.Click += (object sender, EventArgs e) =>
                    {
                        lbIconChild.Text = "Nhân Viên";
                        ActivateButton(sender, RGBColors.color8);
                        OpenFormChild(new GUI_NhanVien(getCTCNByMaCNnMaQ("CN11")));
                    };
                    break;

                case "Nhập Hàng":
                    iconButton.Dock = System.Windows.Forms.DockStyle.Top;
                    iconButton.FlatAppearance.BorderSize = 0;
                    iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    iconButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
                    iconButton.ForeColor = System.Drawing.Color.White;
                    iconButton.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
                    iconButton.IconColor = System.Drawing.Color.White;
                    iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                    iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.Location = new System.Drawing.Point(0, 560);
                    iconButton.Name = "btnNhapHang";
                    iconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
                    iconButton.Size = new System.Drawing.Size(285, 70);
                    iconButton.TabIndex = 31;
                    iconButton.Text = "Nhập Hàng";
                    iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    iconButton.UseVisualStyleBackColor = true;
                    iconButton.Click += (object sender, EventArgs e) =>
                    {
                        lbIconChild.Text = "Nhập Hàng";
                        ActivateButton(sender, RGBColors.color11);
                        OpenFormChild(new GUI_NhapHang(getCTCNByMaCNnMaQ("CN07"),currentmaNV));
                    };
                    break;

                case "Phân Quyền":
                    iconButton.Dock = System.Windows.Forms.DockStyle.Top;
                    iconButton.FlatAppearance.BorderSize = 0;
                    iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    iconButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
                    iconButton.ForeColor = System.Drawing.Color.White;
                    iconButton.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
                    iconButton.IconColor = System.Drawing.Color.White;
                    iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                    iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.Location = new System.Drawing.Point(0, 490);
                    iconButton.Name = "btnPhanQuyen";
                    iconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
                    iconButton.Size = new System.Drawing.Size(285, 70);
                    iconButton.TabIndex = 30;
                    iconButton.Text = "Phân Quyền";
                    iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    iconButton.UseVisualStyleBackColor = true;
                    iconButton.Click += (object sender, EventArgs e) =>
                    {
                        lbIconChild.Text = "Phân Quyền";
                        ActivateButton(sender, RGBColors.color10);
                        OpenFormChild(new GUI_PhanQuyen(getCTCNByMaCNnMaQ("CN06")));
                    };
                    break;

                case "Tài Khoản":
                    iconButton.Dock = System.Windows.Forms.DockStyle.Top;
                    iconButton.FlatAppearance.BorderSize = 0;
                    iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    iconButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
                    iconButton.ForeColor = System.Drawing.Color.White;
                    iconButton.IconChar = FontAwesome.Sharp.IconChar.Users;
                    iconButton.IconColor = System.Drawing.Color.White;
                    iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                    iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.Location = new System.Drawing.Point(0, 420);
                    iconButton.Name = "btnTaiKhoan";
                    iconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
                    iconButton.Size = new System.Drawing.Size(285, 70);
                    iconButton.TabIndex = 29;
                    iconButton.Text = "Tài Khoản";
                    iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    iconButton.UseVisualStyleBackColor = true;
                    iconButton.Click += (object sender, EventArgs e) =>
                    {
                        lbIconChild.Text = "Tài Khoản";
                        ActivateButton(sender, RGBColors.color9);
                        OpenFormChild(new GUI_TaiKhoan(getCTCNByMaCNnMaQ("CN05")));
                    };
                    break;
                case "Thống Kê":
                    iconButton.Dock = System.Windows.Forms.DockStyle.Top;
                    iconButton.FlatAppearance.BorderSize = 0;
                    iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    iconButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
                    iconButton.ForeColor = System.Drawing.Color.White;
                    iconButton.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
                    iconButton.IconColor = System.Drawing.Color.White;
                    iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                    iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.Location = new System.Drawing.Point(0, 630);
                    iconButton.Name = "btnThongKe";
                    iconButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
                    iconButton.Size = new System.Drawing.Size(264, 70);
                    iconButton.TabIndex = 32;
                    iconButton.Text = "Thống Kê";
                    iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    iconButton.UseVisualStyleBackColor = true;
                    iconButton.Click += (object sender, EventArgs e) =>
                    {
                        lbIconChild.Text = "Thống Kê";
                        ActivateButton(sender, RGBColors.color12);
                        OpenFormChild(new GUI_ThongKe());
                    };
                    break;
                default: 
                    flag = true; 
                    break;
            }
            if (!flag)
            {
                this.panel2.Controls.Add(iconButton);
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(0, 255, 0);
            public static Color color8 = Color.FromArgb(255, 255, 0);
            public static Color color9 = Color.FromArgb(153, 51, 255);
            public static Color color10 = Color.FromArgb(255, 51, 51);
            public static Color color11 = Color.FromArgb(0, 255, 255);
            public static Color color12 = Color.FromArgb(146, 216, 0);
        }

        private void OpenFormChild(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left boder button
                leftBtn.BackColor = color;
                leftBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBtn.Visible = true;
                leftBtn.BringToFront();

                //icon Current Child
                iconCurrentChild.IconChar = currentBtn.IconChar;
                iconCurrentChild.IconColor = color;
            }
        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBtn.Visible = false;
            iconCurrentChild.IconChar = IconChar.Home;
            iconCurrentChild.IconColor = Color.MediumPurple;
            lbIconChild.Text = "Home";
        }

        private void UI_ThuThu_Load(object sender, EventArgs e)
        {
            
        }


        

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null && currentChildForm.IsHandleCreated)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximumBtn_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            } else WindowState = FormWindowState.Normal;
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Sách";
            ActivateButton(sender, RGBColors.color1);
            OpenFormChild(new GUI_Sach());
        }

        private void btnPhieumuon_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Phiếu mượn";
            ActivateButton(sender, RGBColors.color2);
            OpenFormChild(new GUI_MuonSach());

        }

        private void btnTrasach_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Phiếu trả";
            ActivateButton(sender, RGBColors.color3);
            OpenFormChild(new GUI_TraSach());
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Nhà Cung Cấp";
            ActivateButton(sender, RGBColors.color4);
            OpenFormChild(new GUI_NCC());
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Độc Giả";
            ActivateButton(sender, RGBColors.color7);
            OpenFormChild(new GUI_DocGia());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Nhân Viên";
            ActivateButton(sender, RGBColors.color8);
            OpenFormChild(new GUI_NhanVien());

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Tài Khoản";
            ActivateButton(sender, RGBColors.color9);
            OpenFormChild(new GUI_TaiKhoan());
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Phân Quyền";
            ActivateButton(sender, RGBColors.color10);
            OpenFormChild(new GUI_PhanQuyen());
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Nhập Hàng";
            ActivateButton(sender, RGBColors.color11);
            OpenFormChild(new GUI_NhapHang());
        }
        //drag
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool isCollapsed = true;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panel_dropDown.Width += 10;
                if(panel_dropDown.Size==panel_dropDown.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel_dropDown.Width -= 10;
                if (panel_dropDown.Size == panel_dropDown.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void lbl_thongTin_Click(object sender, EventArgs e)
        {
            new frmInfoNV(currentmaNV).ShowDialog();
        }

        private void label_dangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
                new Login().Show();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            lbIconChild.Text = "Thống Kê";
            ActivateButton(sender, RGBColors.color12);
            OpenFormChild(new GUI_ThongKe());
        }

        
    }
}
