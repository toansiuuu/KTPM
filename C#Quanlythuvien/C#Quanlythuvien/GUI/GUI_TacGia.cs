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
    public partial class GUI_TacGia : Form
    {
        TacGiaBus bus = new TacGiaBus();
        public GUI_TacGia(String chiTiet)
        {
            InitializeComponent();
            cb_timKiem.SelectedIndex = 0;
            cb_trangThai.SelectedIndex= 0;
            SetUpAccessPermissions(chiTiet);
        }
        public bool isVisibleFix = true;
        public void SetUpAccessPermissions(String chiTiet)
        {
            if (chiTiet.Trim().Equals(""))
            {
                btn_them.Visible = false;
                isVisibleFix = false;
            }
            else
            {
                if (!chiTiet.Contains("Thêm"))
                {
                    btn_them.Visible = false;
                }
                if (!chiTiet.Contains("Sửa"))
                {
                    isVisibleFix = false;
                }
            }
        }
        public void generateItems()
        {
            flowLayoutPanel1.Controls.Clear();
            List<TacGiaDTO> list = new List<TacGiaDTO>();
            list = bus.getAllTacGia();
            TacGiaUserControl[] items = new TacGiaUserControl[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                items[i] = new TacGiaUserControl();
                items[i].MaTG = list[i].MaTG;
                items[i].TenTG = list[i].TenTG;
                items[i].MoTa = list[i].MoTa;
                items[i].TinhTrang = list[i].TinhTrang;
                items[i].Img = list[i].Img;
                items[i].setThongTin();
                flowLayoutPanel1.Controls.Add(items[i]);
                items[i].clickThongTin += clickThongTin1;
            }
        }
        public void generateItems(List<TacGiaDTO> list)
        { 
            flowLayoutPanel1.Controls.Clear();
            TacGiaUserControl[] items = new TacGiaUserControl[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                items[i] = new TacGiaUserControl();
                items[i].MaTG = list[i].MaTG;
                items[i].TenTG = list[i].TenTG;
                items[i].MoTa = list[i].MoTa;
                items[i].TinhTrang = list[i].TinhTrang;
                items[i].Img = list[i].Img;
                items[i].setThongTin();
                flowLayoutPanel1.Controls.Add(items[i]);
                items[i].clickThongTin += clickThongTin1;
            }
        }
        public void clickThongTin1(object sender, EventArgs e)
        {
            frmSuaTacGia frmSua = new frmSuaTacGia(isVisibleFix);
            var thongTinUser = sender as TacGiaUserControl;
            string maTG = thongTinUser.MaTG;
            frmSua.setThongTin(bus.getTacGiaByMa(maTG));
            frmSua.resetGUI += resetGUI;
            frmSua.ShowDialog();
        }
        public void resetGUI(object sender, EventArgs e)
        {
            var frmSua = sender as frmSuaTacGia;
            generateItems();
            frmSua.Close();
        }
        private void GUI_TacGia_Load(object sender, EventArgs e)
        {
            generateItems();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frmThemTacGia frmThem = new frmThemTacGia();
            frmThem.resetGUIadd += resetGUIadd;
            frmThem.ShowDialog();
        }
        public void resetGUIadd(object sender, EventArgs e)
        {
            var frmThem = sender as frmThemTacGia;
            frmThem.Close();
            generateItems();
        }
        public void executeSearch()
        {
            string searchText = txt_timKiem.Text.ToLower();
            List<TacGiaDTO> list = bus.getAllTacGia();
            list = list.Where(tg =>
                (cb_timKiem.SelectedIndex==1 && tg.MaTG.ToLower().Contains(searchText.ToLower())) ||
                (cb_timKiem.SelectedIndex == 0 && tg.TenTG.ToLower().Contains(searchText.ToLower())) 
                ).ToList();
            if (cb_trangThai.SelectedIndex == 0)
            {

            }
            else
            {
                if(cb_trangThai.SelectedIndex==1)
                {
                    bool trangThai = true;
                    list = list.Where(tg =>
                    tg.TinhTrang == trangThai
            ).ToList();
                }
                else
                {
                    bool trangThai= false;
                    list = list.Where(tg =>
                    tg.TinhTrang == trangThai
            ).ToList();
                }
            }
            

            generateItems(list);
        }

        private void cb_timKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeSearch();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            executeSearch();
        }

        private void cb_trangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeSearch();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
