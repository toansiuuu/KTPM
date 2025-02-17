namespace GUI
{
    partial class frmSuaTacGia
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.rd_dang = new System.Windows.Forms.RadioButton();
            this.rd_dung = new System.Windows.Forms.RadioButton();
            this.richtxt_moTa = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(31, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(320, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(320, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(320, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(320, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mô tả";
            // 
            // txt_ma
            // 
            this.txt_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma.Location = new System.Drawing.Point(441, 61);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(182, 30);
            this.txt_ma.TabIndex = 5;
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(441, 113);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(182, 30);
            this.txt_ten.TabIndex = 6;
            // 
            // rd_dang
            // 
            this.rd_dang.AutoSize = true;
            this.rd_dang.ForeColor = System.Drawing.Color.White;
            this.rd_dang.Location = new System.Drawing.Point(14, 13);
            this.rd_dang.Name = "rd_dang";
            this.rd_dang.Size = new System.Drawing.Size(60, 20);
            this.rd_dang.TabIndex = 7;
            this.rd_dang.TabStop = true;
            this.rd_dang.Text = "Đang";
            this.rd_dang.UseVisualStyleBackColor = true;
            // 
            // rd_dung
            // 
            this.rd_dung.AutoSize = true;
            this.rd_dung.ForeColor = System.Drawing.Color.White;
            this.rd_dung.Location = new System.Drawing.Point(123, 13);
            this.rd_dung.Name = "rd_dung";
            this.rd_dung.Size = new System.Drawing.Size(60, 20);
            this.rd_dung.TabIndex = 8;
            this.rd_dung.TabStop = true;
            this.rd_dung.Text = "Dừng";
            this.rd_dung.UseVisualStyleBackColor = true;
            // 
            // richtxt_moTa
            // 
            this.richtxt_moTa.Location = new System.Drawing.Point(441, 218);
            this.richtxt_moTa.Name = "richtxt_moTa";
            this.richtxt_moTa.Size = new System.Drawing.Size(319, 202);
            this.richtxt_moTa.TabIndex = 9;
            this.richtxt_moTa.Text = "";
            this.richtxt_moTa.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_dang);
            this.panel1.Controls.Add(this.rd_dung);
            this.panel1.Location = new System.Drawing.Point(441, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 44);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CapNhat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.Location = new System.Drawing.Point(93, 362);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(115, 36);
            this.btn_CapNhat.TabIndex = 29;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // frmSuaTacGia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richtxt_moTa);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSuaTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuaTacGia";
            this.Load += new System.EventHandler(this.frmSuaTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.RadioButton rd_dang;
        private System.Windows.Forms.RadioButton rd_dung;
        private System.Windows.Forms.RichTextBox richtxt_moTa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_CapNhat;
    }
}