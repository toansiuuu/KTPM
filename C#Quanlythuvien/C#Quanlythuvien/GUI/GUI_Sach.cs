using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class GUI_Sach : Form
    {
        public TuaSachBUS ts_BUS = new TuaSachBUS();
        private TheLoaiBUS tl_BUS = new TheLoaiBUS();
        private ChiTietTheLoaiBUS cttl_BUS = new ChiTietTheLoaiBUS();
        private TacGiaBus tg_BUS = new TacGiaBus();
        string name = "Muon sach";


        ChiTietChucNangBUS ctcnBUS = new ChiTietChucNangBUS();
        List<ChiTietChucNang> ctcnList = new List<ChiTietChucNang>();
        public GUI_Sach()
        {
            InitializeComponent();
            cbTimkiem.SelectedIndex = 0;
        }
        public GUI_Sach(String chiTiet, String currentmaQuyen)
        {
            InitializeComponent();
            cbTimkiem.SelectedIndex = 0;
            ctcnList = ctcnBUS.getAllChucNangByMaQuyen(currentmaQuyen);
            SetUpAccessPermissions(chiTiet);
            SetUpAccessPermissionsChildren();
        }
        public bool isVisibleChangeStatus = true;
        public bool isVisibleAddBook = true;
        public bool isVisibleFixBook = true;
        public void SetUpAccessPermissions(String chiTiet)
        {
            if (chiTiet.Trim().Equals(""))
            {
                isVisibleChangeStatus = false;
                isVisibleAddBook = false;
                isVisibleFixBook = false;
            }
            else
            {
                if (!chiTiet.Contains("Thêm"))
                {
                    isVisibleAddBook = false;
                }
                if (!chiTiet.Contains("Sửa"))
                {
                    isVisibleFixBook = false;
                    isVisibleChangeStatus = false;
                }
            }
        }
        public String getChiTietByMaCN(String macn)
        {
            String str = "";
            foreach (ChiTietChucNang ctcn in ctcnList)
            {
                if (ctcn.SGMaCN.Equals(macn))
                {
                    str = ctcn.SGChiTiet;
                }
            }
            return str;
        }
        public void SetUpAccessPermissionsChildren()
        {
            foreach (ChiTietChucNang ctcn in ctcnList)
            {
                if (ctcn.SGMaCN.Equals("CN09"))
                {
                    btnTacGia.Enabled = true;
                }
                else if (ctcn.SGMaCN.Equals("CN10"))
                {
                    btnTheLoai.Enabled = true;
                }
                else if (ctcn.SGMaCN.Equals("CN12"))
                {
                    btnNhaXuatBan.Enabled = true;
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        
       
        private void iconButton5_Click(object sender, EventArgs e)
        {
            Form w = new GUI_TacGia(getChiTietByMaCN("CN09"));
            w.ShowDialog();
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            Quanlysach ql = new Quanlysach(isVisibleAddBook,isVisibleFixBook);
            ql.ShowDialog();
            List<TuaSach> list_ts = ts_BUS.getAllTuaSach();
            loadFlowSach(list_ts);
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            GUI_TheLoai gtl = new GUI_TheLoai(getChiTietByMaCN("CN10"));
            gtl.ShowDialog();


        }

        private void GUI_Sach_Load(object sender, EventArgs e)
        {
            List<TuaSach> list_ts = ts_BUS.getAllTuaSach();
            loadFlowSach(list_ts);
        }
        private void loadFlowSach(List<TuaSach> list_ts)
        {
            flowpanelSach.Controls.Clear();
            foreach (TuaSach x in list_ts)
            {
                loadSach(x);
            }
        }
        private void loadSach(TuaSach ts)
        {

            Panel panel = new Panel();
            panel.Size = new Size(268, 385);


            Panel status = new Panel();

            status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            status.Dock = System.Windows.Forms.DockStyle.Top;
            status.Size = new System.Drawing.Size(268, 7);


            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(268, 267);
            pictureBox.Dock = DockStyle.Top;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "Sach", ts.SGImage);
            pictureBox.Image = Image.FromFile(imagePath);
            pictureBox.MouseEnter += (sender1, e1) =>
            {
                status.BackColor = Color.FromArgb(228, 18, 109);
            };
            pictureBox.MouseLeave += (sender1, e1) =>
            {
                status.BackColor = Color.FromArgb(26, 25, 62);
            };


            Panel panel2 = new Panel();
            panel2.Size = new Size(268, 118);
            panel2.Dock = DockStyle.Top;
            panel2.BackColor = Color.White;
            panel2.MouseEnter += (sender1, e1) =>
            {
                status.BackColor = Color.FromArgb(228, 18, 109);
            };

            panel2.MouseLeave += (sender1, e1) =>
            {
                status.BackColor = Color.FromArgb(26, 25, 62);
            };

            Label lbname = new Label();

            lbname.TextAlign = ContentAlignment.MiddleCenter;
            lbname.AutoSize = false;
            lbname.Dock = DockStyle.Top;
            
            lbname.Height = 50;
            lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbname.ForeColor = System.Drawing.Color.Black;
            lbname.Location = new System.Drawing.Point(49, 12);
            lbname.Size = new System.Drawing.Size(166, 22);
            lbname.MouseEnter += (sender1, e1) =>
            {
                status.BackColor = Color.FromArgb(228, 18, 109);
            };
            lbname.MouseLeave += (sender1, e1) =>
            {
                status.BackColor = Color.FromArgb(26, 25, 62);
            };


            lbname.Text = ts.SGTenTuaSach;
            lbname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            Button btnXem = new Button();
            btnXem.BackColor = System.Drawing.Color.Red;
            btnXem.FlatAppearance.BorderSize = 0;
            btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXem.ForeColor = System.Drawing.Color.Black;
            btnXem.Location = new System.Drawing.Point(92, 58);
            btnXem.Size = new System.Drawing.Size(81, 39);
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = false;
            btnXem.MouseClick += (Sender3, e3) =>
            {
                ThemTuaSach infoSach = new ThemTuaSach(ts, isVisibleChangeStatus);
                infoSach.StartPosition = FormStartPosition.CenterScreen;
                infoSach.ShowDialog();
            };

            panel2.Controls.Add(btnXem);
            panel2.Controls.Add(lbname);


            panel.Controls.Add(panel2);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(status);
            flowpanelSach.Controls.Add(panel);
        }

        

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            List<TuaSach> list_ts = ts_BUS.getAllTuaSach();
            List<TuaSach> kq = new List<TuaSach>();
            
            string search = cbTimkiem.SelectedItem.ToString();
            
            switch (search)
            {
                case "":
                    string search_key2 = txtTiemKiem.Text;
                    foreach (TuaSach x in list_ts)
                    {
                        bool i = x.SGTenTuaSach.IndexOf(search_key2, StringComparison.OrdinalIgnoreCase) >= 0;
                        if (i)
                        {
                            kq.Add(x);
                        }
                    }
                    loadFlowSach(kq);
                    break;
                    
                case "Thể loại":
                    string search_key = txtTiemKiem.Text;
                    List<TheLoaiDTO> list_tl = tl_BUS.getAllTheLoai();
                    TheLoaiDTO tl = new TheLoaiDTO();
                    foreach (TheLoaiDTO x in list_tl)
                    {
                        if (string.Equals(x.TenTL, search_key, StringComparison.OrdinalIgnoreCase)){
                            tl = x;
                            break;
                        }
                    }

                    List<ChiTietTheLoai> list_cttl = cttl_BUS.getCttlByIDTheLoai(tl.MaTL);
                    foreach (ChiTietTheLoai s in list_cttl)
                    {
                        foreach(TuaSach k in list_ts)
                        {
                            if (k.SGMaTuaSach == s.SGMaTuaSach)
                            {
                                kq.Add(k);
                            }
                        }
                    }
                    loadFlowSach(kq);
                    break;
                
                    
                case "Tác giả":
                    string search_key3 = txtTiemKiem.Text;
                    List<TacGiaDTO> list_tg = tg_BUS.getAllTacGia();
                    TacGiaDTO tg1 = new TacGiaDTO();
                    foreach(TacGiaDTO tg in list_tg)
                    {
                        if (string.Equals(tg.TenTG, search_key3, StringComparison.OrdinalIgnoreCase))
                        {
                            tg1 = tg;
                        }
                    }
                    foreach (TuaSach ts in list_ts)
                    {
                        if (tg1.MaTG == ts.SGMaTacGia)
                        {
                            kq.Add(ts);
                        }
                    }
                    loadFlowSach(kq);
                    break;
            }

        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            new GUI_NXB(getChiTietByMaCN("CN12")).ShowDialog();
        }
    }
}
