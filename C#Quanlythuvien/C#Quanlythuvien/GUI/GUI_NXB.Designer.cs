namespace GUI
{
    partial class GUI_NXB
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsNXB = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbox_tinhTrang = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.rdo_tenNXB = new System.Windows.Forms.RadioButton();
            this.rdo_maNXB = new System.Windows.Forms.RadioButton();
            this.bttn_sua = new System.Windows.Forms.Button();
            this.bttn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsNXB);
            this.groupBox2.Location = new System.Drawing.Point(28, 190);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(890, 324);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // lsNXB
            // 
            this.lsNXB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsNXB.HideSelection = false;
            this.lsNXB.Location = new System.Drawing.Point(4, 28);
            this.lsNXB.Name = "lsNXB";
            this.lsNXB.Size = new System.Drawing.Size(882, 291);
            this.lsNXB.TabIndex = 0;
            this.lsNXB.UseCompatibleStateImageBehavior = false;
            this.lsNXB.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã NXB";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên NXB";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbbox_tinhTrang);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.tb_timkiem);
            this.groupBox3.Controls.Add(this.rdo_tenNXB);
            this.groupBox3.Controls.Add(this.rdo_maNXB);
            this.groupBox3.Location = new System.Drawing.Point(28, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 157);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tình Trạng";
            // 
            // cbbox_tinhTrang
            // 
            this.cbbox_tinhTrang.FormattingEnabled = true;
            this.cbbox_tinhTrang.Items.AddRange(new object[] {
            "Tất Cả",
            "Đang Hoạt Động",
            "Ngừng Hoạt Động"});
            this.cbbox_tinhTrang.Location = new System.Drawing.Point(551, 104);
            this.cbbox_tinhTrang.Name = "cbbox_tinhTrang";
            this.cbbox_tinhTrang.Size = new System.Drawing.Size(157, 33);
            this.cbbox_tinhTrang.TabIndex = 5;
            this.cbbox_tinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbbox_tinhTrang_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.Window;
            this.label25.Location = new System.Drawing.Point(350, 43);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 29);
            this.label25.TabIndex = 4;
            this.label25.Text = "Tìm Kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(466, 42);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(242, 36);
            this.tb_timkiem.TabIndex = 1;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // rdo_tenNXB
            // 
            this.rdo_tenNXB.AutoSize = true;
            this.rdo_tenNXB.Location = new System.Drawing.Point(202, 44);
            this.rdo_tenNXB.Name = "rdo_tenNXB";
            this.rdo_tenNXB.Size = new System.Drawing.Size(114, 29);
            this.rdo_tenNXB.TabIndex = 0;
            this.rdo_tenNXB.TabStop = true;
            this.rdo_tenNXB.Text = "Tên NXB";
            this.rdo_tenNXB.UseVisualStyleBackColor = true;
            // 
            // rdo_maNXB
            // 
            this.rdo_maNXB.AutoSize = true;
            this.rdo_maNXB.Location = new System.Drawing.Point(62, 42);
            this.rdo_maNXB.Name = "rdo_maNXB";
            this.rdo_maNXB.Size = new System.Drawing.Size(107, 29);
            this.rdo_maNXB.TabIndex = 0;
            this.rdo_maNXB.TabStop = true;
            this.rdo_maNXB.Text = "Mã NXB";
            this.rdo_maNXB.UseVisualStyleBackColor = true;
            // 
            // bttn_sua
            // 
            this.bttn_sua.Location = new System.Drawing.Point(34, 93);
            this.bttn_sua.Name = "bttn_sua";
            this.bttn_sua.Size = new System.Drawing.Size(80, 51);
            this.bttn_sua.TabIndex = 2;
            this.bttn_sua.Text = "Sửa";
            this.bttn_sua.UseVisualStyleBackColor = true;
            this.bttn_sua.Click += new System.EventHandler(this.bttn_sua_Click);
            // 
            // bttn_them
            // 
            this.bttn_them.Location = new System.Drawing.Point(34, 27);
            this.bttn_them.Name = "bttn_them";
            this.bttn_them.Size = new System.Drawing.Size(80, 58);
            this.bttn_them.TabIndex = 2;
            this.bttn_them.Text = "Thêm";
            this.bttn_them.UseVisualStyleBackColor = true;
            this.bttn_them.Click += new System.EventHandler(this.bttn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttn_them);
            this.groupBox1.Controls.Add(this.bttn_sua);
            this.groupBox1.Location = new System.Drawing.Point(767, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(151, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // GUI_NXB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(944, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_NXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_NXB";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsNXB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.RadioButton rdo_tenNXB;
        private System.Windows.Forms.RadioButton rdo_maNXB;
        private System.Windows.Forms.Button bttn_sua;
        private System.Windows.Forms.Button bttn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbox_tinhTrang;
        private System.Windows.Forms.Label label1;
    }
}