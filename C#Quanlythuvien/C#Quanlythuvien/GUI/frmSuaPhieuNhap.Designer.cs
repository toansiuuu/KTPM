namespace GUI
{
    partial class frmSuaPhieuNhap
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button7 = new System.Windows.Forms.Button();
            this.cb_timKiem = new System.Windows.Forms.ComboBox();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_maNCC = new System.Windows.Forms.TextBox();
            this.dp_ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button8 = new System.Windows.Forms.Button();
            this.txt_maNhanVien = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_hoanThanh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tongTIen = new System.Windows.Forms.TextBox();
            this.txt_maPhieuNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.listView2);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.cb_timKiem);
            this.groupBox4.Controls.Add(this.txt_timKiem);
            this.groupBox4.Location = new System.Drawing.Point(756, 102);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(657, 749);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhập hàng tồn kho";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 88;
            this.label9.Text = "Tìm kiếm";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(34, 161);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(582, 566);
            this.listView2.TabIndex = 87;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã sách";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên sách";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số lượng";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(513, 85);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 53);
            this.button7.TabIndex = 85;
            this.button7.Text = " Thêm";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cb_timKiem
            // 
            this.cb_timKiem.BackColor = System.Drawing.Color.White;
            this.cb_timKiem.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_timKiem.ForeColor = System.Drawing.Color.Black;
            this.cb_timKiem.FormattingEnabled = true;
            this.cb_timKiem.Items.AddRange(new object[] {
            "Tên Sách",
            "Mã Sách"});
            this.cb_timKiem.Location = new System.Drawing.Point(116, 85);
            this.cb_timKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_timKiem.Name = "cb_timKiem";
            this.cb_timKiem.Size = new System.Drawing.Size(129, 38);
            this.cb_timKiem.TabIndex = 68;
            this.cb_timKiem.SelectedIndexChanged += new System.EventHandler(this.cb_timKiem_SelectedIndexChanged);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timKiem.Location = new System.Drawing.Point(253, 85);
            this.txt_timKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_timKiem.Multiline = true;
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(204, 30);
            this.txt_timKiem.TabIndex = 66;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_maNCC);
            this.groupBox1.Controls.Add(this.dp_ngayNhap);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.txt_maNhanVien);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.btn_hoanThanh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tongTIen);
            this.groupBox1.Controls.Add(this.txt_maPhieuNhap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(719, 749);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // txt_maNCC
            // 
            this.txt_maNCC.BackColor = System.Drawing.Color.White;
            this.txt_maNCC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maNCC.Location = new System.Drawing.Point(260, 105);
            this.txt_maNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_maNCC.Multiline = true;
            this.txt_maNCC.Name = "txt_maNCC";
            this.txt_maNCC.ReadOnly = true;
            this.txt_maNCC.Size = new System.Drawing.Size(244, 30);
            this.txt_maNCC.TabIndex = 87;
            // 
            // dp_ngayNhap
            // 
            this.dp_ngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_ngayNhap.Location = new System.Drawing.Point(260, 208);
            this.dp_ngayNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_ngayNhap.Name = "dp_ngayNhap";
            this.dp_ngayNhap.Size = new System.Drawing.Size(244, 30);
            this.dp_ngayNhap.TabIndex = 55;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 326);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(652, 399);
            this.listView1.TabIndex = 54;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã tựa sách";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số lượng";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Đơn giá";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(552, 129);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 48);
            this.button8.TabIndex = 86;
            this.button8.Text = " Xóa";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txt_maNhanVien
            // 
            this.txt_maNhanVien.BackColor = System.Drawing.Color.White;
            this.txt_maNhanVien.Location = new System.Drawing.Point(260, 157);
            this.txt_maNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_maNhanVien.Multiline = true;
            this.txt_maNhanVien.Name = "txt_maNhanVien";
            this.txt_maNhanVien.ReadOnly = true;
            this.txt_maNhanVien.Size = new System.Drawing.Size(244, 30);
            this.txt_maNhanVien.TabIndex = 52;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(49, 161);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(137, 25);
            this.label21.TabIndex = 51;
            this.label21.Text = "Mã Nhân Viên";
            // 
            // btn_hoanThanh
            // 
            this.btn_hoanThanh.BackColor = System.Drawing.Color.White;
            this.btn_hoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoanThanh.Location = new System.Drawing.Point(552, 60);
            this.btn_hoanThanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_hoanThanh.Name = "btn_hoanThanh";
            this.btn_hoanThanh.Size = new System.Drawing.Size(130, 48);
            this.btn_hoanThanh.TabIndex = 45;
            this.btn_hoanThanh.Text = "Hoàn Thành";
            this.btn_hoanThanh.UseVisualStyleBackColor = false;
            this.btn_hoanThanh.Click += new System.EventHandler(this.btn_hoanThanh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(850, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tổng Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = " Ngày Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mã Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã Phiếu Nhập";
            // 
            // txt_tongTIen
            // 
            this.txt_tongTIen.BackColor = System.Drawing.Color.White;
            this.txt_tongTIen.Location = new System.Drawing.Point(260, 274);
            this.txt_tongTIen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tongTIen.Multiline = true;
            this.txt_tongTIen.Name = "txt_tongTIen";
            this.txt_tongTIen.ReadOnly = true;
            this.txt_tongTIen.Size = new System.Drawing.Size(244, 30);
            this.txt_tongTIen.TabIndex = 36;
            // 
            // txt_maPhieuNhap
            // 
            this.txt_maPhieuNhap.BackColor = System.Drawing.Color.White;
            this.txt_maPhieuNhap.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maPhieuNhap.Location = new System.Drawing.Point(260, 60);
            this.txt_maPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_maPhieuNhap.Multiline = true;
            this.txt_maPhieuNhap.Name = "txt_maPhieuNhap";
            this.txt_maPhieuNhap.ReadOnly = true;
            this.txt_maPhieuNhap.Size = new System.Drawing.Size(244, 30);
            this.txt_maPhieuNhap.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 54);
            this.label1.TabIndex = 62;
            this.label1.Text = "Sửa phiếu nhập";
            // 
            // frmSuaPhieuNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1432, 877);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSuaPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuaPhieuNhap";
            this.Load += new System.EventHandler(this.frmSuaPhieuNhap_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cb_timKiem;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dp_ngayNhap;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txt_maNhanVien;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_hoanThanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tongTIen;
        private System.Windows.Forms.TextBox txt_maPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maNCC;
    }
}