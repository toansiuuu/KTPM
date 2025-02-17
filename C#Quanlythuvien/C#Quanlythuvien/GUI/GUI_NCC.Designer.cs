using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    partial class GUI_NCC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_trangthai = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_tenncc = new System.Windows.Forms.TextBox();
            this.tb_mancc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbox_tinhTrang = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.rdo_tenNCC = new System.Windows.Forms.RadioButton();
            this.rdo_maNCC = new System.Windows.Forms.RadioButton();
            this.bttn_sua = new System.Windows.Forms.Button();
            this.bttn_them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsNCC = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_trangthai);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.tb_diachi);
            this.groupBox1.Controls.Add(this.tb_tenncc);
            this.groupBox1.Controls.Add(this.tb_mancc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // tb_trangthai
            // 
            this.tb_trangthai.Location = new System.Drawing.Point(482, 111);
            this.tb_trangthai.Name = "tb_trangthai";
            this.tb_trangthai.ReadOnly = true;
            this.tb_trangthai.Size = new System.Drawing.Size(176, 30);
            this.tb_trangthai.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(482, 46);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(176, 30);
            this.tb_email.TabIndex = 1;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(157, 177);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.ReadOnly = true;
            this.tb_diachi.Size = new System.Drawing.Size(164, 30);
            this.tb_diachi.TabIndex = 1;
            // 
            // tb_tenncc
            // 
            this.tb_tenncc.Location = new System.Drawing.Point(157, 111);
            this.tb_tenncc.Name = "tb_tenncc";
            this.tb_tenncc.ReadOnly = true;
            this.tb_tenncc.Size = new System.Drawing.Size(164, 30);
            this.tb_tenncc.TabIndex = 1;
            // 
            // tb_mancc
            // 
            this.tb_mancc.Location = new System.Drawing.Point(157, 48);
            this.tb_mancc.Name = "tb_mancc";
            this.tb_mancc.ReadOnly = true;
            this.tb_mancc.Size = new System.Drawing.Size(164, 30);
            this.tb_mancc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng Thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NCC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NCC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbbox_tinhTrang);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.tb_timkiem);
            this.groupBox2.Controls.Add(this.rdo_tenNCC);
            this.groupBox2.Controls.Add(this.rdo_maNCC);
            this.groupBox2.Controls.Add(this.bttn_sua);
            this.groupBox2.Controls.Add(this.bttn_them);
            this.groupBox2.Location = new System.Drawing.Point(745, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tình Trạng";
            // 
            // cbbox_tinhTrang
            // 
            this.cbbox_tinhTrang.FormattingEnabled = true;
            this.cbbox_tinhTrang.Items.AddRange(new object[] {
            "Tất Cả",
            "Đang Hoạt Động",
            "Ngừng Hoạt Động"});
            this.cbbox_tinhTrang.Location = new System.Drawing.Point(381, 180);
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
            this.label25.Location = new System.Drawing.Point(157, 123);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 29);
            this.label25.TabIndex = 10;
            this.label25.Text = "Tìm Kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(273, 122);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(265, 36);
            this.tb_timkiem.TabIndex = 9;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // rdo_tenNCC
            // 
            this.rdo_tenNCC.AutoSize = true;
            this.rdo_tenNCC.Location = new System.Drawing.Point(21, 180);
            this.rdo_tenNCC.Name = "rdo_tenNCC";
            this.rdo_tenNCC.Size = new System.Drawing.Size(117, 29);
            this.rdo_tenNCC.TabIndex = 7;
            this.rdo_tenNCC.TabStop = true;
            this.rdo_tenNCC.Text = "Tên NCC";
            this.rdo_tenNCC.UseVisualStyleBackColor = true;
            // 
            // rdo_maNCC
            // 
            this.rdo_maNCC.AutoSize = true;
            this.rdo_maNCC.Location = new System.Drawing.Point(21, 122);
            this.rdo_maNCC.Name = "rdo_maNCC";
            this.rdo_maNCC.Size = new System.Drawing.Size(110, 29);
            this.rdo_maNCC.TabIndex = 8;
            this.rdo_maNCC.TabStop = true;
            this.rdo_maNCC.Text = "Mã NCC";
            this.rdo_maNCC.UseVisualStyleBackColor = true;
            // 
            // bttn_sua
            // 
            this.bttn_sua.Location = new System.Drawing.Point(161, 35);
            this.bttn_sua.Name = "bttn_sua";
            this.bttn_sua.Size = new System.Drawing.Size(106, 57);
            this.bttn_sua.TabIndex = 0;
            this.bttn_sua.Text = "Sửa";
            this.bttn_sua.UseVisualStyleBackColor = true;
            this.bttn_sua.Click += new System.EventHandler(this.bttn_sua_Click);
            // 
            // bttn_them
            // 
            this.bttn_them.Location = new System.Drawing.Point(22, 35);
            this.bttn_them.Name = "bttn_them";
            this.bttn_them.Size = new System.Drawing.Size(106, 57);
            this.bttn_them.TabIndex = 0;
            this.bttn_them.Text = "Thêm";
            this.bttn_them.UseVisualStyleBackColor = true;
            this.bttn_them.Click += new System.EventHandler(this.bttn_them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsNCC);
            this.groupBox3.Location = new System.Drawing.Point(27, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1262, 489);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách";
            // 
            // lsNCC
            // 
            this.lsNCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsNCC.HideSelection = false;
            this.lsNCC.Location = new System.Drawing.Point(3, 26);
            this.lsNCC.Name = "lsNCC";
            this.lsNCC.Size = new System.Drawing.Size(1256, 460);
            this.lsNCC.TabIndex = 0;
            this.lsNCC.UseCompatibleStateImageBehavior = false;
            this.lsNCC.View = System.Windows.Forms.View.Details;
            this.lsNCC.Click += new System.EventHandler(this.lsNCC_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã NCC";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên NCC";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa Chỉ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Trạng Thái";
            // 
            // GUI_NCC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1319, 776);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GUI_NCC";
            this.Text = "GUI_NCC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }     
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
          
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tb_trangthai;
        private TextBox tb_email;
        private TextBox tb_diachi;
        private TextBox tb_tenncc;
        private TextBox tb_mancc;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button bttn_sua;
        private Button bttn_them;
        private GroupBox groupBox3;
        private Label label6;
        private ComboBox cbbox_tinhTrang;
        private Label label25;
        private TextBox tb_timkiem;
        private RadioButton rdo_tenNCC;
        private RadioButton rdo_maNCC;
        private ListView lsNCC;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}