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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class Quanlysach : Form
    {
        private static bool status1 = true;
        private static String path_anh = "default.png";
        private static String duongdananh = "";
        private TuaSachBUS ts_BUS = new TuaSachBUS();
        private TacGiaBus tg_BUS = new TacGiaBus();
        private TheLoaiBUS tl_BUS = new TheLoaiBUS();
        private ChiTietTheLoaiBUS cttl_BUS = new ChiTietTheLoaiBUS();
        private NhaXuatBanBUS nxb_BUS = new NhaXuatBanBUS();

        public Quanlysach(bool isVisibleAddBook, bool isVisibleFixBook)
        {
            InitializeComponent();
            LoadTableSach();
            loadComboxTacGia();
            loadComboxTheLoai();
            loadComboxNXB();
            if (!isVisibleAddBook)
            {
                btnThem.Visible = false;
                btnXoa.Visible = false;
                button1.Visible = false;
            }
            if (!isVisibleFixBook)
            {
                btnUpdate.Visible = false;
                btnTrangThai.Visible = false;
            }
        }

        
        private List<string> TachVaLoaiBoKhoangTrang(string chuoi)
        {
            List<string> danhSachTu = new List<string>();

            // Tách chuỗi thành mảng các từ
            string[] cacTu = chuoi.Split(',');

            // Loại bỏ khoảng trắng từ mỗi từ và thêm vào danh sách
            foreach (string tu in cacTu)
            {
                danhSachTu.Add(tu.Trim());
            }

            return danhSachTu;
        }

        private TuaSach getModelCell()
        {
            TuaSach ts = new TuaSach();
            ts.SGMaTuaSach = txtMaSach.Text;
            ts.SGTenTuaSach = txtTenSach.Text;
            ts.SGMoTa = txtMota.Text;
            ts.SGNamXB = Convert.ToInt32(txtNamXB.Text);
            ts.SGMaNXB = cbNxb.SelectedItem.ToString();
            ts.SGSoLuong = Convert.ToInt32(txtSoluong.Text);
            ts.SGMaTacGia = cbTacGia.SelectedItem.ToString();
            ts.SGTrangThai = status1;
            //Anh
            ts.SGImage = path_anh;

            return ts;
        }
        private TuaSach getModel()
        {
            //Sach
            TuaSach ts = new TuaSach();
            ts.SGMaTuaSach = txtMaSach.Text;
            ts.SGTenTuaSach = txtTenSach.Text;
            ts.SGMoTa = txtMota.Text;
            ts.SGNamXB = Convert.ToInt32(txtNamXB.Text);
            ts.SGMaNXB = cbNxb.SelectedItem.ToString();
            ts.SGSoLuong = Convert.ToInt32(txtSoluong.Text);
            ts.SGMaTacGia = cbTacGia.SelectedItem.ToString();
            ts.SGTrangThai = true;
            //Anh
            ts.SGImage = path_anh;

            return ts;

        }
        private List<String> getModelTheLoai(string chuoi)
        {
            List<String> theloai = TachVaLoaiBoKhoangTrang(chuoi);
            return theloai;
        }
        private void setModel(TuaSach ts){

            //MaTacGia
            int index = cbTacGia.Items.IndexOf(ts.SGMaTacGia);
            cbTacGia.SelectedIndex = index;

            //MaNXB
            int index1 = cbNxb.Items.IndexOf(ts.SGMaNXB);
            cbNxb.SelectedIndex = index1;

            //TheLoai
            List<ChiTietTheLoai> list_cttl = cttl_BUS.GetChiTietTheLoaiByID(ts.SGMaTuaSach);
            txtTheloai.Text = "";
            foreach (ChiTietTheLoai x in list_cttl)
            {
                TheLoaiDTO tl = new TheLoaiDTO();
                tl = tl_BUS.getTlByID(x.SGMaTheLoai);
                txtTheloai.Text = txtTheloai.Text + tl.TenTL + ",";
            }
            if (txtTheloai.Text != "")
            {
                txtTheloai.Text = txtTheloai.Text.Substring(0, txtTheloai.Text.Length - 1);
            }

            txtMaSach.Text = ts.SGMaTuaSach;
            txtTenSach.Text = ts.SGTenTuaSach;
            //txtMaNXB.Text = ts.SGMaNXB;
            txtNamXB.Text = ts.SGNamXB.ToString();
            txtSoluong.Text = ts.SGSoLuong.ToString();
            txtMota.Text = ts.SGMoTa;
            status1 = ts.SGTrangThai;

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "Sach", ts.SGImage);
            imageSach.Image = new Bitmap(imagePath);
            path_anh = ts.SGImage;
        }

        private void loadComboxTheLoai() {
            List<TheLoaiDTO> list_tl = tl_BUS.getAllTheLoai();
            cbTheLoai.Items.Clear();
            cbTheLoai.Items.Add("Tất cả");
            foreach (TheLoaiDTO x in list_tl)
            {
                cbTheLoai.Items.Add(x.TenTL);
            }
        }

        private void loadComboxNXB()
        {
            List<NhaXuatBan> list_nxb = nxb_BUS.getAllListNXB();
            cbNxb.Items.Clear();
            foreach (NhaXuatBan x in list_nxb)
            {
                cbNxb.Items.Add(x.SGMaNXB);
            }
        }
        private void loadComboxTacGia()
        {
            List<TacGiaDTO> ls_tacgia = tg_BUS.getAllTacGia();
            cbTacGia.Items.Clear();
            foreach (TacGiaDTO x in ls_tacgia)
            {
                cbTacGia.Items.Add(x.MaTG);
            }
        }
        private String getTheloai(TuaSach ts)
        {
            String theloai = "";
            List<ChiTietTheLoai> list_cttl = cttl_BUS.GetChiTietTheLoaiByIDSach(ts.SGMaTuaSach);
            List<TheLoaiDTO> list_tl = tl_BUS.getAllTheLoai();
            foreach (TheLoaiDTO tl in list_tl)
            {
                foreach (ChiTietTheLoai cttl in list_cttl)
                {
                    if (tl.MaTL == cttl.SGMaTheLoai)
                    {
                        if (theloai == "")
                        {
                            theloai += tl.TenTL;
                        }
                        else
                        {
                            theloai += ", " + tl.TenTL;
                        }

                    }
                }
            }
            return theloai;
        }
        private void LoadTableSach()
        {
            
            tableSach.Rows.Clear();
            foreach (TuaSach tuasach in ts_BUS.getAllTuaSach())
                {
                tableSach.Rows.Add(
                    tuasach.SGMaTuaSach,
                    tuasach.SGTenTuaSach,
                    tuasach.SGMaTacGia,
                    getTheloai(tuasach),
                    tuasach.SGMaNXB,
                    tuasach.SGNamXB,
                    tuasach.SGSoLuong,
                    tuasach.SGMoTa,
                    tuasach.SGImage,
                    tuasach.SGTrangThai ? "Hiện" : "Ẩn"
                    ); ;
                           
                    
                }
        }
        private void Quanlysach_Load(object sender, EventArgs e)
        {
            txtMaSach.Text = ts_BUS.getLastMaTuaSach();
            txtSoluong.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn hình ảnh";
                openFileDialog.Filter = "Tệp hình ảnh|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Tất cả các tệp|*.*";

                // Nếu người dùng chọn một tệp hợp lệ
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn của tệp hình ảnh được chọn
                    string selectedImagePath = openFileDialog.FileName;
                    path_anh = openFileDialog.SafeFileName;
                    duongdananh = selectedImagePath;
                    
                    // Gọi hàm để hiển thị hình ảnh trong PictureBox
                    DisplayImage(selectedImagePath);
                }
            }

        }

        private void DisplayImage(string imagePath)
        {
            try
            {
                // Tạo một đối tượng hình ảnh từ đường dẫn tệp
                Image selectedImage = Image.FromFile(imagePath);

                // Hiển thị hình ảnh trong PictureBox
                imageSach.Image = selectedImage;
                imageSach.SizeMode = PictureBoxSizeMode.Zoom; // Có thể điều chỉnh theo ý muốn

                // Có thể cần điều chỉnh kích thước PictureBox để vừa với hình ảnh
                // pictureBox1.Size = selectedImage.Size;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnTrangThai.Enabled = true;
            if (e.RowIndex >= 0 && e.RowIndex < tableSach.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = tableSach.Rows[e.RowIndex];

                if (selectedRow.Cells["maSach"].Value != null)
                {
                    string maTuaSach = selectedRow.Cells["maSach"].Value.ToString();

                    TuaSach tuaSach = ts_BUS.getTuaSachBangMa(maTuaSach);

                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
                    string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
                    string imagePath = Path.Combine(projectDirectory2, "Image", "Sach", tuaSach.SGImage);
                    duongdananh = imagePath;

                    if (tuaSach == null)
                    {
                        MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        setModel(tuaSach);
                    }
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnTrangThai.Enabled = false;
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "Sach", "default.png");
            imageSach.Image = new Bitmap(imagePath);
            //txtMaNXB.Text = "";
            txtTenSach.Text = "";
            txtSoluong.Text = "0";
            txtTheloai.Text = "";
            cbTacGia.SelectedIndex = 0;
            cbNxb.SelectedIndex = 0;
            txtNamXB.Text = "";
            txtMota.Text = "";
            path_anh = "default.png";
            duongdananh = imagePath;
            txtMaSach.Text = ts_BUS.getLastMaTuaSach();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String getPath()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
            string imagePath = Path.Combine(projectDirectory2, "Image", "Sach",path_anh);           
            return imagePath;
        }


        private Boolean checkValidateThem()
        {
            NhaXuatBan nxb = nxb_BUS.getNhaXuatBanByID(cbNxb.SelectedItem.ToString());
            TacGiaDTO tg = tg_BUS.getTacGiaByMa(cbTacGia.SelectedItem.ToString());

            if (!nxb.SGTrangThai) {
                MessageBox.Show("Nhà xuất bản ngừng hoạt động");
                return false;
            }
            if (!tg.TinhTrang)
            {
                MessageBox.Show("Tác giả ngừng hoạt động");
                return false;
            }
            if (!IsYearFormat(txtNamXB.Text))
            {
                MessageBox.Show("Nhập năm sai định dạng");
                return false;
            }
           
            if (txtTheloai.Text == "" || txtSoluong.Text == "" || txtNamXB.Text == "" || txtTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return false;
            }
            return true;
        }

        public bool isNull()
        {
            bool flag = false;
            if (cbNxb.SelectedIndex == -1 || txtTenSach.Text.Trim().Equals("") 
            || txtNamXB.Text.Trim().Equals("") || cbTacGia.SelectedIndex == -1 ||
            txtTheloai.Text.Trim().Equals(""))
            {
                flag = true;
            }
            return flag;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isNull())
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin!", "Thông Báo");
            }
            else
            {
                if (checkValidateThem())
                {
                    TuaSach ts = getModel();
                    List<String> lstl = getModelTheLoai(txtTheloai.Text);
                    if (ts_BUS.addTuaSach(ts) == 1)
                    {
                        String sourcePath = duongdananh;
                        String destinationPath = getPath();
                        if (sourcePath != destinationPath)
                        {
                            File.Copy(sourcePath, destinationPath, true);
                        }

                        foreach (String x in lstl)
                        {
                            foreach (TheLoaiDTO tl in tl_BUS.getAllTheLoai())
                            {
                                if (tl.TenTL == x)
                                {
                                    cttl_BUS.addChiTietTheloai(ts.SGMaTuaSach, tl.MaTL);
                                }
                            }
                        }

                        MessageBox.Show("Thêm thành công");
                    }
                    else if (ts_BUS.addTuaSach(ts) == 3)
                    {
                        MessageBox.Show("Trùng mã sach");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                    LoadTableSach();
                }
            }
        }

        private void btnTheloai_Click(object sender, EventArgs e)
        {
            int soTuDaXoa = 0;
            String chuoi = txtTheloai.Text;
            if (chuoi == "")
            {
                MessageBox.Show("Thể loại trống");
            }
            if (soTuDaXoa < chuoi.Split(',').Length)
            {
                // Tách chuỗi thành mảng các từ
                string[] tu = chuoi.Split(',');

                // Xóa từ cuối cùng
                tu[tu.Length - 1] = tu[tu.Length - 1].Trim();
                chuoi = string.Join(",", tu, 0, tu.Length - 1);

                // Cập nhật số từ đã xóa
                soTuDaXoa++;

                // Hiển thị chuỗi đã xóa trong TextBox
                txtTheloai.Text = chuoi;
            }
            

        }

        private void cbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTheLoai.SelectedItem != null)
            {
                bool flag = true;
                string giaTriDuocChon = cbTheLoai.SelectedItem.ToString();
                if (txtTheloai.Text.Contains(","))
                {
                    string[] resultArray = txtTheloai.Text.Split(',');
                    foreach (string item in resultArray)
                    {
                        if (giaTriDuocChon.Equals(item))
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                else
                {
                    if (txtTheloai.Text.Equals(giaTriDuocChon))
                    {
                        flag = false;
                    }
                }
                if (giaTriDuocChon == "Tất cả" && !txtTheloai.Text.Equals(""))
                {
                    txtTheloai.Text = "";
                }
                if (flag)
                {
                    switch (giaTriDuocChon)
                    {
                        case "Tất cả":
                            List<TheLoaiDTO> list_tl = tl_BUS.getAllTheLoai();
                            foreach (TheLoaiDTO x in list_tl)
                            {
                                txtTheloai.Text += x.TenTL + ",";
                            }
                            txtTheloai.Text = txtTheloai.Text.Substring(0, txtTheloai.Text.Length - 2);
                            break;
                        default:
                            List<TheLoaiDTO> list_tl1 = tl_BUS.getAllTheLoai();
                            foreach (TheLoaiDTO x in list_tl1)
                            {
                                if (x.TenTL == giaTriDuocChon)
                                {
                                    if (txtTheloai.Text == "")
                                    {
                                        txtTheloai.Text += x.TenTL;
                                    }
                                    else
                                    {
                                        txtTheloai.Text += "," + x.TenTL;
                                    }
                                }
                            }
                            break;
                    }
                }
            }
        }


        static void ExportToExcel(List<TuaSach> list, string filePath)
        {
            // Tạo một gói Excel
            using (var package = new ExcelPackage())
            {
                // Tạo một trang tính mới
                var worksheet = package.Workbook.Worksheets.Add("Sách");

                worksheet.Cells["A1"].Value = "Sách";

                // Merge các ô để tạo tiêu đề
                worksheet.Cells["A1:C1"].Merge = true;

                // Cài đặt kiểu chữ và cỡ chữ cho tiêu đề
                worksheet.Cells["A1:C1"].Style.Font.Size = 18;
                worksheet.Cells["A1:C1"].Style.Font.Bold = true;
                worksheet.Cells["A1:C1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Thiết lập tiêu đề cho các cột
                worksheet.Cells["A2"].Value = "Mã Tựa Sách";
                worksheet.Cells["B2"].Value = "Tên Tựa Sách";
                worksheet.Cells["C2"].Value = "Số Lượng";
                worksheet.Cells["D2"].Value = "Mã Tác Giả";
                worksheet.Cells["E2"].Value = "Mã NXB";
                worksheet.Cells["F2"].Value = "Năm Xuất Bản";
                worksheet.Cells["G2"].Value = "Mô Tả";
                worksheet.Cells["H2"].Value = "Trạng Thái";
                // Thiết lập giá trị từ danh sách vào các ô từ dòng 3 trở đi
                for (int i = 0; i < list.Count; i++)
                {
                    worksheet.Cells["A" + (i + 3)].Value = list[i].SGMaTuaSach;
                    worksheet.Cells["B" + (i + 3)].Value = list[i].SGTenTuaSach;
                    worksheet.Cells["C" + (i + 3)].Value = list[i].SGSoLuong;
                    worksheet.Cells["D" + (i + 3)].Value = list[i].SGMaTacGia;
                    worksheet.Cells["E" + (i + 3)].Value = list[i].SGMaNXB;
                    worksheet.Cells["F" + (i + 3)].Value = list[i].SGNamXB;
                    worksheet.Cells["G" + (i + 3)].Value = list[i].SGMoTa;
                    if (list[i].SGTrangThai)
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
        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại lựa chọn tệp
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn đường dẫn để lưu tệp Excel";
            saveFileDialog.FileName = "Sach.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Gọi phương thức để tạo và điền dữ liệu vào tệp Excel
                ExportToExcel(ts_BUS.getAllTuaSach(), saveFileDialog.FileName);
                MessageBox.Show("Thành Công!", "Thông Báo");
            }
        }

        private void txtNamXB_TextChanged(object sender, EventArgs e)
        {

        }


        static List<string> ChiaChuoi(string input, char separator)
        {
            return input.Split(separator)
                        .Select(s => s.Trim())  // Loại bỏ khoảng trắng đầu và cuối mỗi chuỗi
                        .ToList();
        }
        private List<TheLoaiDTO> tl_update(List<String> tl)
        {
            List<TheLoaiDTO> list_tl = tl_BUS.getAllTheLoai();
            List<TheLoaiDTO> list_kq = new List<TheLoaiDTO>();
            foreach(TheLoaiDTO x in list_tl)
            {
                foreach(String k in tl)
                {
                    if (x.TenTL == k ) list_kq.Add(x);

                }
            }
            
            
            return list_kq;
        }
        public Boolean IsInteger(string input)
        {
            string pattern = @"^\d+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input) && Convert.ToInt32(input) > 0;
        }
        public Boolean IsYearFormat(string input)
        {
            Regex regex = new Regex(@"^(\d{4})$");
            return regex.IsMatch(input);
        }
        private Boolean checkValidate()
        {
            
            if (!IsYearFormat(txtNamXB.Text))
            {
                MessageBox.Show("Nhập năm sai định dạng");
                return false;
            }
            if (txtTheloai.Text == "" || txtSoluong.Text == "" || txtNamXB.Text == "" || txtTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkValidate())
            {
                List<String> tl = ChiaChuoi(txtTheloai.Text, ',');
                List<TheLoaiDTO> tl_ts = tl_update(tl);
                TuaSach ts = new TuaSach();
                ts = getModel();

                if (ts_BUS.editTuaSach(ts) == 1)
                {

                    //xu ly the loai
                    cttl_BUS.deleteChiTietTheLoaibyID(ts.SGMaTuaSach);
                    foreach (TheLoaiDTO tlx in tl_ts)
                    {
                        cttl_BUS.addChiTietTheloai(ts.SGMaTuaSach, tlx.MaTL);

                        String sourcePath = duongdananh;
                        String destinationPath = getPath();
                        if (sourcePath != destinationPath)
                        {
                            File.Copy(sourcePath, destinationPath, true);
                        }
                        MessageBox.Show("Cập nhật thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                LoadTableSach();
            }
        }

            private void btnTrangThai_Click(object sender, EventArgs e)
            {
                TuaSach ts = new TuaSach();
                ts = getModelCell();
                if (ts.SGTrangThai)
                {
                    ts.SGTrangThai = false;
                    ts_BUS.updateTTTuaSach(ts);
                    LoadTableSach();
                    MessageBox.Show("Ẩn thành công");
                }
                else
                {
                    ts.SGTrangThai = true;
                    ts_BUS.updateTTTuaSach(ts);
                    LoadTableSach();
                    MessageBox.Show("Hiện thành công");
                }
            }

        
        private void btnSeach_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower(); // Chuyển đổi chuỗi tìm kiếm về chữ thường

            foreach (DataGridViewRow row in tableSach.Rows)
            {
                bool rowContainsSearchText = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        rowContainsSearchText = true;
                        break;
                    }
                }

                row.Visible = rowContainsSearchText || row.IsNewRow;
            }

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
