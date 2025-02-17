namespace GUI
{
    partial class TacGiaUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_trangThai = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.lbl_ma = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_trangThai
            // 
            this.lbl_trangThai.AutoSize = true;
            this.lbl_trangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trangThai.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbl_trangThai.Location = new System.Drawing.Point(271, 121);
            this.lbl_trangThai.Name = "lbl_trangThai";
            this.lbl_trangThai.Size = new System.Drawing.Size(42, 20);
            this.lbl_trangThai.TabIndex = 12;
            this.lbl_trangThai.Text = "Tên:";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbl_ten.Location = new System.Drawing.Point(271, 77);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(42, 20);
            this.lbl_ten.TabIndex = 11;
            this.lbl_ten.Text = "Tên:";
            // 
            // lbl_ma
            // 
            this.lbl_ma.AutoSize = true;
            this.lbl_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ma.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbl_ma.Location = new System.Drawing.Point(271, 35);
            this.lbl_ma.Name = "lbl_ma";
            this.lbl_ma.Size = new System.Drawing.Size(42, 20);
            this.lbl_ma.TabIndex = 10;
            this.lbl_ma.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(168, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tình trạng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(164, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(164, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // TacGiaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_trangThai);
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.lbl_ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TacGiaUserControl";
            this.Size = new System.Drawing.Size(438, 180);
            this.Load += new System.EventHandler(this.TacGiaUserControl_Load);
            this.Click += new System.EventHandler(this.TacGiaUserControl_Click);
            this.MouseEnter += new System.EventHandler(this.TacGiaUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.TacGiaUserControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_trangThai;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label lbl_ma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
