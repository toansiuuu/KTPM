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
    public partial class frmGanQuyen : Form
    {
        String tenDangNhap; 
        String chucVu;
        String maQuyen;
        String maNV;
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        public frmGanQuyen()
        {
            InitializeComponent();
        }
        public frmGanQuyen(String tenDangNhap,String chucVu,String maQuyen,String maNV)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
            this.chucVu = chucVu;
            this.maQuyen = maQuyen;
            this.maNV = maNV;
            SetDefault();
        }
        public void SetDefault()
        {
            if (maQuyen.Equals("Q01"))
            {
                rdo_ql.Checked = true;
            }
            else if (maQuyen.Equals("Q02"))
            {
                rdo_qtv.Checked = true;
            }
            else if (maQuyen.Equals("Q03"))
            {
                rdo_nvk.Checked = true;
            }
            else if (maQuyen.Equals("Q04"))
            {
                rdo_tt.Checked = true;
            }
        }
        public String getTenQuyenBySelectedRadioButtuon()
        {
            string selectedText = "";
            foreach (Control control in groupBox2.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Checked)
                    {
                        selectedText = radioButton.Text;
                    }
                }
            }
            return selectedText;
        }
        public String getTenQuyenByMaQuyen(String maQuyen)
        {
            string selectedText = "";
            if (maQuyen.Equals("Q01"))
            {
                selectedText = "Quản Lý";
            }
            else if (maQuyen.Equals("Q02"))
            {
                selectedText = "Quản Trị Viên";
            }
            else if (maQuyen.Equals("Q03"))
            {
                selectedText = "Nhân Viên Kho";
            }
            else if (maQuyen.Equals("Q04"))
            {
                selectedText = "Thủ Thư";
            }
            return selectedText;
        }
        public String getMaQuyenByTenQuyen(String tenQuyen)
        {
            string selectedText = "";
            if (tenQuyen.Equals("Quản Lý"))
            {
                selectedText = "Q01";
            }
            else if (tenQuyen.Equals("Quản Trị Viên"))
            {
                selectedText = "Q02";
            }
            else if (tenQuyen.Equals("Nhân Viên Kho"))
            {
                selectedText = "Q03";
            }
            else if (tenQuyen.Equals("Thủ Thư"))
            {
                selectedText = "Q04";
            }
            return selectedText;
        }
        private void bttn_hoanthanh_Click(object sender, EventArgs e)
        {
            if (rdo_tt.Checked || rdo_qtv.Checked || rdo_ql.Checked || rdo_nvk.Checked)
            {
                if (getTenQuyenBySelectedRadioButtuon().Equals(chucVu))
                {
                    if (getTenQuyenBySelectedRadioButtuon().Equals(getTenQuyenByMaQuyen(maQuyen)))
                    {
                        MessageBox.Show("Quyền Này Đã Được Gán Từ Trước!");
                    }
                    else
                    {
                        if (maQuyen.Trim().Equals(""))
                        {
                            NhanVienDTO nv = tkBUS.getInFoNVByMa(maNV);
                            String matkhau = nv.NgaySinh.ToString("ddMMyyyy");
                            string maquyen = getMaQuyenByTenQuyen(getTenQuyenBySelectedRadioButtuon());
                            TaiKhoan tk = new TaiKhoan(maNV, matkhau, maquyen,true);
                            if(tkBUS.insertTaiKhoan(tk)>0)
                            {
                                MessageBox.Show("Tạo Tạo Tài Với Quyền Thành Công!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Tạo tài khoản thất bại!");
                            }
                        }
                        else
                        {
                            string maquyen = getMaQuyenByTenQuyen(getTenQuyenBySelectedRadioButtuon());
                            if(tkBUS.updateQuyenTaiKhoan(tenDangNhap, maquyen) > 0)
                            {
                                MessageBox.Show("Gán Quyền Thành Công!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Gán Quyền Thất Bại");
                            }
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cần Gán Quyền Đúng Với Chức Vụ Của Nhân Viên!");
                }
            }
            else
            {
                MessageBox.Show("Cần Chọn Một Quyền Để Gán!");
            }
        }
    }
}
