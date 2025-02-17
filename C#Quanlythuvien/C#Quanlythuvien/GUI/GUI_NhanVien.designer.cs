namespace GUI
{
    partial class GUI_NhanVien
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
            this.cb_timKiem = new System.Windows.Forms.ComboBox();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cb_gioiTinh = new System.Windows.Forms.ComboBox();
            this.cb_trangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_timKiem
            // 
            this.cb_timKiem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cb_timKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_timKiem.ForeColor = System.Drawing.Color.Black;
            this.cb_timKiem.FormattingEnabled = true;
            this.cb_timKiem.Items.AddRange(new object[] {
            "Tên",
            "Mã",
            "Chức vụ"});
            this.cb_timKiem.Location = new System.Drawing.Point(11, 58);
            this.cb_timKiem.Name = "cb_timKiem";
            this.cb_timKiem.Size = new System.Drawing.Size(105, 37);
            this.cb_timKiem.TabIndex = 1;
            this.cb_timKiem.SelectedIndexChanged += new System.EventHandler(this.cb_timKiem_SelectedIndexChanged);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timKiem.Location = new System.Drawing.Point(139, 58);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(245, 34);
            this.txt_timKiem.TabIndex = 2;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_them.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(22, 49);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 36);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(76, 197);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1178, 567);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // cb_gioiTinh
            // 
            this.cb_gioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_gioiTinh.FormattingEnabled = true;
            this.cb_gioiTinh.Items.AddRange(new object[] {
            "Tất cả",
            "Nam",
            "Nữ"});
            this.cb_gioiTinh.Location = new System.Drawing.Point(421, 58);
            this.cb_gioiTinh.Name = "cb_gioiTinh";
            this.cb_gioiTinh.Size = new System.Drawing.Size(121, 28);
            this.cb_gioiTinh.TabIndex = 5;
            this.cb_gioiTinh.SelectedIndexChanged += new System.EventHandler(this.cb_gioiTinh_SelectedIndexChanged);
            // 
            // cb_trangThai
            // 
            this.cb_trangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_trangThai.FormattingEnabled = true;
            this.cb_trangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đang làm",
            "Nghỉ làm"});
            this.cb_trangThai.Location = new System.Drawing.Point(567, 57);
            this.cb_trangThai.Name = "cb_trangThai";
            this.cb_trangThai.Size = new System.Drawing.Size(121, 28);
            this.cb_trangThai.TabIndex = 6;
            this.cb_trangThai.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(416, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(562, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trạng thái";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(193, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Xuất excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_timKiem);
            this.groupBox1.Controls.Add(this.cb_trangThai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_timKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_gioiTinh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(115, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(844, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 123);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // GUI_NhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1329, 776);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "GUI_NhanVien";
            this.Text = "GUI_NhanVien";
            this.Load += new System.EventHandler(this.GUI_NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_timKiem;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cb_gioiTinh;
        private System.Windows.Forms.ComboBox cb_trangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}