namespace GUI
{
    partial class ThemTuaSach
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
            this.tableCuonSach = new System.Windows.Forms.DataGridView();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtMota = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtTheLoai = new System.Windows.Forms.RichTextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtNamxb = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtNXB = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTacGia = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTenSach = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMasach = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableCuonSach)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableCuonSach
            // 
            this.tableCuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableCuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSach,
            this.MaCuonSach,
            this.StatusCuonSach});
            this.tableCuonSach.Location = new System.Drawing.Point(12, 464);
            this.tableCuonSach.Name = "tableCuonSach";
            this.tableCuonSach.ReadOnly = true;
            this.tableCuonSach.RowHeadersWidth = 51;
            this.tableCuonSach.RowTemplate.Height = 24;
            this.tableCuonSach.Size = new System.Drawing.Size(758, 286);
            this.tableCuonSach.TabIndex = 16;
            this.tableCuonSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCuonSach_CellClick);
            // 
            // maSach
            // 
            this.maSach.HeaderText = "Mã sách";
            this.maSach.MinimumWidth = 6;
            this.maSach.Name = "maSach";
            this.maSach.ReadOnly = true;
            // 
            // MaCuonSach
            // 
            this.MaCuonSach.HeaderText = "Mã cuốn sách";
            this.MaCuonSach.MinimumWidth = 6;
            this.MaCuonSach.Name = "MaCuonSach";
            this.MaCuonSach.ReadOnly = true;
            // 
            // StatusCuonSach
            // 
            this.StatusCuonSach.HeaderText = "Tình Trạng";
            this.StatusCuonSach.MinimumWidth = 6;
            this.StatusCuonSach.Name = "StatusCuonSach";
            this.StatusCuonSach.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 423);
            this.panel1.TabIndex = 17;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.txtMota);
            this.panel15.Controls.Add(this.label5);
            this.panel15.Location = new System.Drawing.Point(319, 267);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(857, 122);
            this.panel15.TabIndex = 12;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Black;
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 120);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(857, 2);
            this.panel16.TabIndex = 5;
            // 
            // txtMota
            // 
            this.txtMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.Location = new System.Drawing.Point(156, 15);
            this.txtMota.Name = "txtMota";
            this.txtMota.ReadOnly = true;
            this.txtMota.Size = new System.Drawing.Size(692, 99);
            this.txtMota.TabIndex = 13;
            this.txtMota.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mô tả";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtTheLoai);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(752, 31);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(424, 47);
            this.panel9.TabIndex = 11;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.BackColor = System.Drawing.Color.White;
            this.txtTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.Location = new System.Drawing.Point(158, 14);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.ReadOnly = true;
            this.txtTheLoai.Size = new System.Drawing.Size(257, 30);
            this.txtTheLoai.TabIndex = 19;
            this.txtTheLoai.Text = "";
            this.txtTheLoai.WordWrap = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 45);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(424, 2);
            this.panel10.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thể loại";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txtNamxb);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.label4);
            this.panel13.Location = new System.Drawing.Point(752, 201);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(424, 47);
            this.panel13.TabIndex = 9;
            // 
            // txtNamxb
            // 
            this.txtNamxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamxb.Location = new System.Drawing.Point(153, 15);
            this.txtNamxb.Name = "txtNamxb";
            this.txtNamxb.Size = new System.Drawing.Size(268, 23);
            this.txtNamxb.TabIndex = 13;
            this.txtNamxb.Text = "Mã sách";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 45);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(424, 2);
            this.panel14.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm xuất bản";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtNXB);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Location = new System.Drawing.Point(322, 201);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(424, 47);
            this.panel11.TabIndex = 8;
            // 
            // txtNXB
            // 
            this.txtNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNXB.Location = new System.Drawing.Point(153, 13);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(268, 23);
            this.txtNXB.TabIndex = 13;
            this.txtNXB.Text = "Mã sách";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 45);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(424, 2);
            this.panel12.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhà xuất bản";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtTacGia);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(752, 113);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(424, 47);
            this.panel7.TabIndex = 6;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(153, 13);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(268, 23);
            this.txtTacGia.TabIndex = 13;
            this.txtTacGia.Text = "Mã sách";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(424, 2);
            this.panel8.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tác giả";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtTenSach);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lblTenSach);
            this.panel5.Location = new System.Drawing.Point(322, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(424, 47);
            this.panel5.TabIndex = 5;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(153, 15);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(268, 23);
            this.txtTenSach.TabIndex = 7;
            this.txtTenSach.Text = "Mã sách";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(424, 2);
            this.panel6.TabIndex = 5;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(14, 15);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(94, 25);
            this.lblTenSach.TabIndex = 3;
            this.lblTenSach.Text = "Tên sách";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMasach);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lbMaSach);
            this.panel3.Location = new System.Drawing.Point(322, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 47);
            this.panel3.TabIndex = 4;
            // 
            // txtMasach
            // 
            this.txtMasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasach.Location = new System.Drawing.Point(153, 15);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(268, 23);
            this.txtMasach.TabIndex = 6;
            this.txtMasach.Text = "Mã sách";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(424, 2);
            this.panel4.TabIndex = 5;
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSach.Location = new System.Drawing.Point(14, 15);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(87, 25);
            this.lbMaSach.TabIndex = 3;
            this.lbMaSach.Text = "Mã sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(22, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1253, 8);
            this.panel2.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(809, 539);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(185, 54);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(809, 464);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(185, 54);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Thay đổi trạng thái";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // ThemTuaSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1277, 762);
            this.ControlBox = false;
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableCuonSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ThemTuaSach";
            ((System.ComponentModel.ISupportInitialize)(this.tableCuonSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tableCuonSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMota;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtNamxb;
        private System.Windows.Forms.Label txtNXB;
        private System.Windows.Forms.Label txtTacGia;
        private System.Windows.Forms.Label txtTenSach;
        private System.Windows.Forms.Label txtMasach;
        private System.Windows.Forms.RichTextBox txtTheLoai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusCuonSach;
    }
}