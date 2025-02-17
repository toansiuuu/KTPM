namespace GUI
{
    partial class GUI_TheLoai
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.rt_moTa = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_moTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.cb_timKiem = new System.Windows.Forms.ComboBox();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(346, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ THỂ LOẠI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(401, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(158, 134);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(176, 30);
            this.txt_ten.TabIndex = 8;
            // 
            // rt_moTa
            // 
            this.rt_moTa.Location = new System.Drawing.Point(485, 54);
            this.rt_moTa.Name = "rt_moTa";
            this.rt_moTa.Size = new System.Drawing.Size(321, 148);
            this.rt_moTa.TabIndex = 9;
            this.rt_moTa.Text = "";
            this.rt_moTa.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ma,
            this.col_ten,
            this.col_moTa});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 451);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1050, 289);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // col_ma
            // 
            this.col_ma.Text = "Mã thể loại";
            this.col_ma.Width = 89;
            // 
            // col_ten
            // 
            this.col_ten.Text = "Tên thể loại";
            this.col_ten.Width = 96;
            // 
            // col_moTa
            // 
            this.col_moTa.Text = "Mô tả";
            this.col_moTa.Width = 238;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_them.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(39, 73);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(130, 50);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_capNhat.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capNhat.ForeColor = System.Drawing.Color.White;
            this.btn_capNhat.Location = new System.Drawing.Point(39, 158);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(130, 50);
            this.btn_capNhat.TabIndex = 14;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.UseVisualStyleBackColor = false;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // cb_timKiem
            // 
            this.cb_timKiem.FormattingEnabled = true;
            this.cb_timKiem.Items.AddRange(new object[] {
            "Tên",
            "Mã"});
            this.cb_timKiem.Location = new System.Drawing.Point(36, 41);
            this.cb_timKiem.Name = "cb_timKiem";
            this.cb_timKiem.Size = new System.Drawing.Size(95, 33);
            this.cb_timKiem.TabIndex = 15;
            this.cb_timKiem.SelectedIndexChanged += new System.EventHandler(this.cb_timKiem_SelectedIndexChanged);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(145, 41);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(248, 30);
            this.txt_timKiem.TabIndex = 16;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(158, 54);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(176, 30);
            this.txt_ma.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_lamMoi.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_lamMoi.Location = new System.Drawing.Point(39, 240);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(130, 50);
            this.btn_lamMoi.TabIndex = 20;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = false;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.rt_moTa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 243);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_timKiem);
            this.groupBox2.Controls.Add(this.cb_timKiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(27, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 110);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Controls.Add(this.btn_capNhat);
            this.groupBox3.Controls.Add(this.btn_lamMoi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(883, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 359);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao Tác";
            // 
            // GUI_TheLoai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1102, 752);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_TheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_TheLoai";
            this.Load += new System.EventHandler(this.GUI_TheLoai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.RichTextBox rt_moTa;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader col_ma;
        private System.Windows.Forms.ColumnHeader col_ten;
        private System.Windows.Forms.ColumnHeader col_moTa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.ComboBox cb_timKiem;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}