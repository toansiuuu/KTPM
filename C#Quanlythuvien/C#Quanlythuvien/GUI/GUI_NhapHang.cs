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
using System.Windows.Documents;
using System.Windows.Forms;



namespace GUI
{
    public partial class GUI_NhapHang : Form
    {
        PhieuNhapBUS pnBUS = new PhieuNhapBUS();
        ChiTietPhieuNhapBUS ctpnBUS = new ChiTietPhieuNhapBUS();  
        public GUI_NhapHang()
        {
            InitializeComponent();
            txt_maNhanVien.Text = "NV002";
            setCungMaPhieuNhap();
            getAllNCC();
            cb_timKiem.SelectedIndex = 0;
        }
        public GUI_NhapHang(String chiTiet,String maNV)
        {
            InitializeComponent();
            setCungMaPhieuNhap();
            getAllNCC();
            txt_maNhanVien.Text = maNV;
            cb_timKiem.SelectedIndex = 0;
            SetUpAccessPermissions(chiTiet);
        }
        public void SetUpAccessPermissions(String chiTiet)
        {
            if (!chiTiet.Contains("Lập"))
            {
                tabControl1.TabPages.Remove(tabPage1);
            }
            if (!chiTiet.Contains("XemLS"))
            {
                tabControl1.TabPages.Remove(tabPage2);
            }
            if (!chiTiet.Contains("QL"))
            {
                tabControl1.TabPages.Remove(tabPage3);
            }
        }
        public void loadListViewSach(List<TuaSach> list)
        {
            listView2.Items.Clear();
            foreach(TuaSach ts in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ts.SGMaTuaSach; 
                item.SubItems.Add(ts.SGTenTuaSach); 
                item.SubItems.Add(ts.SGSoLuong.ToString());
                listView2.Items.Add(item);
            }
        }
       public void setCungMaPhieuNhap()
        {
            txt_maPhieuNhap.Text = pnBUS.getLastMaPN();
        }
        public void getAllNCC()
        {
            List<string> list = pnBUS.getAllNCC();
            foreach (string s in list)
            {
                cb_NCC.Items.Add(s);
            }
            cb_NCC.SelectedIndex= 0;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void GUI_NhapHang_Load(object sender, EventArgs e)
        {
            listView2.Columns[0].Width = (int)(listView2.Width /3);
            listView2.Columns[1].Width = (int)(listView2.Width /3);
            listView2.Columns[2].Width = (int)(listView2.Width /3);
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;

            listView1.Columns[0].Width = (int)(listView1.Width / 3);
            listView1.Columns[1].Width = (int)(listView1.Width / 3);
            listView1.Columns[2].Width = (int)(listView1.Width / 3);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            lv_phieuNhap.Columns[0].Width = (int)(lv_phieuNhap.Width / 6);
            lv_phieuNhap.Columns[1].Width = (int)(lv_phieuNhap.Width / 6);
            lv_phieuNhap.Columns[2].Width = (int)(lv_phieuNhap.Width / 6);
            lv_phieuNhap.Columns[3].Width = (int)(lv_phieuNhap.Width / 6);
            lv_phieuNhap.Columns[4].Width = (int)(lv_phieuNhap.Width / 6);
            lv_phieuNhap.Columns[5].Width = (int)(lv_phieuNhap.Width / 6);

            lv_phieuNhap.GridLines = true;
            lv_phieuNhap.FullRowSelect = true;

            lv_chiTietPN.Columns[0].Width = (int)(lv_chiTietPN.Width / 4);
            lv_chiTietPN.Columns[1].Width = (int)(lv_chiTietPN.Width / 4);
            lv_chiTietPN.Columns[2].Width = (int)(lv_chiTietPN.Width / 4);
            lv_chiTietPN.Columns[3].Width = (int)(lv_chiTietPN.Width / 4);

            lv_chiTietPN.GridLines = true;
            lv_chiTietPN.FullRowSelect=true;

            lv_phieuNhap3.Columns[0].Width = (int)(lv_phieuNhap.Width / 6);
            lv_phieuNhap3.Columns[1].Width = (int)(lv_phieuNhap.Width / 6);
            lv_phieuNhap3.Columns[2].Width = (int)(lv_phieuNhap.Width / 6);
            lv_phieuNhap3.Columns[3].Width = (int)(lv_phieuNhap.Width / 6);
            lv_phieuNhap3.Columns[4].Width = (int)(lv_phieuNhap.Width / 6);
            lv_phieuNhap3.Columns[5].Width = (int)(lv_phieuNhap.Width / 6);

            lv_phieuNhap3.GridLines = true;
            lv_phieuNhap3.FullRowSelect = true;

            lv_chiTietPN3.Columns[0].Width = (int)(lv_chiTietPN.Width / 4);
            lv_chiTietPN3.Columns[1].Width = (int)(lv_chiTietPN.Width / 4);
            lv_chiTietPN3.Columns[2].Width = (int)(lv_chiTietPN.Width / 4);
            lv_chiTietPN3.Columns[3].Width = (int)(lv_chiTietPN.Width / 4);

            lv_chiTietPN3.GridLines = true;
            lv_chiTietPN3.FullRowSelect = true;

            loadListViewSach(pnBUS.getAllTuaSach());
            loadPhieuNhap(pnBUS.getAllPhieuNhapByMaNV(txt_maNhanVien.Text));
            loadPhieuNhap(lv_phieuNhap3, pnBUS.getAllPhieuNhap());

        }
        // lay data load len table phieu nhap
        public void loadPhieuNhap(List<PhieuNhap> list)
        {
            lv_phieuNhap.Items.Clear();
            foreach (PhieuNhap pn in list )
            {
                ListViewItem item = new ListViewItem();
                item.Text = pn.SGMaPhieuNhap; // Thiết lập giá trị cho cột chính (cột 0)
                item.SubItems.Add(pn.SGMaNCC); // Cột 1
                item.SubItems.Add(pn.SGMaNhanVien); // Cột 3
                item.SubItems.Add(pn.SGNgayNhap.ToString()); // Cột 3
                item.SubItems.Add(pn.SGTongTien.ToString()); // Cột 3
                item.SubItems.Add(pn.SGTinhTrang?"Đã duyệt":"Chưa duyệt"); // Cột 3
                lv_phieuNhap.Items.Add(item);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Bảng trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                PhieuNhap pn = getModel();
                List<ChiTietPhieuNhap> ctpn = getModelChiTiet();
                if (pnBUS.insertPhieuNhap(pn) > 0 && ctpnBUS.insertCTPN(ctpn) > 0)
                {
                    MessageBox.Show("Thêm phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearBang1();
                    clearField();
                    setCungMaPhieuNhap();
                }
                else
                {
                    MessageBox.Show("Không thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
        public void clearField()
        {
            cb_NCC.SelectedIndex = 0;
            txt_tongTIen.Text = "";
        }
        public PhieuNhap getModel()
        {
            PhieuNhap pn = new PhieuNhap();
            pn.SGMaPhieuNhap = txt_maPhieuNhap.Text;
            pn.SGMaNCC=cb_NCC.SelectedItem.ToString();
            pn.SGMaNhanVien = txt_maNhanVien.Text;
            pn.SGTongTien = float.Parse(txt_tongTIen.Text);
            pn.SGNgayNhap = dp_ngayNhap.Value;
            pn.SGTinhTrang = false;
            return pn;
        }
        public List<ChiTietPhieuNhap> getModelChiTiet()
        {
            List<ChiTietPhieuNhap> ctpn = new List<ChiTietPhieuNhap> ();
            for(int i = 0;i<listView1.Items.Count;i++)
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
       
        private void txtMaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
      

      

       
        private void txtMaPhieuNhap_TextChanged(object sender, EventArgs e)
        {




        }
        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            


        }
       



        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMaPhieuNhap_Validating(object sender, CancelEventArgs e)
        {
           
        }

    

        private void txtSoLuong_Validating(object sender, CancelEventArgs e)
        {
           
        }

      
        

      
        private void txtGia_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                MessageBox.Show("Bạn chưa chọn sách dưới table","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
        public void loadChiTietPhieuNhap(ChiTietPhieuNhap ctpn)
        {
            bool check = false;
            ListViewItem item1 = null;
                for(int i = 0;i<listView1.Items.Count;i++)
            {
                ListViewItem item = listView1.Items[i];

                if (ctpn.SGMaTuaSach == item.SubItems[0].Text)
                {
                    item1 = item;
                    check = true; break;
                }
            }
            if (!check) {
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
        public void clearBang1()
        {
            listView1.Items.Clear();
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
                   
                    if(ValidateSoLuongNhap(inputSL, soLuong))
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void capNhatGia()
        {
            float sum = 0;
            for(int i=0;i<listView1.Items.Count;i++)
            {
                ListViewItem item = listView1.Items[i];
                sum += float.Parse(item.SubItems[2].Text) * int.Parse(item.SubItems[1].Text);    
            }
            txt_tongTIen.Text = sum.ToString();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            executeTimKiem();
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
                (cb_timKiem.SelectedIndex==0 && ts.SGTenTuaSach.ToLower().Contains(keyWord)) ||
                (cb_timKiem.SelectedIndex == 1 && ts.SGMaTuaSach.ToLower().Contains(keyWord)) 
                ).ToList();
            loadListViewSach(listTS);

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        public void loadChiTietPhieuNhap(List<ChiTietPhieuNhap> list)
        {
            lv_chiTietPN.Items.Clear();
            foreach (ChiTietPhieuNhap ctpn in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ctpn.SGMaPhieuNhap; // Thiết lập giá trị cho cột chính (cột 0)
                item.SubItems.Add(ctpn.SGMaTuaSach); // Cột 1
                item.SubItems.Add(ctpn.SGSoLuong.ToString()); // Cột 3
                item.SubItems.Add(ctpn.SGDonGia.ToString()); // Cột 3
                lv_chiTietPN.Items.Add(item);
            }
        }
        private void lv_phieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_phieuNhap.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lv_phieuNhap.SelectedItems[0];
                string mapn = selectedRow.SubItems[0].Text;
                List<ChiTietPhieuNhap> list = ctpnBUS.getAllPhieuNhapByMaPN(mapn);
                loadChiTietPhieuNhap(list);
            }
            else
            {

            }
        }
        public void loadBangLaiSauKhiSua()
        {
            loadPhieuNhap(pnBUS.getAllPhieuNhapByMaNV(txt_maNhanVien.Text));
            foreach (ListViewItem item in lv_phieuNhap.SelectedItems)
            {
                item.Selected = false;
            }
            lv_chiTietPN.Items.Clear();

        }
        private void btn_Them_Clicked(object sender, EventArgs e)
        {

           loadBangLaiSauKhiSua();
        }

        public delegate void sendMaPhieuNhap(string mapn);
        public sendMaPhieuNhap sendMaPhieuNhap_Click;

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (lv_phieuNhap.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lv_phieuNhap.SelectedItems[0];
                string trangThai = selectedRow.SubItems[5].Text;
                string mapn = selectedRow.SubItems[0].Text;
                if (trangThai == "Đã duyệt")
                {
                    MessageBox.Show("Không được sửa phiếu nhập đã duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                  frmSuaPhieuNhap formSua = new frmSuaPhieuNhap();
                  this.sendMaPhieuNhap_Click += new sendMaPhieuNhap(formSua.getMaPNfromCha);
                  sendMaPhieuNhap_Click(mapn);
                    formSua.btn_Them_Clicked+= btn_Them_Clicked;
                    formSua.ShowDialog();

                }

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn 1 dòng cụ thể", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
       
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lv_phieuNhap.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lv_phieuNhap.SelectedItems[0];
                string trangThai = selectedRow.SubItems[5].Text;
                string mapn = selectedRow.SubItems[0].Text;
                if(trangThai=="Đã duyệt")
                {
                    MessageBox.Show("Không được xóa phiếu nhập đã duyệt","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    if (pnBUS.deletePhieuNhapByMa(mapn) > 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadPhieuNhap(pnBUS.getAllPhieuNhapByMaNV(txt_maNhanVien.Text));
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

            }

        }
        public void loadPhieuNhap(ListView lv,List<PhieuNhap> list)
        {
            lv.Items.Clear();
            foreach (PhieuNhap pn in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pn.SGMaPhieuNhap; // Thiết lập giá trị cho cột chính (cột 0)
                item.SubItems.Add(pn.SGMaNCC); // Cột 1
                item.SubItems.Add(pn.SGMaNhanVien); // Cột 3
                item.SubItems.Add(pn.SGNgayNhap.ToString()); // Cột 3
                item.SubItems.Add(pn.SGTongTien.ToString()); // Cột 3
                item.SubItems.Add(pn.SGTinhTrang ? "Đã duyệt" : "Chưa duyệt"); // Cột 3
                lv.Items.Add(item);
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPhieuNhap(pnBUS.getAllPhieuNhapByMaNV(txt_maNhanVien.Text));
            loadListViewSach(pnBUS.getAllTuaSach());
            setCungMaPhieuNhap();
        }
        public void loadChiTietPhieuNhap(ListView lv,List<ChiTietPhieuNhap> list)
        {
            lv.Items.Clear();
            foreach (ChiTietPhieuNhap ctpn in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ctpn.SGMaPhieuNhap; // Thiết lập giá trị cho cột chính (cột 0)
                item.SubItems.Add(ctpn.SGMaTuaSach); // Cột 1
                item.SubItems.Add(ctpn.SGSoLuong.ToString()); // Cột 3
                item.SubItems.Add(ctpn.SGDonGia.ToString()); // Cột 3
                lv.Items.Add(item);
            }
        }

        private void lv_phieuNhap3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_phieuNhap3.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lv_phieuNhap3.SelectedItems[0];
                string mapn = selectedRow.SubItems[0].Text;
                List<ChiTietPhieuNhap> list = ctpnBUS.getAllPhieuNhapByMaPN(mapn);
                loadChiTietPhieuNhap(lv_chiTietPN3,list);
            }
            else
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            executeTimKiemDuyet();
        }
        public void executeTimKiemDuyet()
        {
            List<PhieuNhap> listPN = pnBUS.getAllPhieuNhap();
            string keyWord = txt_timKiem1.Text.ToLower();
            listPN = listPN.Where(
                pn =>
                pn.SGMaPhieuNhap.ToLower().Contains(keyWord)
                ).ToList();
            loadPhieuNhap(lv_phieuNhap3,listPN);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lv_phieuNhap3.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lv_phieuNhap3.SelectedItems[0];
                string trangThai = selectedRow.SubItems[5].Text;
                string mapn = selectedRow.SubItems[0].Text;
                if (trangThai == "Đã duyệt")
                {
                    MessageBox.Show("Không được sửa phiếu nhập đã duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmSuaPhieuNhap formSua = new frmSuaPhieuNhap();
                    this.sendMaPhieuNhap_Click += new sendMaPhieuNhap(formSua.getMaPNfromCha);
                    sendMaPhieuNhap_Click(mapn);
                    formSua.btn_Them_Clicked += btn_Them_Clicked1;
                    formSua.ShowDialog();

                }

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn 1 dòng cụ thể", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btn_Them_Clicked1(object sender, EventArgs e)
        {

            loadBangLaiSauKhiSua1();
        }
        public void loadBangLaiSauKhiSua1()
        {
            loadPhieuNhap(lv_phieuNhap3,pnBUS.getAllPhieuNhap());
            foreach (ListViewItem item in lv_phieuNhap3.SelectedItems)
            {
                item.Selected = false;
            }
            lv_chiTietPN3.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lv_phieuNhap3.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lv_phieuNhap3.SelectedItems[0];
                string trangThai = selectedRow.SubItems[5].Text;
                string mapn = selectedRow.SubItems[0].Text;
                if (trangThai == "Đã duyệt")
                {
                    MessageBox.Show("Không được xóa phiếu nhập đã duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (pnBUS.deletePhieuNhapByMa(mapn) > 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadPhieuNhap(lv_phieuNhap3,pnBUS.getAllPhieuNhap());
                        lv_chiTietPN3.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

            }
            else
            {
                MessageBox.Show("Chưa chọn dòng cụ thể để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            loadPhieuNhap(lv_phieuNhap3, pnBUS.getAllPhieuNhap());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lv_phieuNhap3.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lv_phieuNhap3.SelectedItems[0];
                string trangThai = selectedRow.SubItems[5].Text;
                string mapn = selectedRow.SubItems[0].Text;
                if (trangThai == "Đã duyệt")
                {
                    MessageBox.Show("Phiếu nhập này đã được duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (pnBUS.updateTinhTrangByMa(mapn) > 0)
                    {
                        List<ChiTietPhieuNhap> listCTPN = ctpnBUS.getAllPhieuNhapByMaPN(mapn);
                        if(ctpnBUS.updateSoLuongTuaSachNhap(listCTPN) > 0)
                        {
                            if(ctpnBUS.insertCuonSachByFromCTPN(listCTPN) > 0)
                            {
                                MessageBox.Show("Duyệt thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lv_chiTietPN3.Items.Clear();
                                loadPhieuNhap(lv_phieuNhap3, pnBUS.getAllPhieuNhap());
                            }
                            else
                            {
                                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật số lượng sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

            }
            else
            {
                MessageBox.Show("Chưa chọn dòng cụ thể để duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
