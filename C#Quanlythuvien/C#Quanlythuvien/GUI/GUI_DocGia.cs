using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using FontAwesome.Sharp;

namespace GUI
{
    public partial class GUI_DocGia : Form
    {
        private TheThuVienBUS ttv_BUS = new TheThuVienBUS();
        private DocGiaBUS dg_BUS = new DocGiaBUS();
        private static Boolean trangthai = true;
        public GUI_DocGia()
        {
            InitializeComponent();
            LoadTableTTV();
            LoadFormThe();
            LoadFormDg();
            loadComboBoxDocGia();
            LoadTableDocGia();
        }
        public GUI_DocGia(String chiTiet)
        {
            InitializeComponent();
            LoadTableTTV();
            LoadFormThe();
            LoadFormDg();
            loadComboBoxDocGia();
            LoadTableDocGia();
            SetUpAccessPermissions(chiTiet);
        }
        public void SetUpAccessPermissions(String chiTiet)
        {
            if (chiTiet.Trim().Equals(""))
            {
                btnTaothe.Visible = false;
                iconButton3.Visible = false;
                iconButton4.Visible = false;
                btnThemDocGia.Visible = false;
                btnHuy.Visible = false;
                btnAnHien.Visible = false;
                btnSua.Visible = false;
            }
            else
            {
                if (!chiTiet.Contains("Thêm"))
                {
                    btnTaothe.Visible = false;
                    iconButton4.Visible = false;
                    btnThemDocGia.Visible=false;
                    btnHuy.Visible = false;
                }
                if (!chiTiet.Contains("Sửa"))
                {
                    btnSua.Visible = false;
                    btnAnHien.Visible = false;
                    iconButton3.Visible = false;
                }
                if (!chiTiet.Contains("Gia Hạn"))
                {
                    iconButton3.Visible = false;
                }
            }
        }

        private void LoadFormThe()
        {
            txtMathe.Text = ttv_BUS.getLastMaThe();
            cbDocGia.SelectedIndex = -1;
            txtTendocgia.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtNgaysinh.Text = "";
            dateMothe.Value = DateTime.Now;
            dateHethan.Value = dateMothe.Value.AddDays(31);
        }

        private void LoadFormDg()
        {
            DateTime minDate = new DateTime(1900, 1, 1);

            // Giới hạn ngày tối đa là 31/12/2023
            DateTime maxDate = new DateTime(2026, 12, 31);

            // Đặt giới hạn cho DateTimePicker ngày sinh
            dateNgaysinh.MinDate = minDate;
            dateNgaysinh.MaxDate = maxDate;

            // Đặt ngày mặc định là ngày tối đa
            dateNgaysinh.Value = maxDate;

            txtMaDG.Text = dg_BUS.getLastMa();
            txtTenDG.Text = "";
            dateNgaysinh.Value = DateTime.Now;
            txtPhoneDG.Text = "";
            txtEmailDG.Text = "";
            txtDiaChiDG.Text = "";
        }

        private void LoadTableDocGia()
        {
            tableDocGia.Rows.Clear();
            List<DocGia> list = dg_BUS.getAllDocGia();
            foreach (DocGia docGia in list)
            {        
                tableDocGia.Rows.Add(
                    docGia.SGMaDocGia,
                    docGia.SGTenDG,
                    docGia.SGNgaySinh.ToShortDateString(),
                    docGia.SGSDT,
                    docGia.SGEmail,
                    docGia.SGDiaChi,
                    docGia.SGTrangThai ? "Hoạt động" : "Không hoạt động"
                    ) ;
            }
        }
        private void LoadTableTTV()
        {
            DateTime tght = DateTime.Now;
            List<TheThuVien> list = ttv_BUS.getAllTheThuVien();
            tableTheThuVien.Rows.Clear();
            foreach (TheThuVien theThu in list)
            {
                tableTheThuVien.Rows.Add(
                    theThu.SGMaThe,
                    theThu.SGMaDocGia,
                    theThu.SGNgayLapThe.ToString("dd-MM-yyyy"),
                    theThu.SGNgayHetHan.ToString("dd-MM-yyyy"),
                    theThu.SGNgayHetHan <= tght ? "Hết hạn" : "Đang hoạt động"
                    );
            }
        }

        private void loadComboBoxDocGia(){
            List<DocGia> ls_docgia = dg_BUS.getAllDocGia();
            cbDocGia.Items.Clear();
            foreach (DocGia x in ls_docgia)
            {
                cbDocGia.Items.Add(x.SGMaDocGia);
            }
        }

       
        public void setmodelDg(String maDG)
        {
            DocGia dg = dg_BUS.getDocGiaByMa(maDG);
            txtTendocgia.Text = dg.SGTenDG;
            txtNgaysinh.Text = dg.SGNgaySinh.ToShortDateString();
            txtDiachi.Text = dg.SGDiaChi;
            txtEmail.Text = dg.SGEmail;
            txtPhone.Text = dg.SGSDT;
        }
        public void setModel(TheThuVien ttv)
        {
            txtMathe.Text = ttv.SGMaThe;
            int index = cbDocGia.Items.IndexOf(ttv.SGMaDocGia);
            cbDocGia.SelectedIndex = index;
            setmodelDg(ttv.SGMaDocGia);
            dateMothe.Value = ttv.SGNgayLapThe;
            dateHethan.Value = ttv.SGNgayHetHan;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            txtMathe.Text = ttv_BUS.getLastMaThe();
            cbDocGia.SelectedIndex = -1;
            txtTendocgia.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtNgaysinh.Text = "";
            dateMothe.Value = DateTime.Now;
            dateHethan.Value = dateMothe.Value.AddDays(31);
        }

        private TheThuVien getModel()
        {
            TheThuVien ttv = new TheThuVien();
            ttv.SGMaThe = txtMathe.Text;
            ttv.SGMaDocGia = cbDocGia.SelectedItem.ToString();
            ttv.SGNgayLapThe = dateMothe.Value;
            ttv.SGNgayHetHan = dateHethan.Value;
            return ttv;
        }

        private bool checkValidate()
        {
            DateTime now = DateTime.Now;
            DateTime mo = dateMothe.Value;
            DateTime het = dateHethan.Value;
            
            if (cbDocGia.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn độc giả!", "Thông báo");
                return false;
            }
            if (dateMothe.Value > dateHethan.Value)
            {
                MessageBox.Show("Không được để ngày mở thẻ lớn hơn hạn thẻ", "Thông báo");
                return false;
            }
            if (het - mo <= TimeSpan.FromDays(30))
            {
                MessageBox.Show("Hạn thẻ phải ít nhất 30 ngày so với ngày mở thẻ", "Thông báo");
                return false;
            }
            if (dateMothe.Value <= now.Date)
            {
                MessageBox.Show("Ngày mở thẻ phải lớn hơn ngày hiện tại", "Thông báo");
                return false;
            }
            return true;
        }
        private void btnTaothe_Click(object sender, EventArgs e)
        {
            if (checkValidate())
            {
                TheThuVien ttv = getModel();
                if (!ttv_BUS.checkDocGia(ttv.SGMaDocGia))
                {
                    if (ttv_BUS.addTheThuVien(ttv))
                    {

                        MessageBox.Show("Thành công");
                        LoadFormThe();
                        LoadTableTTV();                   
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                } else
                {
                    MessageBox.Show("Độc giả này đã có thẻ rồi không thể tạo thêm!", "Thông báo");
                }
            }
        }

        private void cbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDocGia.SelectedIndex >= 0)
            {
                string selectedValue = cbDocGia.SelectedItem.ToString();
                setmodelDg(selectedValue);
            }
        }
        private void tableTheThuVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < tableTheThuVien.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = tableTheThuVien.Rows[e.RowIndex];

                if (selectedRow.Cells["maTheThuVien"].Value != null)
                {
                    string maThe = selectedRow.Cells["maTheThuVien"].Value.ToString();

                    TheThuVien the = ttv_BUS.getTheByMa(maThe);

                    if (the == null)
                    {
                        MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        setModel(the);
                    }
                }
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            TheThuVien ttv = new TheThuVien();
            if (cbDocGia.SelectedIndex != -1)
            {
                ttv = getModel();
                new GiaHanThe(ttv).ShowDialog();
                LoadTableDocGia();
                LoadTableTTV();
            }
            else
            {
                MessageBox.Show("Chưa chọn thẻ để gia hạn", "Thông báo");
            }
        }

        private void setModelDocGia(DocGia dg)
        {
            txtMaDG.Text = dg.SGMaDocGia;
            txtTenDG.Text = dg.SGTenDG;
            txtPhoneDG.Text = dg.SGSDT;
            txtEmailDG.Text = dg.SGEmail;
            txtDiaChiDG.Text = dg.SGDiaChi;
            trangthai = dg.SGTrangThai;
            dateNgaysinh.Value = dg.SGNgaySinh;
        }

        
        private void tableDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < tableDocGia.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = tableDocGia.Rows[e.RowIndex];

                if (selectedRow.Cells["maDG"].Value != null)
                {
                    string maDG = selectedRow.Cells["maDG"].Value.ToString();

                    DocGia docGia = dg_BUS.getDocGiaByMa(maDG);
                    if (docGia == null)
                    {
                        MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        setModelDocGia(docGia);
                    }
                }
            }
        }


        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            // Số điện thoại phải có 10 chữ số và là số nguyên
            Regex regex = new Regex(@"^\d{10}$");
            return regex.IsMatch(phoneNumber);
        }

        public static bool IsEmailValid(string email)
        {
            // Kiểm tra xem địa chỉ email có đúng định dạng hay không
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return regex.IsMatch(email);
        }

        private bool CheckvalidateDG()
        {
            if (txtTenDG.Text == "" || txtDiaChiDG.Text == "" || txtPhoneDG.Text == "" || txtEmailDG.Text == "" || txtDiaChiDG.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin", "Thông báo");
                return false;
            }
            if (!IsPhoneNumberValid(txtPhoneDG.Text))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo");
                return false;
            }
            if (!IsEmailValid(txtEmailDG.Text))
            {
                MessageBox.Show("Email không đúng định dạng", "Thông báo");
                return false;
            }
            return true;
        }
        private DocGia getModelDG()
        {
            DocGia dg = new DocGia();
            dg.SGMaDocGia = txtMaDG.Text;
            dg.SGTenDG = txtTenDG.Text;
            dg.SGNgaySinh = dateNgaysinh.Value;
            dg.SGSDT = txtPhoneDG.Text;
            dg.SGEmail = txtEmailDG.Text;
            dg.SGDiaChi = txtDiaChiDG.Text;
            dg.SGTrangThai = trangthai;
            return dg;
        }
       
        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            DocGia dg = getModelDG();
            if (CheckvalidateDG())
            {
                if (dg_BUS.isExitDG(txtMaDG.Text))
                {
                    MessageBox.Show("Độc giả đã tồn tại", "Thông báo");
                }
                else
                {
                    if (dg_BUS.addDocGia(dg))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadTableDocGia();
                        loadComboBoxDocGia();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower(); // Chuyển đổi chuỗi tìm kiếm về chữ thường

            foreach (DataGridViewRow row in tableDocGia.Rows)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string searchText = txtTimkiem.Text.ToLower(); // Chuyển đổi chuỗi tìm kiếm về chữ thường

            foreach (DataGridViewRow row in tableTheThuVien.Rows)
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            DocGia dg = getModelDG();
            if (CheckvalidateDG())
            {
                if (dg_BUS.editDocGia(dg))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    LoadTableDocGia();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaDG.Text = dg_BUS.getLastMa();
            txtTenDG.Text = "";
            txtEmailDG.Text = "";
            txtPhoneDG.Text = "";
            txtDiaChiDG.Text = "";
            dateNgaysinh.Value = DateTime.Now;
        }

        private void btnAnHien_Click(object sender, EventArgs e)
        {
            DocGia dg = getModelDG();
            if (dg.SGTrangThai)
            {
                dg.SGTrangThai = false;
                trangthai = dg.SGTrangThai;
                if (dg_BUS.editDocGia(dg))
                {
                    MessageBox.Show("Chuyển thành công","Thông báo");
                }
                
                LoadTableDocGia();
            } else
            {
                dg.SGTrangThai = true;
                trangthai = dg.SGTrangThai;
                if (dg_BUS.editDocGia(dg))
                {
                    MessageBox.Show("Chuyển thành công", "Thông báo");
                }
                LoadTableDocGia();
            }
        }
    }
}
