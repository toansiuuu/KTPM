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
    public partial class frmThemTS_PN : Form
    {
        public frmThemTS_PN()
        {
            InitializeComponent();
        }
        public  void setThongTin(string maSach,string tenSach)
        {
            txt_maSach.Text = maSach;
            txt_tenSach.Text = tenSach;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                
            }
        }

        private void frmThemTS_PN_Load(object sender, EventArgs e)
        {

        }
        public delegate void sendCTPn(ChiTietPhieuNhap ctpn);
        public  event sendCTPn sendCTPn_ED;

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (checkValidateForm())
            {
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                ctpn.SGMaTuaSach = txt_maSach.Text;
                ctpn.SGSoLuong = int.Parse(txt_soLuong.Text);
                ctpn.SGDonGia= float.Parse(txt_donGia.Text);
                sendCTPn_ED(ctpn);
                this.Close();
            }
            else
            {
                MessageBox.Show("Số lượng hoặc đơn giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool IsNumericAndGreaterThanZero(string input)
        {
            if (int.TryParse(input, out int number))
            {
                // Kiểm tra xem số có lớn hơn 0 không
                return number > 0;
            }
            else
            {
                // Chuỗi không chứa số hoặc không phải là số nguyên
                return false;
            }
        }
        public bool checkValidateForm() {
            if (!IsNumericAndGreaterThanZero(txt_soLuong.Text) || !IsNumericAndGreaterThanZero(txt_donGia.Text))
            {
                return false;
            }

                return true;
            }

        private void txt_donGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
