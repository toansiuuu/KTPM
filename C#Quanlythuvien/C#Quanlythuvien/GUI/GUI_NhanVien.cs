using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using BUS;
using DTO;
using OfficeOpenXml;
//using OfficeOpenXml;
//using OfficeOpenXml.Style;
//using System.IO;
//using Excel=Microsoft.Office.Interop.Excel;


namespace GUI
{
    public partial class GUI_NhanVien : Form
    {

        NhanVienBUS bus = new NhanVienBUS();
        public bool isVisibleBttnSua = true;
        public GUI_NhanVien()
        {
            InitializeComponent();
            cb_timKiem.SelectedIndex = 0;
            cb_gioiTinh.SelectedIndex = 0;
            cb_trangThai.SelectedIndex = 0;
            
        }
        public GUI_NhanVien(String chiTiet)
        {
            InitializeComponent();
            cb_timKiem.SelectedIndex = 0;
            cb_gioiTinh.SelectedIndex = 0;
            cb_trangThai.SelectedIndex = 0;
            SetUpAccessPermissions(chiTiet);
        }
        public void SetUpAccessPermissions(String chiTiet)
        {
            if (chiTiet.Trim().Equals(""))
            {
                btn_them.Visible = false;
                isVisibleBttnSua = false;
            }
            else
            {
                if (!chiTiet.Contains("Thêm"))
                {
                    btn_them.Visible = false;
                }
                if (!chiTiet.Contains("Sửa"))
                {
                    isVisibleBttnSua = false;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            generateItems();
           
        }

        private void ThongTin1_Clicked(object sender, EventArgs e)
        {
            frmSuaNhanVien frmSua = new frmSuaNhanVien(isVisibleBttnSua);
            var thongTin1 = sender as NhanVienUserControl;
            string maNV = thongTin1.MaNV;
            NhanVienDTO nv = new NhanVienDTO();
            nv=bus.getNhanVienByMa(maNV);
            frmSua.setThongTin(nv);
            frmSua.btn_CapNhat_Clicked += btn_CapNhat_Clicked;
            frmSua.ShowDialog();
        }
       
        public void generateItems()
        {
            flowLayoutPanel1.Controls.Clear();
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            list = bus.getAllNhanVien();
            NhanVienUserControl[] items = new NhanVienUserControl[list.Count];    
            for ( int i = 0; i < list.Count; i++)
            {
                items[i]=new NhanVienUserControl();
                items[i].MaNV = list[i].MaNhanVien;
                items[i].TenNV = list[i].TenNhanVien;
                items[i].DiaChi = list[i].DiaChi;
                items[i].Sdt = list[i].Sdt;
                items[i].Icon = list[i].Img;
                items[i].setThongTin();
                flowLayoutPanel1.Controls.Add(items[i]);
                items[i].ThongTin1Clicked += ThongTin1_Clicked;
            }
        }
        public void btn_CapNhat_Clicked(object sender, EventArgs e)
        {
            generateItems();
            if (sender is frmSuaNhanVien)
            {
                var frmSua = sender as frmSuaNhanVien;
                frmSua.Close();
            }
        }
        private void btn_Them_Clicked(object sender, EventArgs e)
        {
            generateItems();
            if (sender is formThemNhanVien)
            {
                var frmThem = sender as formThemNhanVien;
                frmThem.Close();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            formThemNhanVien frmThem = new formThemNhanVien();
            frmThem.btn_Them_Clicked +=btn_Them_Clicked;
            frmThem.ShowDialog();
        }

        private void cb_gioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeSearch();
        }
        public void generateItems(List<NhanVienDTO> list)
        {
            flowLayoutPanel1.Controls.Clear();
            NhanVienUserControl[] items = new NhanVienUserControl[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                items[i] = new NhanVienUserControl();
                items[i].MaNV = list[i].MaNhanVien;
                items[i].TenNV = list[i].TenNhanVien;
                items[i].DiaChi = list[i].DiaChi;
                items[i].Sdt = list[i].Sdt;
                items[i].Icon = list[i].Img;
                items[i].setThongTin();
                flowLayoutPanel1.Controls.Add(items[i]);
                items[i].ThongTin1Clicked += ThongTin1_Clicked;
            }
        }
        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            executeSearch();
        }
        //private void cb_trangThai_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    executeSearch();
        //}
        public void executeSearch()
        {
            string searchText = txt_timKiem.Text.ToLower();
            string searchCriteria = cb_timKiem.SelectedItem.ToString();
            //string selectedGioiTinh = cb_gioiTinh.SelectedItem.ToString();
            List<NhanVienDTO> list = bus.getAllNhanVien();
            list = list.Where(nv =>
                (searchCriteria == "Mã" && nv.MaNhanVien.ToLower().Contains(searchText.ToLower())) ||
                (searchCriteria == "Tên" && nv.TenNhanVien.ToLower().Contains(searchText.ToLower())) ||
                (searchCriteria == "Chức vụ" && nv.ChucVu.ToLower().Contains(searchText.ToLower()))
            ).ToList();
            if (cb_gioiTinh.SelectedIndex==1)
            {
                bool genderFilter = true;
                list = list.Where(nv => nv.GioiTinh == genderFilter).ToList();
            }
            else if (cb_gioiTinh.SelectedIndex == 2)
            {
                bool genderFilter = false;
                list = list.Where(nv => nv.GioiTinh == genderFilter).ToList();
            }
            if (cb_trangThai.SelectedIndex==1)
            {
                bool statusFilter = true;
                list = list.Where(nv => nv.TrangThai == statusFilter).ToList();
            }
            else if (cb_trangThai.SelectedIndex == 2)
            {
                bool statusFilter = false;
                list = list.Where(nv => nv.TrangThai == statusFilter).ToList();
            }
            generateItems(list);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeSearch();
        }

        private void cb_timKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeSearch();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        static void ExportToExcel(List<NhanVienDTO> list, string filePath)
        {
            // Tạo một gói Excel
            using (var package = new ExcelPackage())
            {
                // Tạo một trang tính mới
                var worksheet = package.Workbook.Worksheets.Add("Nhân Viên");

                worksheet.Cells["A1"].Value = "Nhân Viên";

                // Merge các ô để tạo tiêu đề
                worksheet.Cells["A1:C1"].Merge = true;

                // Cài đặt kiểu chữ và cỡ chữ cho tiêu đề
                worksheet.Cells["A1:C1"].Style.Font.Size = 18;
                worksheet.Cells["A1:C1"].Style.Font.Bold = true;
                worksheet.Cells["A1:C1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Thiết lập tiêu đề cho các cột
                worksheet.Cells["A2"].Value = "Mã Nhân Viên";
                worksheet.Cells["B2"].Value = "Tên Nhân Viên";
                worksheet.Cells["C2"].Value = "Giới Tính";
                worksheet.Cells["D2"].Value = "Ngày Sinh";
                worksheet.Cells["E2"].Value = "Địa Chỉ";
                worksheet.Cells["F2"].Value = "Chức Vụ";
                worksheet.Cells["G2"].Value = "SĐT";
                worksheet.Cells["H2"].Value = "Trạng Thái";
                // Thiết lập giá trị từ danh sách vào các ô từ dòng 3 trở đi
                for (int i = 0; i < list.Count; i++)
                {
                    worksheet.Cells["A" + (i + 3)].Value = list[i].MaNhanVien;
                    worksheet.Cells["B" + (i + 3)].Value = list[i].TenNhanVien;
                    if (list[i].GioiTinh)
                    {
                        worksheet.Cells["C" + (i + 3)].Value = "Nam";
                    }
                    else
                    {
                        worksheet.Cells["C" + (i + 3)].Value = "Nữ";
                    }
                    worksheet.Cells["D" + (i + 3)].Value = list[i].NgaySinh.Date.ToString("dd/MM/yyyy");
                    worksheet.Cells["E" + (i + 3)].Value = list[i].DiaChi;
                    worksheet.Cells["F" + (i + 3)].Value = list[i].ChucVu;
                    worksheet.Cells["G" + (i + 3)].Value = list[i].Sdt;
                    if (list[i].TrangThai)
                    {
                        worksheet.Cells["H" + (i + 3)].Value = "Đang Hoạt Động";
                    }
                    else
                    {
                        worksheet.Cells["H" + (i + 3)].Value = "Ngừng Hoạt Động";
                    }
                }
                // Lưu tệp Excel
                FileInfo excelFile = new FileInfo(filePath);
                package.SaveAs(excelFile);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại lựa chọn tệp
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn đường dẫn để lưu tệp Excel";
            saveFileDialog.FileName = "NhanVien.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Gọi phương thức để tạo và điền dữ liệu vào tệp Excel
                ExportToExcel(bus.getAllNhanVien(), saveFileDialog.FileName);
                MessageBox.Show("Thành Công!", "Thông Báo");
            }
        }
    }
}
