using DTO;
using BUS;
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
    public partial class ThemTuaSach : Form
    {
        static String macs = "";
        static String mats = "";
        private TacGiaBus bus = new TacGiaBus();
        private NhaXuatBanBUS nxb_BUS = new NhaXuatBanBUS();    
        private TheLoaiBUS tl_BUS = new TheLoaiBUS();
        private ChiTietTheLoaiBUS cttl_BUS = new ChiTietTheLoaiBUS();
        private CuonSachBUS cs_BUS = new CuonSachBUS();
        public ThemTuaSach(TuaSach tuasach,bool isVisibleChangeStatus)
        {
            InitializeComponent();
            LoadForm(tuasach);
            loadTableCuonSach();
            if (!isVisibleChangeStatus)
            {
                btnSua.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void loadTableCuonSach()
        {
            tableCuonSach.Rows.Clear();
            //foreach (CuonSach cs in cs_BUS.getAllCuonSach())
            //{
            //    String status_cs = "";
            //    if (cs.SGTrangThaiSach == 0)
            //    {
            //        status_cs = "Ngừng hoạt động";
            //    } else if (cs.SGTrangThaiSach == 1)
            //    {
            //        status_cs = "Đang hoạt động";
            //    } else
            //    {
            //        status_cs = "Đã mượn";
            //    }
            //    tableCuonSach.Rows.Add(
            //        cs.SGMaTuaSach,
            //        cs.SGMaCuonSach,
            //        status_cs
            //        );
            //}
            foreach (CuonSach cs in cs_BUS.getAllCuonSachByMa(txtMasach.Text))
            {
                String status_cs = "";
                if (cs.SGTrangThaiSach == 0)
                {
                    status_cs = "Ngừng hoạt động";
                }
                else if (cs.SGTrangThaiSach == 1)
                {
                    status_cs = "Đang hoạt động";
                }
                else
                {
                    status_cs = "Đã mượn";
                }
                tableCuonSach.Rows.Add(
                    cs.SGMaTuaSach,
                    cs.SGMaCuonSach,
                    status_cs
                    );
            }
        }

        private String getNameNXB(TuaSach ts)
        {
            String name = "";
            NhaXuatBan nxb = nxb_BUS.getNhaXuatBanByID(ts.SGMaNXB);
            name = nxb.SGTenNXB;
            return name;
        }
        private String getNameTG(TuaSach ts)
        {
            String Name = "";
            TacGiaDTO tg = bus.getTacGiaByMa(ts.SGMaTacGia);
            Name = tg.TenTG;
            return Name;
        }
        private void LoadForm(TuaSach ts)
        {
            List<ChiTietTheLoai> list_cttl = cttl_BUS.GetChiTietTheLoaiByIDSach(ts.SGMaTuaSach);
            List<TheLoaiDTO> list_tl = tl_BUS.getAllTheLoai();
            foreach (TheLoaiDTO tl in list_tl)
            {
                foreach (ChiTietTheLoai cttl in list_cttl)
                {
                    if (tl.MaTL == cttl.SGMaTheLoai)
                    {

                        if (txtTheLoai.Text == "")
                        {
                            txtTheLoai.Text += tl.TenTL;
                        }
                        else
                        {
                            txtTheLoai.Text += ", " + tl.TenTL;
                        }
                    }
                }
            }

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "Sach", ts.SGImage);
            pictureBox1.Image = new Bitmap(imagePath);

            txtMasach.Text = ts.SGMaTuaSach;
            txtTenSach.Text = ts.SGTenTuaSach;
            txtTacGia.Text = getNameTG(ts);
            txtNamxb.Text = ts.SGNamXB.ToString();
            txtNXB.Text = getNameNXB(ts);
            txtMota.Text = ts.SGMoTa;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tableCuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < tableCuonSach.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = tableCuonSach.Rows[e.RowIndex];

                if (selectedRow.Cells["maSach"].Value != null)
                {
                    // Lấy giá trị ở cột "Ma" từ dòng được chọn
                    mats = tableCuonSach.Rows[e.RowIndex].Cells["maSach"].Value.ToString();
                    macs = tableCuonSach.Rows[e.RowIndex].Cells["MaCuonSach"].Value.ToString();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!mats.Trim().Equals("") && !macs.Trim().Equals(""))
            {
                CuonSach cs = cs_BUS.getCuonSachByMa(macs, mats);
                if (cs.SGTrangThaiSach == 2)
                {
                    MessageBox.Show("Sách đang được mượn không thể thay đổi trạng thái", "Thông báo");
                }
                else
                {
                    if (cs.SGTrangThaiSach == 0)
                    {
                        cs.SGTrangThaiSach = 1;
                        cs_BUS.updateTTCuonSach(cs);
                        MessageBox.Show("Đã thay đổi thành công");
                        loadTableCuonSach();
                    }
                    else
                    {
                        cs.SGTrangThaiSach = 0;
                        cs_BUS.updateTTCuonSach(cs);
                        MessageBox.Show("Đã thay đổi thành công");
                        loadTableCuonSach();
                    }
                }
            }
        }
    }
}
