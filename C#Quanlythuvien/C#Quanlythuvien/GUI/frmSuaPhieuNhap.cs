using BUS;
using DTO;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.GUI_NhapHang;

namespace GUI
{
    public partial class frmSuaPhieuNhap : Form
    {
        PhieuNhapBUS pnBUS = new PhieuNhapBUS();
        ChiTietPhieuNhapBUS ctpnBUS = new ChiTietPhieuNhapBUS();
        public frmSuaPhieuNhap()
        {
            InitializeComponent();
            cb_timKiem.SelectedIndex= 0;    
        }
        string mapn;
        public void getMaPNfromCha(string mapn)
        {
            this.mapn = mapn;
            txt_maPhieuNhap.Text = this.mapn;
        }
        private void frmSuaPhieuNhap_Load(object sender, EventArgs e)
        {
            listView2.Columns[0].Width = (int)(listView2.Width / 3);
            listView2.Columns[1].Width = (int)(listView2.Width / 3);
            listView2.Columns[2].Width = (int)(listView2.Width / 3);
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;

            listView1.Columns[0].Width = (int)(listView1.Width / 3);
            listView1.Columns[1].Width = (int)(listView1.Width / 3);
            listView1.Columns[2].Width = (int)(listView1.Width / 3);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            setThongTin();
            loadListViewSach(pnBUS.getAllTuaSach());
            loadChiTietPhieuNhap(ctpnBUS.getAllPhieuNhapByMaPN(mapn));

        }
        public void setThongTin()
        {
            PhieuNhap pn = pnBUS.getPhieuNhapByMa(mapn);
            txt_maNCC.Text = pn.SGMaNCC;
            txt_maNhanVien.Text = pn.SGMaNhanVien;
            dp_ngayNhap.Value = pn.SGNgayNhap;
            txt_tongTIen.Text = pn.SGTongTien.ToString();
        }
        public void loadListViewSach(List<TuaSach> list)
        {
            listView2.Items.Clear();
            foreach (TuaSach ts in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ts.SGMaTuaSach; // Thiết lập giá trị cho cột chính (cột 0)
                item.SubItems.Add(ts.SGTenTuaSach); // Cột 1
                item.SubItems.Add(ts.SGSoLuong.ToString()); // Cột 3
                listView2.Items.Add(item);
            }
        }
        public void loadChiTietPhieuNhap(List<ChiTietPhieuNhap> list)
        {
            listView1.Items.Clear();
            foreach (ChiTietPhieuNhap ctpn in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ctpn.SGMaTuaSach; // Thiết lập giá trị cho cột chính (cột 0)
                item.SubItems.Add(ctpn.SGSoLuong.ToString()); // Cột 1
                item.SubItems.Add(ctpn.SGDonGia.ToString()); // Cột 3
                listView1.Items.Add(item);
            }
        }

        private void cb_timKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeTimKiem();
        }
        public void executeTimKiem()
        {
            List<TuaSach> listTS = pnBUS.getAllTuaSach();
            string keyWord = txt_timKiem.Text.ToLower();
            listTS = listTS.Where(
                ts =>
                (cb_timKiem.SelectedIndex == 0 && ts.SGTenTuaSach.ToLower().Contains(keyWord)) ||
                (cb_timKiem.SelectedIndex == 1 && ts.SGMaTuaSach.ToLower().Contains(keyWord))
                ).ToList();
            loadListViewSach(listTS);

        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            executeTimKiem();
        }
        public delegate void sendData(string ma, string ten);
        public sendData sendDataed;
        private void button7_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                // Có ít nhất một dòng được chọn
                ListViewItem selectedRow = listView2.SelectedItems[0];

                // Thực hiện các hành động với dòng đã chọn
                string firstColumnValue = selectedRow.SubItems[0].Text;
                string secondColumnValue = selectedRow.SubItems[1].Text;
                frmThemTS_PN frmThem = new frmThemTS_PN();
                this.sendDataed += new sendData(frmThem.setThongTin);
                sendDataed(firstColumnValue, secondColumnValue);
                frmThem.sendCTPn_ED += loadChiTietPhieuNhap;
                frmThem.ShowDialog();

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sách dưới table", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void loadChiTietPhieuNhap(ChiTietPhieuNhap ctpn)
        {
            bool check = false;
            ListViewItem item1 = null;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem item = listView1.Items[i];

                if (ctpn.SGMaTuaSach == item.SubItems[0].Text)
                {
                    item1 = item;
                    check = true; break;
                }
            }
            if (!check)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ctpn.SGMaTuaSach; // Thiết lập giá trị cho cột chính (cột 0)
                item.SubItems.Add(ctpn.SGSoLuong.ToString()); // Cột 1
                item.SubItems.Add(ctpn.SGDonGia.ToString()); // Cột 3
                listView1.Items.Add(item);
                capNhatGia();
            }
            else
            {
                if (float.Parse(item1.SubItems[2].Text) != ctpn.SGDonGia)
                {
                    DialogResult result = MessageBox.Show("Bạn vừa nhâp giá khác, bạn có muốn đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int sl = int.Parse(item1.SubItems[1].Text) + ctpn.SGSoLuong;
                        item1.SubItems[1].Text = sl.ToString();

                        float donGia = ctpn.SGDonGia;
                        item1.SubItems[2].Text = donGia.ToString();
                    }
                    else
                    {
                        int sl = int.Parse(item1.SubItems[1].Text) + ctpn.SGSoLuong;
                        item1.SubItems[1].Text = sl.ToString();
                    }
                }
                else
                {
                    int sl = int.Parse(item1.SubItems[1].Text) + ctpn.SGSoLuong;
                    item1.SubItems[1].Text = sl.ToString();
                }
            }
            capNhatGia();

        }
        public void capNhatGia()
        {
            float sum = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem item = listView1.Items[i];
                sum += float.Parse(item.SubItems[2].Text) * int.Parse(item.SubItems[1].Text);
            }
            txt_tongTIen.Text = sum.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listView1.SelectedItems[0];
                int soLuong = int.Parse(selectedRow.SubItems[1].Text);
                string inputSL = Interaction.InputBox("Nhập vào số lượng cần xóa:", "Số Lượng", "1");
                if (inputSL != "")
                {

                    if (ValidateSoLuongNhap(inputSL, soLuong))
                    {
                        int inputSL1 = int.Parse(inputSL);
                        if (inputSL1 == soLuong)
                        {
                            listView1.Items.Remove(selectedRow);
                        }
                        else
                        {
                            int slNew = soLuong - inputSL1;
                            selectedRow.SubItems[1].Text = slNew.ToString();
                        }
                        capNhatGia();
                    }
                    else
                    {
                        MessageBox.Show("Số lượng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sách dưới table", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public bool ValidateSoLuongNhap(String input, int soLuong)
        {
            string pattern = @"^\d+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input) && Convert.ToInt32(input) > 0
                && Convert.ToInt32(input) <= soLuong;
        }
        public List<ChiTietPhieuNhap> getModelChiTiet()
        {
            List<ChiTietPhieuNhap> ctpn = new List<ChiTietPhieuNhap>();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ChiTietPhieuNhap ctpnItem = new ChiTietPhieuNhap();
                ListViewItem item = listView1.Items[i];
                ctpnItem.SGMaPhieuNhap = txt_maPhieuNhap.Text;
                ctpnItem.SGMaTuaSach = item.SubItems[0].Text;
                ctpnItem.SGSoLuong = int.Parse(item.SubItems[1].Text);
                ctpnItem.SGDonGia = float.Parse(item.SubItems[2].Text);
                ctpn.Add(ctpnItem);

            }
            return ctpn;
        }
        public event EventHandler btn_Them_Clicked;
        private void Onbtn_Them_Clicked()
        {
            btn_Them_Clicked?.Invoke(this, EventArgs.Empty);
        }
        private void btn_hoanThanh_Click(object sender, EventArgs e)
        {
            int rowAffected = pnBUS.deleteCTPNofPNByMa(this.mapn);
            int a = pnBUS.updateTongTien(this.mapn, float.Parse(txt_tongTIen.Text));
            List<ChiTietPhieuNhap> list = getModelChiTiet();
            if (ctpnBUS.insertCTPN(list) > 0)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Onbtn_Them_Clicked();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa ko thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
