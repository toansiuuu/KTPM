using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_PhanQuyen : Form
    {
        NhomQuyenBUS busNQ = new NhomQuyenBUS();  
        ChucNangBUS busCN = new ChucNangBUS();  
        public GUI_PhanQuyen()
        {
            InitializeComponent();
            loadData(busNQ.getAllNhomQuyen());
        }
        public GUI_PhanQuyen(String chiTiet)
        {
            InitializeComponent();
            loadData(busNQ.getAllNhomQuyen());
            SetUpAccessPermissions(chiTiet);
        }
        public void SetUpAccessPermissions(String chiTiet)
        {
            if (chiTiet.Trim().Equals(""))
            {
                button1.Visible = false;
            }
        }
        public void loadData(List<NhomQuyen> list)
        {
            listView1.Items.Clear();
            foreach (NhomQuyen nq in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = nq.SGMaQuyen; // Thiết lập giá trị cho cột chính (cột 0)

                item.SubItems.Add(nq.SGTenQuyen); // Cột 1

                item.SubItems.Add(nq.SGMoTa); // Cột 3
                listView1.Items.Add(item);
            }
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void GUI_PhanQuyen_Load(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = (int)(listView1.Width /3);
            listView1.Columns[1].Width = (int)(listView1.Width / 3);
            listView1.Columns[2].Width = (int)(listView1.Width / 3);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public delegate void layMaQuyen(string maQ);
        public event layMaQuyen layMaQuyen1;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy mục đầu tiên trong danh sách các mục được chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Lấy thông tin từ các cột của mục được chọn
                string column1Value = selectedItem.SubItems[0].Text; // Thay 0 bằng chỉ số cột mong muốn
                string column2Value = selectedItem.SubItems[1].Text; // Thay 1 bằng chỉ số cột mong muốn
                string column3Value = selectedItem.SubItems[2].Text; // Thay 2 bằng chỉ số cột mong muốn

                // Hiển thị thông tin hoặc thực hiện các thao tác khác dựa trên thông tin
                frmPhanQuyen a = new frmPhanQuyen(column1Value);
                a.btn_CapNhat_Clicked += btn_capNhatClicked;
                a.setThongTin(column1Value);
                a.setThongTinCacChildNode(column1Value);
                layMaQuyen1?.Invoke(column1Value);
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trước khi nhấn Sửa");
            }

        }
        public void btn_capNhatClicked(object sender, EventArgs e)
        {
            var a = sender as frmPhanQuyen;
            a.Close();
            loadData(busNQ.getAllNhomQuyen());
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                tb_maquyen.Text = selectedItem.SubItems[0].Text;
                tb_tenquyen.Text = selectedItem.SubItems[1].Text;
                tb_mota.Text = selectedItem.SubItems[2].Text;
            }
        }
    }
}
