using BUS;
using DTO;
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
using System.Windows.Markup;

namespace GUI
{
    public partial class GUI_TheLoai : Form
    {
        TheLoaiBUS bus = new TheLoaiBUS();
        public GUI_TheLoai(String chiTiet)
        {
            InitializeComponent();
            loadData(bus.getAllTheLoai());
            cb_timKiem.SelectedIndex = 0;
            setCungMaTL();
            btn_capNhat.Enabled = false;
            SetUpAccessPermissions(chiTiet);
        }
        public void SetUpAccessPermissions(String chiTiet)
        {
            if (chiTiet.Trim().Equals(""))
            {
                btn_them.Visible = false;
                btn_capNhat.Visible = false;
            }
            else
            {
                if (!chiTiet.Contains("Thêm"))
                {
                    btn_them.Visible = false;
                }
                if (!chiTiet.Contains("Sửa"))
                {
                    btn_capNhat.Visible = false;
                }
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUI_TheLoai_Load(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = (int)(listView1.Width * 0.33);
            listView1.Columns[1].Width = (int)(listView1.Width * 0.33);
            listView1.Columns[2].Width = (int)(listView1.Width * 0.33);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect=true;
        }
        public void loadData(List<TheLoaiDTO> list)
        {
            listView1.Items.Clear();
            foreach (TheLoaiDTO tl in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = tl.MaTL; // Thiết lập giá trị cho cột chính (cột 0)
                item.SubItems.Add(tl.TenTL); // Cột 1
                item.SubItems.Add(tl.MoTa); // Cột 3
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_capNhat.Enabled = true;
            btn_them.Enabled = false;
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string maTL = selectedItem.Text;
                string tenTL = selectedItem.SubItems[1].Text; 
                string moTa = selectedItem.SubItems[2].Text; 
                txt_ma.Text = maTL;
                txt_ma.ReadOnly = true;
                txt_ten.Text = tenTL;
                rt_moTa.Text = moTa;
            }
        }
        static bool IsOnlyLetters(string str)
        {
            string pattern = @"^[\p{L}\s']+$";
            return Regex.IsMatch(str, pattern);
        }
        public bool checkValidForm()
        {
            if (txt_ten.Text.Trim().Length == 0 || rt_moTa.Text.Trim().Length == 0)
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
        public TheLoaiDTO getModel()
        {
            TheLoaiDTO tl = new TheLoaiDTO();
            string ten = txt_ten.Text;
            ten = ten.Trim();
            ten = Regex.Replace(ten, @"\s+", " ");
            string moTa = rt_moTa.Text;
            moTa = moTa.Trim();
            moTa = Regex.Replace(moTa, @"\s+", " ");
            tl.MaTL = txt_ma.Text;
            tl.TenTL = ten;
            tl.MoTa = moTa;
            return tl;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (checkValidForm())
            {
                TheLoaiDTO tl = getModel();
                if (bus.insertTL(tl) > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData(bus.getAllTheLoai());
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Không thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        public void setCungMaTL()
        {
            txt_ma.Text = bus.getLastMaTL();
            txt_ma.ReadOnly = true;
        }
        public void resetForm() { 
            setCungMaTL();
            txt_ten.Text = "";
            rt_moTa.Text = "";
            loadData(bus.getAllTheLoai());
            btn_them.Enabled = true;
            btn_capNhat.Enabled = false;
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            resetForm();
        }
        public void setModel()
        {

        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            if(checkValidForm())
            {
                TheLoaiDTO tl = getModel();
                if(bus.updateTL(tl)>0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData(bus.getAllTheLoai());
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void cb_timKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeSearch();
        }
        public void executeSearch()
        {
            string searchText = txt_timKiem.Text.ToLower();
            List<TheLoaiDTO> list = bus.getAllTheLoai();
            list = list.Where(tl =>
               (cb_timKiem.SelectedIndex == 1 && tl.MaTL.ToLower().Contains(searchText.ToLower())) ||
               (cb_timKiem.SelectedIndex == 0 && tl.TenTL.ToLower().Contains(searchText.ToLower()))
               ).ToList();
            loadData(list);
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            executeSearch();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeSearch();
        }
    }
}
