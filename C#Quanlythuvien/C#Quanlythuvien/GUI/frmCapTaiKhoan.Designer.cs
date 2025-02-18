namespace GUI
{
    partial class frmCapTaiKhoan
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
            this.txt_chucvu = new System.Windows.Forms.TextBox();
            this.txt_tenNV = new System.Windows.Forms.TextBox();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_capTK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_chucvu);
            this.groupBox1.Controls.Add(this.txt_tenNV);
            this.groupBox1.Controls.Add(this.txt_maNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txt_chucvu
            // 
            this.txt_chucvu.Location = new System.Drawing.Point(150, 110);
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.ReadOnly = true;
            this.txt_chucvu.Size = new System.Drawing.Size(250, 26);
            this.txt_chucvu.TabIndex = 1;
            // 
            // txt_tenNV
            // 
            this.txt_tenNV.Location = new System.Drawing.Point(150, 70);
            this.txt_tenNV.Name = "txt_tenNV";
            this.txt_tenNV.ReadOnly = true;
            this.txt_tenNV.Size = new System.Drawing.Size(250, 26);
            this.txt_tenNV.TabIndex = 1;
            // 
            // txt_maNV
            // 
            this.txt_maNV.Location = new System.Drawing.Point(150, 30);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.ReadOnly = true;
            this.txt_maNV.Size = new System.Drawing.Size(250, 26);
            this.txt_maNV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_matKhau);
            this.groupBox2.Controls.Add(this.txt_tenDangNhap);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(150, 70);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(250, 26);
            this.txt_matKhau.TabIndex = 1;
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.Location = new System.Drawing.Point(150, 30);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(250, 26);
            this.txt_tenDangNhap.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên đăng nhập";
            // 
            // btn_capTK
            // 
            this.btn_capTK.Location = new System.Drawing.Point(162, 320);
            this.btn_capTK.Name = "btn_capTK";
            this.btn_capTK.Size = new System.Drawing.Size(150, 40);
            this.btn_capTK.TabIndex = 2;
            this.btn_capTK.Text = "Cấp MK";
            this.btn_capTK.UseVisualStyleBackColor = true;
            this.btn_capTK.Click += new System.EventHandler(this.btn_capTK_Click);
            // 
            // frmCapTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.btn_capTK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCapTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp MK";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_chucvu;
        private System.Windows.Forms.TextBox txt_tenNV;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.TextBox txt_tenDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_capTK;
    }
} 
