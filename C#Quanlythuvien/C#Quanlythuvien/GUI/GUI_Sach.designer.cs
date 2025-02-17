namespace GUI
{
    partial class GUI_Sach
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnTacGia = new FontAwesome.Sharp.IconButton();
            this.btnTheLoai = new FontAwesome.Sharp.IconButton();
            this.btnNhaXuatBan = new FontAwesome.Sharp.IconButton();
            this.flowpanelSach = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTiemKiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new FontAwesome.Sharp.IconButton();
            this.cbTimkiem = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton1.AutoSize = true;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 120;
            this.iconButton1.Location = new System.Drawing.Point(26, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(300, 200);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Sách";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnTacGia
            // 
            this.btnTacGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTacGia.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTacGia.Enabled = false;
            this.btnTacGia.FlatAppearance.BorderSize = 0;
            this.btnTacGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGia.ForeColor = System.Drawing.Color.White;
            this.btnTacGia.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.btnTacGia.IconColor = System.Drawing.Color.White;
            this.btnTacGia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTacGia.IconSize = 120;
            this.btnTacGia.Location = new System.Drawing.Point(350, 12);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(300, 200);
            this.btnTacGia.TabIndex = 4;
            this.btnTacGia.Text = "Tác Giả";
            this.btnTacGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTacGia.UseVisualStyleBackColor = false;
            this.btnTacGia.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTheLoai.Enabled = false;
            this.btnTheLoai.FlatAppearance.BorderSize = 0;
            this.btnTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheLoai.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.btnTheLoai.IconColor = System.Drawing.Color.White;
            this.btnTheLoai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTheLoai.IconSize = 120;
            this.btnTheLoai.Location = new System.Drawing.Point(678, 12);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(300, 200);
            this.btnTheLoai.TabIndex = 5;
            this.btnTheLoai.Text = "Thể Loại";
            this.btnTheLoai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTheLoai.UseVisualStyleBackColor = false;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnNhaXuatBan
            // 
            this.btnNhaXuatBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNhaXuatBan.BackColor = System.Drawing.Color.Red;
            this.btnNhaXuatBan.Enabled = false;
            this.btnNhaXuatBan.FlatAppearance.BorderSize = 0;
            this.btnNhaXuatBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaXuatBan.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            this.btnNhaXuatBan.IconColor = System.Drawing.Color.White;
            this.btnNhaXuatBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhaXuatBan.IconSize = 120;
            this.btnNhaXuatBan.Location = new System.Drawing.Point(1005, 12);
            this.btnNhaXuatBan.Name = "btnNhaXuatBan";
            this.btnNhaXuatBan.Size = new System.Drawing.Size(300, 200);
            this.btnNhaXuatBan.TabIndex = 6;
            this.btnNhaXuatBan.Text = "Nhà Xuất Bản";
            this.btnNhaXuatBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhaXuatBan.UseVisualStyleBackColor = false;
            this.btnNhaXuatBan.Click += new System.EventHandler(this.btnNhaXuatBan_Click);
            // 
            // flowpanelSach
            // 
            this.flowpanelSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowpanelSach.AutoScroll = true;
            this.flowpanelSach.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.flowpanelSach.BackColor = System.Drawing.Color.Transparent;
            this.flowpanelSach.Location = new System.Drawing.Point(104, 292);
            this.flowpanelSach.Name = "flowpanelSach";
            this.flowpanelSach.Size = new System.Drawing.Size(1119, 520);
            this.flowpanelSach.TabIndex = 7;
            // 
            // txtTiemKiem
            // 
            this.txtTiemKiem.BackColor = System.Drawing.SystemColors.Control;
            this.txtTiemKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiemKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiemKiem.Location = new System.Drawing.Point(357, 232);
            this.txtTiemKiem.Name = "txtTiemKiem";
            this.txtTiemKiem.Size = new System.Drawing.Size(535, 31);
            this.txtTiemKiem.TabIndex = 8;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimkiem.IconColor = System.Drawing.Color.White;
            this.btnTimkiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimkiem.IconSize = 30;
            this.btnTimkiem.Location = new System.Drawing.Point(891, 227);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(58, 39);
            this.btnTimkiem.TabIndex = 9;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // cbTimkiem
            // 
            this.cbTimkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimkiem.FormattingEnabled = true;
            this.cbTimkiem.Items.AddRange(new object[] {
            "",
            "Thể loại",
            "Tác giả"});
            this.cbTimkiem.Location = new System.Drawing.Point(205, 229);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(121, 37);
            this.cbTimkiem.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(350, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 3);
            this.panel1.TabIndex = 11;
            // 
            // GUI_Sach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1329, 815);
            this.ControlBox = false;
            this.Controls.Add(this.cbTimkiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTiemKiem);
            this.Controls.Add(this.flowpanelSach);
            this.Controls.Add(this.btnNhaXuatBan);
            this.Controls.Add(this.btnTheLoai);
            this.Controls.Add(this.btnTacGia);
            this.Controls.Add(this.iconButton1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "GUI_Sach";
            this.Load += new System.EventHandler(this.GUI_Sach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnTacGia;
        private FontAwesome.Sharp.IconButton btnTheLoai;
        private FontAwesome.Sharp.IconButton btnNhaXuatBan;
        private System.Windows.Forms.FlowLayoutPanel flowpanelSach;
        private System.Windows.Forms.TextBox txtTiemKiem;
        private FontAwesome.Sharp.IconButton btnTimkiem;
        private System.Windows.Forms.ComboBox cbTimkiem;
        private System.Windows.Forms.Panel panel1;
    }
}