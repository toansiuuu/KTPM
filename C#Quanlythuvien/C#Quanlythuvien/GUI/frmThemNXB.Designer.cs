namespace GUI
{
    partial class frmThemNXB
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
            this.tb_maNXB = new System.Windows.Forms.TextBox();
            this.tb_tenNXB = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttn_lammoi = new System.Windows.Forms.Button();
            this.bttn_hoanthanh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NXB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // tb_maNXB
            // 
            this.tb_maNXB.Location = new System.Drawing.Point(157, 43);
            this.tb_maNXB.Name = "tb_maNXB";
            this.tb_maNXB.ReadOnly = true;
            this.tb_maNXB.Size = new System.Drawing.Size(206, 30);
            this.tb_maNXB.TabIndex = 2;
            // 
            // tb_tenNXB
            // 
            this.tb_tenNXB.Location = new System.Drawing.Point(157, 95);
            this.tb_tenNXB.Name = "tb_tenNXB";
            this.tb_tenNXB.Size = new System.Drawing.Size(206, 30);
            this.tb_tenNXB.TabIndex = 2;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(157, 146);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(206, 30);
            this.tb_diachi.TabIndex = 2;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(157, 198);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(206, 30);
            this.tb_Email.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_maNXB);
            this.groupBox1.Controls.Add(this.tb_Email);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_diachi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_tenNXB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 251);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttn_lammoi);
            this.groupBox2.Controls.Add(this.bttn_hoanthanh);
            this.groupBox2.Location = new System.Drawing.Point(27, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // bttn_lammoi
            // 
            this.bttn_lammoi.Location = new System.Drawing.Point(256, 29);
            this.bttn_lammoi.Name = "bttn_lammoi";
            this.bttn_lammoi.Size = new System.Drawing.Size(105, 50);
            this.bttn_lammoi.TabIndex = 0;
            this.bttn_lammoi.Text = "Làm Mới";
            this.bttn_lammoi.UseVisualStyleBackColor = true;
            this.bttn_lammoi.Click += new System.EventHandler(this.bttn_lammoi_Click);
            // 
            // bttn_hoanthanh
            // 
            this.bttn_hoanthanh.Location = new System.Drawing.Point(71, 29);
            this.bttn_hoanthanh.Name = "bttn_hoanthanh";
            this.bttn_hoanthanh.Size = new System.Drawing.Size(136, 50);
            this.bttn_hoanthanh.TabIndex = 0;
            this.bttn_hoanthanh.Text = "Hoàn Thành";
            this.bttn_hoanthanh.UseVisualStyleBackColor = true;
            this.bttn_hoanthanh.Click += new System.EventHandler(this.bttn_hoanthanh_Click);
            // 
            // frmThemNXB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(513, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThemNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemNXB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_maNXB;
        private System.Windows.Forms.TextBox tb_tenNXB;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttn_lammoi;
        private System.Windows.Forms.Button bttn_hoanthanh;
    }
}