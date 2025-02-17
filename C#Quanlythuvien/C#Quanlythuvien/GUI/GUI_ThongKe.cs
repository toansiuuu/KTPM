using BUS;
using DTO;
using OfficeOpenXml;
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
    public partial class GUI_ThongKe : Form
    {
        PhieuNhapBUS pnBUS = new PhieuNhapBUS();
        PhieuTraBUS ptBUS = new PhieuTraBUS();
        public GUI_ThongKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại lựa chọn tệp
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn đường dẫn để lưu tệp Excel";
            saveFileDialog.FileName = "ThongKePhieuNhap.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Gọi phương thức để tạo và điền dữ liệu vào tệp Excel
                ExportToExcel(getAllPhieuNhapCoTrongListView(), saveFileDialog.FileName);
                MessageBox.Show("Thành Công!", "Thông Báo");
            }
        }
        static void ExportToExcel(List<PhieuNhap> listPN, string filePath)
        {
            // Tạo một gói Excel
            using (var package = new ExcelPackage())
            {
                // Tạo một trang tính mới
                var worksheet = package.Workbook.Worksheets.Add("Thống Kê");

                worksheet.Cells["A1"].Value = "Thống kê Nhập Hàng";

                // Merge các ô để tạo tiêu đề
                worksheet.Cells["A1:C1"].Merge = true;

                // Cài đặt kiểu chữ và cỡ chữ cho tiêu đề
                worksheet.Cells["A1:C1"].Style.Font.Size = 18;
                worksheet.Cells["A1:C1"].Style.Font.Bold = true;
                worksheet.Cells["A1:C1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Thiết lập tiêu đề cho các cột
                worksheet.Cells["A2"].Value = "Mã Phiếu Nhập";
                worksheet.Cells["B2"].Value = "Mã Nhà Cung Cấp";
                worksheet.Cells["C2"].Value = "Mã Nhân Viên";
                worksheet.Cells["D2"].Value = "Ngày Lập";
                worksheet.Cells["E2"].Value = "Tổng Tiền";

                // Thiết lập giá trị từ danh sách vào các ô từ dòng 3 trở đi
                for (int i = 0; i < listPN.Count; i++)
                {
                    worksheet.Cells["A" + (i + 3)].Value = listPN[i].SGMaPhieuNhap;
                    worksheet.Cells["B" + (i + 3)].Value = listPN[i].SGMaNCC;
                    worksheet.Cells["C" + (i + 3)].Value = listPN[i].SGMaNhanVien;
                    worksheet.Cells["D" + (i + 3)].Value = listPN[i].SGNgayNhap;
                    worksheet.Cells["E" + (i + 3)].Value = listPN[i].SGTongTien;
                }

                // Lưu tệp Excel
                FileInfo excelFile = new FileInfo(filePath);
                package.SaveAs(excelFile);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loadPhieuNhap(ListView lv ,List<PhieuNhap> list)
        {
            lv.Items.Clear();
            foreach (PhieuNhap pn in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pn.SGMaPhieuNhap; // Thiết lập giá trị cho cột chính (cột 0)
                item.SubItems.Add(pn.SGMaNCC); // Cột 1
                item.SubItems.Add(pn.SGMaNhanVien); // Cột 3
                item.SubItems.Add(pn.SGNgayNhap.ToString("MM/dd/yyyy")); // Cột 3
                item.SubItems.Add(pn.SGTongTien.ToString()); // Cột 3
                lv.Items.Add(item);
            }
            loadChart_PN();
        }
        public void load()
        {
            lv_phieuNhap.Columns[0].Width = (int)(lv_phieuNhap.Width / 5);
            lv_phieuNhap.Columns[1].Width = (int)(lv_phieuNhap.Width / 5);
            lv_phieuNhap.Columns[2].Width = (int)(lv_phieuNhap.Width / 5);
            lv_phieuNhap.Columns[3].Width = (int)(lv_phieuNhap.Width / 5);
            lv_phieuNhap.Columns[4].Width = (int)(lv_phieuNhap.Width / 5);

            lv_phieuNhap.GridLines = true;
            lv_phieuNhap.FullRowSelect = true;
            loadPhieuNhap(lv_phieuNhap, pnBUS.getAllPhieuNhapTTTrue());

            cb_timKiem.SelectedIndex = 0;
            cb_sapXep.SelectedIndex = 0;
            cb_thoiGian.SelectedIndex = 0;

            lv_phieutra.Columns[0].Width = (int)(lv_phieutra.Width / 3);
            lv_phieutra.Columns[1].Width = (int)(lv_phieutra.Width / 3);
            lv_phieutra.Columns[2].Width = (int)(lv_phieutra.Width / 3);


            cb_timKiem1.SelectedIndex = 0;
            cb_sapXep1.SelectedIndex = 0;
            cb_thoiGian1.SelectedIndex = 0;

            lv_phieutra.GridLines = true;
            lv_phieutra.FullRowSelect = true;
            loadPhieuTra(lv_phieutra, ptBUS.getAllPhieuTra());
        }
        public void loadPhieuTra(ListView lv, List<PhieuTra> list)
        {
            lv.Items.Clear();
            foreach (PhieuTra pt in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pt.SGMaPhieuMuon; // Thiết lập giá trị cho cột chính (cột 0)
                item.SubItems.Add(pt.SGNgayTra.ToString("MM/dd/yyyy")); // Cột 1
                item.SubItems.Add(pt.SGTienPhat.ToString()); // Cột 3
                lv.Items.Add(item);
            }
            loadChart_PT();
        }
        public void loadChart_PT()
        {
            List<PhieuTra> listPT = getAllPhieuTraCoTrongListView();
            chart_PT.Series["chartBDC"].Points.Clear();
            chart_PT.ChartAreas[0].AxisX.Title = "Mã phiếu mượn";
            chart_PT.ChartAreas[0].AxisY.Title = "Tiền nợ";
            foreach (PhieuTra pn in listPT)
            {
                chart_PT.Series["chartBDC"].Points.AddXY(pn.SGMaPhieuMuon, pn.SGTienPhat);
            }
            float sum = 0;
            for (int i = 0; i < listPT.Count; i++)
            {
                sum += listPT[i].SGTienPhat;
            }
            lbl_tongTP.Text = sum.ToString();
            lbl_soLuongPT.Text = listPT.Count.ToString();
        }
        private void GUI_ThongKe_Load(object sender, EventArgs e)
        {
            load();
            loadChart_PN();
            loadChart_PT();
        }
        public void executeSearchPN()
        {
            cb_sapXep.SelectedIndex = 0;
            List<PhieuNhap> listPN = pnBUS.getAllPhieuNhapTTTrue();
            string keyWord = txt_timKiem.Text.ToLower();
            listPN = listPN.Where(
                pn =>
                (cb_timKiem.SelectedIndex==0 && pn.SGMaPhieuNhap.ToLower().Contains(keyWord)) ||
                (cb_timKiem.SelectedIndex == 1 && pn.SGMaNCC.ToLower().Contains(keyWord))
                ).ToList();
            if (cb_thoiGian.SelectedIndex == 0)
            {

            }else if (cb_thoiGian.SelectedIndex==1)
            {
               listPN = listPN.Where(
               pn =>
               pn.SGNgayNhap.ToString().Contains(nb_Nam.Value.ToString())
               ).ToList();
            }
            else if (cb_thoiGian.SelectedIndex == 2)
            {
                int thang = int.Parse(nb_thang.Value.ToString());
                int nam = int.Parse(nb_Nam.Value.ToString());
                listPN = listPN.Where(
                pn =>
                pn.SGNgayNhap.Month==thang && pn.SGNgayNhap.Year == nam
                ).ToList();
            }
            else if (cb_thoiGian.SelectedIndex == 3)
            {
                DateTime from = dp_tuNgay.Value;
                DateTime to = dp_denNgay.Value;
                listPN = listPN.Where(
               pn =>
               pn.SGNgayNhap >= from && pn.SGNgayNhap <= to
               ).ToList();
            }
                loadPhieuNhap(lv_phieuNhap, listPN);
        }
        private void cb_timKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeSearchPN();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            executeSearchPN();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            executeSearchPN();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            executeSearchPN();
        }

        private void dtp_ngmuon_ValueChanged(object sender, EventArgs e)
        {
            executeSearchPN();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            executeSearchPN();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeSearchPN();
            if(cb_thoiGian.SelectedIndex == 0)
            {
                nb_Nam.Visible = false;
                nb_thang.Visible = false;
                dp_denNgay.Visible = false;
                dp_tuNgay.Visible=false;
            }else if(cb_thoiGian.SelectedIndex == 1)
            {
                nb_Nam.Visible = true;
                nb_thang.Visible = false;
                dp_denNgay.Visible = false;
                dp_tuNgay.Visible = false;
            }
            else if (cb_thoiGian.SelectedIndex == 2)
            {
                nb_Nam.Visible = true;
                nb_thang.Visible = true;
                dp_denNgay.Visible = false;
                dp_tuNgay.Visible = false;
            }
            else if (cb_thoiGian.SelectedIndex == 3)
            {
                nb_Nam.Visible = false;
                nb_thang.Visible = false;
                dp_denNgay.Visible = true;
                dp_tuNgay.Visible = true;
            }

        }
        public List<PhieuNhap> getAllPhieuNhapCoTrongListView()
        {
            List<PhieuNhap> list = new List<PhieuNhap>();
            foreach(ListViewItem item in lv_phieuNhap.Items )
            {
                PhieuNhap a = new PhieuNhap();
                a.SGMaPhieuNhap = item.SubItems[0].Text;
                a.SGMaNCC = item.SubItems[1].Text;
                a.SGMaNhanVien = item.SubItems[2].Text;
                string dateStringFormLV = item.SubItems[3].Text;
                DateTime parsedDateTime;
                bool parseSuccess = DateTime.TryParseExact(dateStringFormLV, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDateTime);
                if (parseSuccess)
                {
                    a.SGNgayNhap = parsedDateTime;
                }
                else
                {
                    // Xử lý trường hợp chuỗi không hợp lệ
                    Console.WriteLine("Chuỗi không hợp lệ");
                }
                a.SGTongTien = float.Parse(item.SubItems[4].Text);
                list.Add(a);
            }
            return list;
        }
        private void cb_sapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_sapXep.SelectedIndex == 0)
            {

            }else if (cb_sapXep.SelectedIndex == 1)
            {
                List<PhieuNhap> listPN = getAllPhieuNhapCoTrongListView();
                listPN.Sort((x, y) => x.SGTongTien.CompareTo(y.SGTongTien));
                loadPhieuNhap(lv_phieuNhap,listPN);
            }
            else if (cb_sapXep.SelectedIndex == 2)
            {
                List<PhieuNhap> listPN = getAllPhieuNhapCoTrongListView();
                listPN.Sort((x, y) => x.SGNgayNhap.CompareTo(y.SGNgayNhap
                    ));
                loadPhieuNhap(lv_phieuNhap, listPN);
            }
        }
        public delegate void sendListPN(List<PhieuNhap> listPN);
        public sendListPN sendED;
        public void loadChart_PN()
        {
            List<PhieuNhap> listPN = getAllPhieuNhapCoTrongListView();
            chart_PN.Series["chartBDC"].Points.Clear();
            chart_PN.ChartAreas[0].AxisX.Title = "Ngày Nhập";
            chart_PN.ChartAreas[0].AxisY.Title = "Tổng Tiền";
            foreach (PhieuNhap pn in listPN)
            {
                DateTime time = pn.SGNgayNhap;
                string timeString = time.Day.ToString() + "/" + time.Month.ToString() + "/" + time.Year.ToString();
                chart_PN.Series["chartBDC"].Points.AddXY(timeString, pn.SGTongTien);
            }
            float sum = 0;
            lbl_tongPN.Text = listPN.Count.ToString();
            for (int i = 0; i < listPN.Count; i++)
            {
                sum += listPN[i].SGTongTien;
            }
            lbl_TongTien.Text = sum.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lv_phieutra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_timKiem1_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeTimKiemPhieuTra();
        }
        public void executeTimKiemPhieuTra()
        {
            cb_sapXep1.SelectedIndex = 0;
            List<PhieuTra> listPT = ptBUS.getAllPhieuTra();
            string keyWord = txt_timKiem1.Text.ToLower();
            listPT = listPT.Where(
                pt =>
                (cb_timKiem1.SelectedIndex == 0 && pt.SGMaPhieuMuon.ToLower().Contains(keyWord)) 
                ).ToList();
            if (cb_thoiGian1.SelectedIndex == 0)
            {

            }
            else if (cb_thoiGian1.SelectedIndex == 1)
            {
                listPT = listPT.Where(
                pn =>
                pn.SGNgayTra.ToString().Contains(nb_nam1.Value.ToString())
                ).ToList();
            }
            else if (cb_thoiGian1.SelectedIndex == 2)
            {
                int thang = int.Parse(nb_thang1.Value.ToString());
                int nam = int.Parse(nb_nam1.Value.ToString());
                listPT = listPT.Where(
                pn =>
                pn.SGNgayTra.Month == thang && pn.SGNgayTra.Year == nam
                ).ToList();
            }
            else if (cb_thoiGian1.SelectedIndex == 3)
            {
                DateTime from = dp_tuNgay1.Value;
                DateTime to = dp_denNgay1.Value;
                listPT = listPT.Where(
               pn =>
               pn.SGNgayTra >= from && pn.SGNgayTra <= to
               ).ToList();
            }
            loadPhieuTra(lv_phieutra, listPT);
        }

        private void txt_timKiem1_TextChanged(object sender, EventArgs e)
        {
            executeTimKiemPhieuTra();
        }

        private void cb_thoiGian1_SelectedIndexChanged(object sender, EventArgs e)
        {
            executeTimKiemPhieuTra();
            if (cb_thoiGian1.SelectedIndex == 0)
            {
                nb_nam1.Visible = false;
                nb_thang1.Visible = false;
                dp_denNgay1.Visible = false;
                dp_tuNgay1.Visible = false;
            }
            else if (cb_thoiGian1.SelectedIndex == 1)
            {
                nb_nam1.Visible = true;
                nb_thang1.Visible = false;
                dp_denNgay1.Visible = false;
                dp_tuNgay1.Visible = false;
            }
            else if (cb_thoiGian1.SelectedIndex == 2)
            {
                nb_nam1.Visible = true;
                nb_thang1.Visible = true;
                dp_denNgay1.Visible = false;
                dp_tuNgay1.Visible = false;
            }
            else if (cb_thoiGian1.SelectedIndex == 3)
            {
                nb_nam1.Visible = false;
                nb_thang1.Visible = false;
                dp_denNgay1.Visible = true;
                dp_tuNgay1.Visible = true;
            }
        }

        private void nb_nam1_ValueChanged(object sender, EventArgs e)
        {
            executeTimKiemPhieuTra();
        }

        private void nb_thang1_ValueChanged(object sender, EventArgs e)
        {
            executeTimKiemPhieuTra();
        }

        private void dp_tuNgay1_ValueChanged(object sender, EventArgs e)
        {
            executeTimKiemPhieuTra();
        }

        private void dp_denNgay1_ValueChanged(object sender, EventArgs e)
        {
            executeTimKiemPhieuTra();
        }
        public List<PhieuTra> getAllPhieuTraCoTrongListView()
        {
            List<PhieuTra> list = new List<PhieuTra>();
            foreach (ListViewItem item in lv_phieutra.Items)
            {
                PhieuTra a = new PhieuTra();
                a.SGMaPhieuMuon = item.SubItems[0].Text;
                a.SGTienPhat = float.Parse(item.SubItems[2].Text);
                string dateStringFormLV = item.SubItems[1].Text;
                DateTime parsedDateTime;
                bool parseSuccess = DateTime.TryParseExact(dateStringFormLV, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDateTime);
                if (parseSuccess)
                {
                    a.SGNgayTra = parsedDateTime;
                }
                else
                {
                    // Xử lý trường hợp chuỗi không hợp lệ
                    Console.WriteLine("Chuỗi không hợp lệ");
                }
            
                list.Add(a);
            }
            return list;
        }
        private void cb_sapXep1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sapXep1.SelectedIndex == 0)
            {

            }
            else if (cb_sapXep1.SelectedIndex == 1)
            {
                List<PhieuTra> listPT = getAllPhieuTraCoTrongListView();
                listPT.Sort((x, y) => x.SGTienPhat.CompareTo(y.SGTienPhat));
                loadPhieuTra(lv_phieutra, listPT);
            }
            else if (cb_sapXep1.SelectedIndex == 2)
            {
                List<PhieuTra> listPT = getAllPhieuTraCoTrongListView();
                listPT.Sort((x, y) => x.SGNgayTra.CompareTo(y.SGNgayTra));
                loadPhieuTra(lv_phieutra, listPT);
            }
        }
        static void ExportToExcel2(List<PhieuTra> listPN, string filePath)
        {
            // Tạo một gói Excel
            using (var package = new ExcelPackage())
            {
                // Tạo một trang tính mới
                var worksheet = package.Workbook.Worksheets.Add("Thống Kê");

                worksheet.Cells["A1"].Value = "Thống kê Tiền Phạt";

                // Merge các ô để tạo tiêu đề
                worksheet.Cells["A1:C1"].Merge = true;

                // Cài đặt kiểu chữ và cỡ chữ cho tiêu đề
                worksheet.Cells["A1:C1"].Style.Font.Size = 18;
                worksheet.Cells["A1:C1"].Style.Font.Bold = true;
                worksheet.Cells["A1:C1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Thiết lập tiêu đề cho các cột
                worksheet.Cells["A2"].Value = "Mã Phiếu Mượn";
                worksheet.Cells["B2"].Value = "Ngày Trả";
                worksheet.Cells["C2"].Value = "Tiền Phạt";

                // Thiết lập giá trị từ danh sách vào các ô từ dòng 3 trở đi
                for (int i = 0; i < listPN.Count; i++)
                {
                    worksheet.Cells["A" + (i + 3)].Value = listPN[i].SGMaPhieuMuon;
                    worksheet.Cells["B" + (i + 3)].Value = listPN[i].SGNgayTra.Date.ToString("dd/MM/yyyy");
                    worksheet.Cells["C" + (i + 3)].Value = listPN[i].SGTienPhat;
                }
                // Lưu tệp Excel
                FileInfo excelFile = new FileInfo(filePath);
                package.SaveAs(excelFile);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại lựa chọn tệp
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn đường dẫn để lưu tệp Excel";
            saveFileDialog.FileName = "ThongKeTienPhat.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Gọi phương thức để tạo và điền dữ liệu vào tệp Excel
                ExportToExcel2(getAllPhieuTraCoTrongListView(), saveFileDialog.FileName);
                MessageBox.Show("Thành Công!", "Thông Báo");
            }
        }
    }
}
