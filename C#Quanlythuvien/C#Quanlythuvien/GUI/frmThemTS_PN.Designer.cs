namespace GUI
{
    partial class frmThemTS_PN
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maSach = new System.Windows.Forms.TextBox();
            this.txt_tenSach = new System.Windows.Forms.TextBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // txt_maSach
            // 
            this.txt_maSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSach.Location = new System.Drawing.Point(194, 29);
            this.txt_maSach.Name = "txt_maSach";
            this.txt_maSach.ReadOnly = true;
            this.txt_maSach.Size = new System.Drawing.Size(211, 30);
            this.txt_maSach.TabIndex = 4;
            // 
            // txt_tenSach
            // 
            this.txt_tenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenSach.Location = new System.Drawing.Point(194, 76);
            this.txt_tenSach.Name = "txt_tenSach";
            this.txt_tenSach.ReadOnly = true;
            this.txt_tenSach.Size = new System.Drawing.Size(211, 30);
            this.txt_tenSach.TabIndex = 5;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soLuong.Location = new System.Drawing.Point(194, 124);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(211, 30);
            this.txt_soLuong.TabIndex = 6;
            // 
            // txt_donGia
            // 
            this.txt_donGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donGia.Location = new System.Drawing.Point(194, 169);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(211, 30);
            this.txt_donGia.TabIndex = 7;
            this.txt_donGia.TextChanged += new System.EventHandler(this.txt_donGia_TextChanged);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(66, 224);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(111, 43);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(221, 224);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(114, 43);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frmThemTS_PN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(435, 294);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_donGia);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.txt_tenSach);
            this.Controls.Add(this.txt_maSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemTS_PN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemTS_PN";
            this.Load += new System.EventHandler(this.frmThemTS_PN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maSach;
        private System.Windows.Forms.TextBox txt_tenSach;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_thoat;
    }
}