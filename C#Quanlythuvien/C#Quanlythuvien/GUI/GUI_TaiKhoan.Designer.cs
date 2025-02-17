namespace GUI
{
    partial class GUI_TaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsTK = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_ChucVu = new System.Windows.Forms.ComboBox();
            this.cb_taikhoan = new System.Windows.Forms.ComboBox();
            this.cbbox_tinhTrang = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.rdo_tenNV = new System.Windows.Forms.RadioButton();
            this.rdo_maNV = new System.Windows.Forms.RadioButton();
            this.bttn_mo = new System.Windows.Forms.Button();
            this.bttn_khoa = new System.Windows.Forms.Button();
            this.bttn_gan = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsTK);
            this.groupBox3.Location = new System.Drawing.Point(28, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1262, 489);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách";
            // 
            // lsTK
            // 
            this.lsTK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lsTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsTK.HideSelection = false;
            this.lsTK.Location = new System.Drawing.Point(3, 26);
            this.lsTK.Name = "lsTK";
            this.lsTK.Size = new System.Drawing.Size(1256, 460);
            this.lsTK.TabIndex = 0;
            this.lsTK.UseCompatibleStateImageBehavior = false;
            this.lsTK.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã NV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên NV";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chức Vụ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Đăng Nhập";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mật Khẩu";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã Quyền";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Trạng Thái";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cb_ChucVu);
            this.groupBox2.Controls.Add(this.cb_taikhoan);
            this.groupBox2.Controls.Add(this.cbbox_tinhTrang);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.tb_timkiem);
            this.groupBox2.Controls.Add(this.rdo_tenNV);
            this.groupBox2.Controls.Add(this.rdo_maNV);
            this.groupBox2.Controls.Add(this.bttn_mo);
            this.groupBox2.Controls.Add(this.bttn_khoa);
            this.groupBox2.Controls.Add(this.bttn_gan);
            this.groupBox2.Location = new System.Drawing.Point(31, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1259, 223);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chức Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tài Khoản";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_ChucVu
            // 
            this.cb_ChucVu.FormattingEnabled = true;
            this.cb_ChucVu.Items.AddRange(new object[] {
            "Tất Cả",
            "Quản Lý",
            "Quản Trị Viên",
            "Nhân Viên Kho",
            "Thử Thư"});
            this.cb_ChucVu.Location = new System.Drawing.Point(479, 115);
            this.cb_ChucVu.Name = "cb_ChucVu";
            this.cb_ChucVu.Size = new System.Drawing.Size(157, 33);
            this.cb_ChucVu.TabIndex = 11;
            this.cb_ChucVu.SelectedIndexChanged += new System.EventHandler(this.cb_ChucVu_SelectedIndexChanged);
            // 
            // cb_taikhoan
            // 
            this.cb_taikhoan.FormattingEnabled = true;
            this.cb_taikhoan.Items.AddRange(new object[] {
            "Tất Cả",
            "Mở",
            "Khóa"});
            this.cb_taikhoan.Location = new System.Drawing.Point(823, 115);
            this.cb_taikhoan.Name = "cb_taikhoan";
            this.cb_taikhoan.Size = new System.Drawing.Size(157, 33);
            this.cb_taikhoan.TabIndex = 11;
            this.cb_taikhoan.SelectedIndexChanged += new System.EventHandler(this.cb_taikhoan_SelectedIndexChanged);
            // 
            // cbbox_tinhTrang
            // 
            this.cbbox_tinhTrang.FormattingEnabled = true;
            this.cbbox_tinhTrang.Items.AddRange(new object[] {
            "Tất Cả",
            "Đã Cấp",
            "Chưa Cấp"});
            this.cbbox_tinhTrang.Location = new System.Drawing.Point(140, 115);
            this.cbbox_tinhTrang.Name = "cbbox_tinhTrang";
            this.cbbox_tinhTrang.Size = new System.Drawing.Size(157, 33);
            this.cbbox_tinhTrang.TabIndex = 11;
            this.cbbox_tinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbbox_tinhTrang_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.Window;
            this.label25.Location = new System.Drawing.Point(275, 42);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 29);
            this.label25.TabIndex = 10;
            this.label25.Text = "Tìm Kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(391, 41);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(412, 36);
            this.tb_timkiem.TabIndex = 9;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // rdo_tenNV
            // 
            this.rdo_tenNV.AutoSize = true;
            this.rdo_tenNV.Location = new System.Drawing.Point(140, 41);
            this.rdo_tenNV.Name = "rdo_tenNV";
            this.rdo_tenNV.Size = new System.Drawing.Size(101, 29);
            this.rdo_tenNV.TabIndex = 7;
            this.rdo_tenNV.TabStop = true;
            this.rdo_tenNV.Text = "Tên NV";
            this.rdo_tenNV.UseVisualStyleBackColor = true;
            // 
            // rdo_maNV
            // 
            this.rdo_maNV.AutoSize = true;
            this.rdo_maNV.Location = new System.Drawing.Point(23, 41);
            this.rdo_maNV.Name = "rdo_maNV";
            this.rdo_maNV.Size = new System.Drawing.Size(94, 29);
            this.rdo_maNV.TabIndex = 8;
            this.rdo_maNV.TabStop = true;
            this.rdo_maNV.Text = "Mã NV";
            this.rdo_maNV.UseVisualStyleBackColor = true;
            // 
            // bttn_mo
            // 
            this.bttn_mo.Location = new System.Drawing.Point(1120, 124);
            this.bttn_mo.Name = "bttn_mo";
            this.bttn_mo.Size = new System.Drawing.Size(106, 57);
            this.bttn_mo.TabIndex = 0;
            this.bttn_mo.Text = "Mở Khóa";
            this.bttn_mo.UseVisualStyleBackColor = true;
            this.bttn_mo.Click += new System.EventHandler(this.bttn_mo_Click);
            // 
            // bttn_khoa
            // 
            this.bttn_khoa.Location = new System.Drawing.Point(1120, 32);
            this.bttn_khoa.Name = "bttn_khoa";
            this.bttn_khoa.Size = new System.Drawing.Size(106, 57);
            this.bttn_khoa.TabIndex = 0;
            this.bttn_khoa.Text = "Khóa";
            this.bttn_khoa.UseVisualStyleBackColor = true;
            this.bttn_khoa.Click += new System.EventHandler(this.bttn_khoa_Click);
            // 
            // bttn_gan
            // 
            this.bttn_gan.Location = new System.Drawing.Point(970, 32);
            this.bttn_gan.Name = "bttn_gan";
            this.bttn_gan.Size = new System.Drawing.Size(124, 57);
            this.bttn_gan.TabIndex = 0;
            this.bttn_gan.Text = "Gán Quyền";
            this.bttn_gan.UseVisualStyleBackColor = true;
            this.bttn_gan.Click += new System.EventHandler(this.bttn_gan_Click);
            // 
            // GUI_TaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1319, 776);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GUI_TaiKhoan";
            this.Text = "GUI_TaiKhoan";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lsTK;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbox_tinhTrang;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.RadioButton rdo_tenNV;
        private System.Windows.Forms.RadioButton rdo_maNV;
        private System.Windows.Forms.Button bttn_khoa;
        private System.Windows.Forms.Button bttn_gan;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_ChucVu;
        private System.Windows.Forms.ComboBox cb_taikhoan;
        private System.Windows.Forms.Button bttn_mo;
    }
}