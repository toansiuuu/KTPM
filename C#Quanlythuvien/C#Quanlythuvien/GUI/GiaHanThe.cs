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
    public partial class GiaHanThe : Form
    {
        private TheThuVienBUS ttv_BUS = new TheThuVienBUS();
        private TheThuVien ttv_giahan = new TheThuVien();
        private DocGiaBUS dg_BUS = new DocGiaBUS();
        public GiaHanThe(TheThuVien ttv)
        {
            InitializeComponent();
            LoadForm(ttv);
        }

        private void LoadForm(TheThuVien ttv)
        {
            dateBatdau.Value = DateTime.Now;
            dateKetThuc.Value = dateBatdau.Value.AddDays(31);
            ttv_giahan = ttv;
        }
        private Boolean checkDieukien()
        {
            DateTime now = DateTime.Now;
            DateTime bd = dateBatdau.Value;
            DateTime kt = dateKetThuc.Value;

            if (bd > kt)
            {
                MessageBox.Show("Không được để ngày bắt đầu lớn hơn hạn thẻ", "Thông báo");
                return false;
            }
            if (kt - bd <= TimeSpan.FromDays(30))
            {
                MessageBox.Show("Hạn thẻ phải ít nhất 30 ngày so với ngày mở thẻ", "Thông báo");
                return false;
            }
            if (bd <= now.Date)
            {
                MessageBox.Show("Ngày mở thẻ phải lớn hơn ngày hiện tại", "Thông báo");
                return false;
            }
            return true;
        }
        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (checkDieukien())
            {
                ttv_giahan.SGNgayLapThe = dateBatdau.Value;
                ttv_giahan.SGNgayHetHan = dateKetThuc.Value;
                DocGia dg = dg_BUS.getDocGiaByMa(ttv_giahan.SGMaDocGia);
                if (ttv_BUS.updateTheThuVien(ttv_giahan))
                {
                    dg.SGTrangThai = true;
                    dg_BUS.updateTinhTrang(dg);
                    MessageBox.Show("Gia hạn thành công","Thông báo");
                    this.Dispose();
                } else
                {
                    MessageBox.Show("Gia hạn không thành công", "Thông báo");
                    this.Dispose();
                }
            }
        }
    }
}
