using BUS;
using DTO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.VisualBasic;
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
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_MuonSach : Form
    {
        ChiTietPhieuMuonBUS ctpmBUS = new ChiTietPhieuMuonBUS();
        PhieuMuonBUS pmBUS = new PhieuMuonBUS();
        TuaSachBUS tsBUS = new TuaSachBUS();
        DocGiaBUS dgBUS = new DocGiaBUS();
        TheThuVienBUS ttvBUS = new TheThuVienBUS();
        ChiTietCuonSachBUS ctcsBUS = new ChiTietCuonSachBUS();
        CuonSachBUS csBUS = new CuonSachBUS();

        List<TuaSach> listTuaSach = new List<TuaSach>();
        List<PhieuMuon> listPM = new List<PhieuMuon>();
        List<DocGia> listDG = new List<DocGia>();
        List<TheThuVien> listTTV = new List<TheThuVien>();

        DataTable dt;
        DataTable dt_TS;
        public GUI_MuonSach()
        {
            InitializeComponent();
            SetUpListView();
            LoadAll();
            cbbox_tinhTrang.SelectedIndex = 0;
            cbbox_tinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            rdo_mapm.Checked = true;
            tb_mapm2.Text = pmBUS.getLastMaPM();
            cbbox_tendocgia2.DropDownStyle = ComboBoxStyle.DropDownList;
            rdo_masach2.Checked = true;
            dtp_timngay.Value = DateTime.Now;
        }
        public GUI_MuonSach(String chiTiet,String maNV)
        {
            InitializeComponent();
            SetUpListView();
            LoadAll();
            cbbox_tinhTrang.SelectedIndex = 0;
            cbbox_tinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            rdo_mapm.Checked = true;
            tb_mapm2.Text = pmBUS.getLastMaPM();
            cbbox_tendocgia2.DropDownStyle = ComboBoxStyle.DropDownList;
            rdo_masach2.Checked = true;
            tb_manv2.Text = maNV;
            SetUpAccessPermissions(chiTiet);
        }
        public void SetUpAccessPermissions(String chiTiet)
        {
            if (chiTiet.Trim().Equals(""))
            {
                tabControl1.TabPages.Remove(tabPage2);
            }
        }
        public void LoadAll()
        {
            listTuaSach = tsBUS.getAllTuaSach();
            listPM = pmBUS.getALlPhieuMuon();
            listDG = dgBUS.getAllDocGia();
            listTTV = ttvBUS.getAllTheThuVien();
            LoadCTPM();
            LoadDGInToComBoBox();
            LoadTS();
        }
        public void SetUpListView()
        {
            lsCTPM.Columns[0].Width = (int)(lsCTPM.Width * 0.33);
            lsCTPM.Columns[1].Width = (int)(lsCTPM.Width * 0.33);
            lsCTPM.Columns[2].Width = (int)(lsCTPM.Width * 0.33);
            lsCTPM.Columns[3].Width = 0;
            lsCTPM.Columns[4].Width = 0;
            lsCTPM.View = View.Details;
            lsCTPM.GridLines = true;
            lsCTPM.FullRowSelect = true;

            lsTuaSach.Columns[0].Width = (int)(lsTuaSach.Width * 0.33);
            lsTuaSach.Columns[1].Width = (int)(lsTuaSach.Width * 0.33);
            lsTuaSach.Columns[2].Width = (int)(lsTuaSach.Width * 0.33);
            lsTuaSach.View = View.Details;
            lsTuaSach.GridLines = true;
            lsTuaSach.FullRowSelect = true;

            lsTSMuon.Columns[0].Width = (int)(lsTSMuon.Width * 0.33);
            lsTSMuon.Columns[1].Width = (int)(lsTSMuon.Width * 0.33);
            lsTSMuon.Columns[2].Width = (int)(lsTSMuon.Width * 0.33);
            lsTSMuon.View = View.Details;
            lsTSMuon.GridLines = true;
            lsTSMuon.FullRowSelect = true;
        }
        public void LoadCTPM()
        {
            lsCTPM.Items.Clear();
            dt = ctpmBUS.getALlCTPM();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsCTPM.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }
        public void LoadDGInToComBoBox()
        {
            cbbox_tendocgia2.Items.Clear();
            for (int i = 0; i < listDG.Count; i++)
            {
                if (listDG[i].SGTrangThai)
                {
                    cbbox_tendocgia2.Items.Add(listDG[i].SGTenDG);
                }
            }
        }
        public void LoadTS()
        {
            lsTuaSach.Items.Clear();
            dt_TS = tsBUS.getALlTuaSachChoMuon();
            for (int i = 0; i < dt_TS.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsTuaSach.Items.Add(dt_TS.Rows[i][0].ToString());
                lvi.SubItems.Add(dt_TS.Rows[i][1].ToString());
                lvi.SubItems.Add(dt_TS.Rows[i][2].ToString());
            }
        }

        private void lsCTPM_Click(object sender, EventArgs e)
        {
            if (lsCTPM.SelectedIndices.Count > 0)
            {
                String mapm = lsCTPM.SelectedItems[0].SubItems[0].Text;
                String mats = lsCTPM.SelectedItems[0].SubItems[1].Text;
                int soLuong = Convert.ToInt32(lsCTPM.SelectedItems[0].SubItems[2].Text);
                String mathe = "";
                String madg = "";
                foreach (PhieuMuon pm in listPM)
                {
                    if (pm.SGMaPhieuMuon.Equals(mapm))
                    {
                        tb_mapm.Text = pm.SGMaPhieuMuon;
                        tb_mathe.Text = pm.SGMaThe;
                        mathe = pm.SGMaThe;
                        tb_manv.Text = pm.SGMaNhanVien;
                        dtp_ngmuon.Value = pm.SGNgayMuon;
                        dtp_hantra.Value = pm.SGHanTra;
                        tb_trangthai.Text = pm.SGTrangThai ? "Đã Trả" : "Chưa Trả";
                        break;
                    }
                }
                foreach(TheThuVien ttv in listTTV)
                {
                    if (ttv.SGMaThe.Equals(mathe))
                    {
                        madg = ttv.SGMaDocGia;
                        break;
                    }
                }
                foreach (DocGia dg in listDG)
                {
                    if (dg.SGMaDocGia.Equals(madg))
                    {
                        tb_madg.Text = dg.SGMaDocGia;
                        tb_tendg.Text = dg.SGTenDG;
                        tb_sdt.Text = dg.SGSDT;
                        break;
                    }
                }
                foreach (TuaSach ts in listTuaSach)
                {
                    if (ts.SGMaTuaSach.Equals(mats))
                    {
                        tb_masach.Text = ts.SGMaTuaSach;
                        tb_tensach.Text = ts.SGTenTuaSach;
                        tb_sl.Text = soLuong.ToString();
                        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string projectDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
                        string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;
                        string imagePath = Path.Combine(projectDirectory2, "Image", "Sach", ts.SGImage);
                        pb_image.Image = new Bitmap(imagePath);
                        break;
                    }
                }

            }
        }

        private void btn_chiTiet_Click(object sender, EventArgs e)
        {
            if (lsCTPM.SelectedIndices.Count > 0)
            {
                String mapm = lsCTPM.SelectedItems[0].SubItems[0].Text;
                String mats = lsCTPM.SelectedItems[0].SubItems[1].Text;
                new frmXemChiTietCuonSachMuon(mapm, mats).ShowDialog();
            }
        }
        public void Filter()
        {
            lsCTPM.Items.Clear();
            dt = ctpmBUS.getALlCTPM();
            FilterSearch();
            FilterStatus();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsCTPM.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }
        public void FilterSearch()
        {
            if (tb_timkiem.Text.Length!=0)
            {
                if (rdo_mapm.Checked)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (!dt.Rows[i][0].ToString().ToLower().Contains(tb_timkiem.Text.ToLower().Trim()))
                        {
                            dt.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (rdo_madg.Checked)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (!dt.Rows[i][3].ToString().ToLower().Contains(tb_timkiem.Text.ToLower().Trim()))
                        {
                            dt.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (rdo_matuasach.Checked)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (!dt.Rows[i][1].ToString().ToLower().Contains(tb_timkiem.Text.ToLower().Trim()))
                        {
                            dt.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }
        public void FilterStatus()
        {
            if(cbbox_tinhTrang.SelectedIndex == 1)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!Convert.ToBoolean(dt.Rows[i][4]))
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (cbbox_tinhTrang.SelectedIndex == 2)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dt.Rows[i][4]))
                    {
                        dt.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
        public void FilterTSMuon()
        {
            lsTuaSach.Items.Clear();
            dt_TS = tsBUS.getALlTuaSachChoMuon();
            if (tb_timkiem2.Text.Length != 0)
            {
                if (rdo_masach2.Checked)
                {
                    for (int i = 0; i < dt_TS.Rows.Count; i++)
                    {
                        if (!dt_TS.Rows[i][0].ToString().ToLower().Contains(tb_timkiem2.Text.ToLower().Trim()))
                        {
                            dt_TS.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (rdo_tensach2.Checked)
                {
                    for (int i = 0; i < dt_TS.Rows.Count; i++)
                    {
                        if (!dt_TS.Rows[i][1].ToString().ToLower().Contains(tb_timkiem2.Text.ToLower().Trim()))
                        {
                            dt_TS.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            for (int i = 0; i < dt_TS.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsTuaSach.Items.Add(dt_TS.Rows[i][0].ToString());
                lvi.SubItems.Add(dt_TS.Rows[i][1].ToString());
                lvi.SubItems.Add(dt_TS.Rows[i][2].ToString());
            }
        }



        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cbbox_tinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void cbbox_tendocgia2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String madg = "";
            String sdt = "";
            String mathe = "";
            bool flag = false;
            for (int i = 0; i < listDG.Count; i++)
            {
                if (listDG[i].SGTenDG.Equals(cbbox_tendocgia2.SelectedItem))
                {
                    madg = listDG[i].SGMaDocGia;
                    sdt = listDG[i].SGSDT;
                    for (int j = 0; j < listTTV.Count; j++)
                    {
                        if (listTTV[i].SGMaDocGia.Equals(listDG[i].SGMaDocGia))
                        {
                            mathe = listTTV[i].SGMaThe;
                            DateTime selectedDate = listTTV[i].SGNgayHetHan;
                            if (DateTime.Now.Date < selectedDate.Date)
                            {
                                flag = true;
                            }
                            break;
                        }
                    }
                    break;
                }
            }
            if (flag)
            {
                tb_madg2.Text = madg;
                tb_sdt2.Text = sdt;
                tb_mathe2.Text = mathe;
            }
            else
            {
                tb_madg2.Text = "";
                tb_sdt2.Text = "";
                tb_mathe2.Text = "";
                if (cbbox_tendocgia2.SelectedIndex!=-1)
                {
                    MessageBox.Show("Thẻ Thư Viện Của Độc Giả Đã Hết Hạn!");
                }
                cbbox_tendocgia2.SelectedIndex = -1;
            }
        }

        private void tb_timkiem2_TextChanged(object sender, EventArgs e)
        {
            FilterTSMuon();
        }
        public bool ValidateSoLuongNhap(String input, int soLuong)
        {
            string pattern = @"^\d+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input) && Convert.ToInt32(input) > 0 
                && Convert.ToInt32(input) <= soLuong;
        }
        private void bttn_them_Click(object sender, EventArgs e)
        {
            if (lsTuaSach.SelectedItems.Count > 0)
            {
                int soLuong = Convert.ToInt32(lsTuaSach.SelectedItems[0].SubItems[2].Text);
                String maTS = lsTuaSach.SelectedItems[0].SubItems[0].Text;
                String tenTS = lsTuaSach.SelectedItems[0].SubItems[1].Text;
                string inputSL = Interaction.InputBox("Nhập vào số lượng cần thêm:", "Số Lượng", "1");
                if (inputSL != "")
                {
                    if (!ValidateSoLuongNhap(inputSL, soLuong))
                    {
                        MessageBox.Show("Số Lượng phải là số nguyên lớn hơn 0 và nhỏ hơn số lượng mặc định!");
                    }
                    else
                    {

                        bool flag = false;
                        for (int i = 0; i < lsTSMuon.Items.Count; i++)
                        {
                            if (lsTSMuon.Items[i].SubItems[0].Text.Equals(maTS))
                            {
                                int slCu = Convert.ToInt32(lsTSMuon.Items[i].SubItems[2].Text);
                                int slthem = Convert.ToInt32(inputSL);
                                int slMoi = slCu + slthem;
                                if (slMoi > Convert.ToInt32(soLuong))
                                {
                                    MessageBox.Show("Vượt quá số lượng trong kho!");
                                    return;
                                }
                                flag = true;
                                lsTSMuon.Items[i].SubItems[2].Text = slMoi.ToString();
                                break;
                            }
                        }
                        if (!flag)
                        {
                            ListViewItem lvi =
                            lsTSMuon.Items.Add(maTS);
                            lvi.SubItems.Add(tenTS);
                            lvi.SubItems.Add(inputSL);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Cần Chọn một sách để thêm!");
            }
        }

        private void bttn_xoa_Click(object sender, EventArgs e)
        {
            if (lsTSMuon.SelectedItems.Count > 0)
            {
                int soLuong = Convert.ToInt32(lsTSMuon.SelectedItems[0].SubItems[2].Text);
                String maTS = lsTSMuon.SelectedItems[0].SubItems[0].Text;
                String tenTS = lsTSMuon.SelectedItems[0].SubItems[1].Text;
                string inputSL = Interaction.InputBox("Nhập vào số lượng cần xóa:", "Số Lượng", "1");
                if (inputSL != "")
                {
                    if (!ValidateSoLuongNhap(inputSL, soLuong))
                    {
                        MessageBox.Show("Số Lượng phải là số nguyên lớn hơn 0 và nhỏ hơn số lượng mặc định!");
                    }
                    else
                    {

                        if (Convert.ToInt32(inputSL) == soLuong)
                        {
                            lsTSMuon.Items.RemoveAt(lsTSMuon.SelectedItems[0].Index);
                        }
                        else
                        {
                            lsTSMuon.SelectedItems[0].SubItems[2].Text =
                                (soLuong - Convert.ToInt32(inputSL)).ToString();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Cần Chọn một sách để xóa!");
            }
        }

        private void bttn_xoaTatCa_Click(object sender, EventArgs e)
        {
            if (lsTSMuon.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả sách đã chọn?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    lsTSMuon.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Danh sách sách đã chọn đang trống!");
            }
        }

        private void bttn_hoantat_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtp_hantra2.Value;
            DateTime ngayMuon = dtp_ngaymuon2.Value;
            TimeSpan diff = selectedDate - ngayMuon;
            
            if (selectedDate.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Hạn Trả Phải Lớn Hơn Ngày Mượn!");
                return;
            }
            
            if (diff.Days < 1)
            {
                MessageBox.Show("Thời gian mượn tối thiểu là 1 ngày!");
                return;
            }
            
            if (diff.Days > 14)
            {
                MessageBox.Show("Thời gian mượn tối đa là 14 ngày!");
                return;
            }
            
            if (cbbox_tendocgia2.SelectedIndex<0)
            {
                MessageBox.Show("Vui Lòng Chọn Độc Giả!");
                return;
            }
            if (lsTSMuon.Items.Count <= 0)
            {
                MessageBox.Show("Vui Lòng Chọn Ít Nhất Một Cuốn Sách Mượn!");
                return;
            }
            PhieuMuon pm = new PhieuMuon(tb_mapm2.Text,tb_mathe2.Text,
            dtp_ngaymuon2.Value,dtp_hantra2.Value,tb_manv2.Text,false);
            List<ChiTietPhieuMuon> list = new List<ChiTietPhieuMuon>();
            foreach (ListViewItem item in lsTSMuon.Items)
            {
                ChiTietPhieuMuon ctpm = new ChiTietPhieuMuon(tb_mapm2.Text, item.SubItems[0].Text, Convert.ToInt32(item.SubItems[2].Text));
                list.Add(ctpm);
            }
            List <ChiTietCuonSachMuon> listCTCSM = new List<ChiTietCuonSachMuon>();
            List<String> listSetBorrowedCSM = new List<string>();
            foreach (ChiTietPhieuMuon ctpm in list)
            {
                String sql = "select top "+ ctpm.SGSoLuong + " macuonsach from cuonsach where matuasach = '"+ ctpm.SGMaTuaSach + "' and trangthaisach = 1";
                List <String> listMaCS = ctcsBUS.getCTCSMNotBorrowedFirst(sql);
                for (int i=0; i<listMaCS.Count; i++)
                {
                    ChiTietCuonSachMuon ctcsm = new ChiTietCuonSachMuon(ctpm.SGMaPhieuMuon, ctpm.SGMaTuaSach, listMaCS[i]);
                    listSetBorrowedCSM.Add(listMaCS[i]);
                    listCTCSM.Add(ctcsm);
                }
            }
            if(!pmBUS.addPM(pm))
            {
                MessageBox.Show("Lỗi add Phiếu mượn");
                return;
            }
            if (!ctpmBUS.addCTPM(list))
            {
                MessageBox.Show("Lỗi add CTPhiếu mượn");
                return;
            }
            if (!ctcsBUS.addCTCSM(listCTCSM))
            {
                MessageBox.Show("Lỗi add CTCSM");
                return;
            }
            if (!csBUS.suaTTMuonCuonSach(listSetBorrowedCSM))
            {
                MessageBox.Show("Lỗi sửa tình trạng mượn cuốn sách");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xuất phiếu mượn?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Chọn nơi lưu tệp PDF";
                    saveFileDialog.FileName = tb_mapm2.Text;
                    saveFileDialog.Filter = "Tệp PDF (*.pdf)|*.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string pdfPath = saveFileDialog.FileName;
                        CreatePdf(pdfPath, pm, list);
                    }
                }
            }
            MessageBox.Show("Thành Cônng!");
            setNull();
        }
        static void CreatePdf(string pdfPath, PhieuMuon pm, List<ChiTietPhieuMuon> list)
        {
            using (var document = new Document())
            {
                using (var writer = PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create)))
                {
                    document.Open();

                    // Sử dụng font Unicode hỗ trợ tiếng Việt
                    BaseFont baseFont = BaseFont.CreateFont("c:/windows/fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font unicodeFont = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);

                    // Thêm tiêu đề vào tài liệu với font Unicode
                    document.Add(new iTextSharp.text.Paragraph("Phiếu Mượn", unicodeFont));

                    // Thêm thông tin từ đối tượng PhieuMuon vào tài liệu với font Unicode
                    document.Add(new iTextSharp.text.Paragraph($"Mã Phiếu Mượn: {pm.SGMaPhieuMuon}", unicodeFont));
                    document.Add(new iTextSharp.text.Paragraph($"Mã Thẻ: {pm.SGMaThe}", unicodeFont));
                    document.Add(new iTextSharp.text.Paragraph($"Ngày Mượn: {pm.SGNgayMuon.ToShortDateString()}", unicodeFont));
                    document.Add(new iTextSharp.text.Paragraph($"Hạn Trả: {pm.SGHanTra.ToShortDateString()}", unicodeFont));
                    document.Add(new iTextSharp.text.Paragraph($"Mã Nhân Viên Lập: {pm.SGMaNhanVien}", unicodeFont));

                    // Thêm bảng cho danh sách chi tiết
                    PdfPTable table = new PdfPTable(2);
                    table.WidthPercentage = 80;
                    PdfPCell cell = new PdfPCell(new Phrase("Danh Sách Chi Tiết", unicodeFont));
                    cell.Colspan = 2;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);

                    table.AddCell(new PdfPCell(new Phrase("Mã Tựa Sách", unicodeFont)));
                    table.AddCell(new PdfPCell(new Phrase("Số Lượng", unicodeFont)));

                    foreach (var chiTiet in list)
                    {
                        table.AddCell(new Phrase(chiTiet.SGMaTuaSach, unicodeFont));
                        table.AddCell(new Phrase(chiTiet.SGSoLuong.ToString(), unicodeFont));
                    }

                    // Thêm bảng vào tài liệu
                    document.Add(table);

                    // Đóng tài liệu
                    document.Close();
                }
            }
        }
        public void setNull()
        {
            tb_mapm2.Text = pmBUS.getLastMaPM();
            dtp_hantra2.Value = DateTime.Now.Date;
            cbbox_tendocgia2.SelectedIndex = -1;
            tb_madg2.Text = "";
            tb_mathe2.Text = "";
            tb_sdt2.Text = "";
            lsTSMuon.Items.Clear();
            rdo_masach2.Checked = true;
            tb_timkiem2.Text = "";
            LoadTS();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAll();
        }
    }
}
