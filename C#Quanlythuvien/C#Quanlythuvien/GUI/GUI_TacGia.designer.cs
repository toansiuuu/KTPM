namespace GUI
{
    partial class GUI_TacGia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.cb_timKiem = new System.Windows.Forms.ComboBox();
            this.cb_trangThai = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(444, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ TÁC GIẢ";
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timKiem.Location = new System.Drawing.Point(171, 38);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(220, 36);
            this.txt_timKiem.TabIndex = 10;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // cb_timKiem
            // 
            this.cb_timKiem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cb_timKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_timKiem.ForeColor = System.Drawing.Color.Black;
            this.cb_timKiem.FormattingEnabled = true;
            this.cb_timKiem.Items.AddRange(new object[] {
            "Tên",
            "Mã"});
            this.cb_timKiem.Location = new System.Drawing.Point(15, 40);
            this.cb_timKiem.Name = "cb_timKiem";
            this.cb_timKiem.Size = new System.Drawing.Size(132, 37);
            this.cb_timKiem.TabIndex = 9;
            this.cb_timKiem.SelectedIndexChanged += new System.EventHandler(this.cb_timKiem_SelectedIndexChanged);
            // 
            // cb_trangThai
            // 
            this.cb_trangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_trangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_trangThai.FormattingEnabled = true;
            this.cb_trangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đang hoạt động",
            "Ngừng hoạt động"});
            this.cb_trangThai.Location = new System.Drawing.Point(6, 37);
            this.cb_trangThai.Name = "cb_trangThai";
            this.cb_trangThai.Size = new System.Drawing.Size(221, 37);
            this.cb_trangThai.TabIndex = 13;
            this.cb_trangThai.SelectedIndexChanged += new System.EventHandler(this.cb_trangThai_SelectedIndexChanged);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_them.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(958, 118);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 43);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(137, 225);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1019, 539);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_timKiem);
            this.groupBox1.Controls.Add(this.txt_timKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(137, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 97);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_trangThai);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(615, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 97);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // GUI_TacGia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1329, 832);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label1);
            this.Name = "GUI_TacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_TacGia";
            this.Load += new System.EventHandler(this.GUI_TacGia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.ComboBox cb_timKiem;
        private System.Windows.Forms.ComboBox cb_trangThai;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}