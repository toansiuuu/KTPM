namespace GUI
{
    partial class frmGanQuyen
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
            this.rdo_tt = new System.Windows.Forms.RadioButton();
            this.rdo_nvk = new System.Windows.Forms.RadioButton();
            this.rdo_qtv = new System.Windows.Forms.RadioButton();
            this.rdo_ql = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttn_hoanthanh = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_tt);
            this.groupBox2.Controls.Add(this.rdo_nvk);
            this.groupBox2.Controls.Add(this.rdo_qtv);
            this.groupBox2.Controls.Add(this.rdo_ql);
            this.groupBox2.Location = new System.Drawing.Point(35, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(407, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quyền";
            // 
            // rdo_tt
            // 
            this.rdo_tt.AutoSize = true;
            this.rdo_tt.Location = new System.Drawing.Point(222, 91);
            this.rdo_tt.Name = "rdo_tt";
            this.rdo_tt.Size = new System.Drawing.Size(108, 29);
            this.rdo_tt.TabIndex = 0;
            this.rdo_tt.TabStop = true;
            this.rdo_tt.Text = "Thủ Thư";
            this.rdo_tt.UseVisualStyleBackColor = true;
            // 
            // rdo_nvk
            // 
            this.rdo_nvk.AutoSize = true;
            this.rdo_nvk.Location = new System.Drawing.Point(222, 40);
            this.rdo_nvk.Name = "rdo_nvk";
            this.rdo_nvk.Size = new System.Drawing.Size(166, 29);
            this.rdo_nvk.TabIndex = 0;
            this.rdo_nvk.TabStop = true;
            this.rdo_nvk.Text = "Nhân Viên Kho";
            this.rdo_nvk.UseVisualStyleBackColor = true;
            // 
            // rdo_qtv
            // 
            this.rdo_qtv.AutoSize = true;
            this.rdo_qtv.Location = new System.Drawing.Point(35, 87);
            this.rdo_qtv.Name = "rdo_qtv";
            this.rdo_qtv.Size = new System.Drawing.Size(155, 29);
            this.rdo_qtv.TabIndex = 0;
            this.rdo_qtv.TabStop = true;
            this.rdo_qtv.Text = "Quản Trị Viên";
            this.rdo_qtv.UseVisualStyleBackColor = true;
            // 
            // rdo_ql
            // 
            this.rdo_ql.AutoSize = true;
            this.rdo_ql.Location = new System.Drawing.Point(35, 40);
            this.rdo_ql.Name = "rdo_ql";
            this.rdo_ql.Size = new System.Drawing.Size(108, 29);
            this.rdo_ql.TabIndex = 0;
            this.rdo_ql.TabStop = true;
            this.rdo_ql.Text = "Quản Lý";
            this.rdo_ql.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttn_hoanthanh);
            this.groupBox3.Location = new System.Drawing.Point(35, 206);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(407, 136);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao Tác";
            // 
            // bttn_hoanthanh
            // 
            this.bttn_hoanthanh.Location = new System.Drawing.Point(126, 45);
            this.bttn_hoanthanh.Name = "bttn_hoanthanh";
            this.bttn_hoanthanh.Size = new System.Drawing.Size(138, 65);
            this.bttn_hoanthanh.TabIndex = 0;
            this.bttn_hoanthanh.Text = "Hoàn Thành";
            this.bttn_hoanthanh.UseVisualStyleBackColor = true;
            this.bttn_hoanthanh.Click += new System.EventHandler(this.bttn_hoanthanh_Click);
            // 
            // frmGanQuyen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(477, 376);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGanQuyen";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_tt;
        private System.Windows.Forms.RadioButton rdo_nvk;
        private System.Windows.Forms.RadioButton rdo_qtv;
        private System.Windows.Forms.RadioButton rdo_ql;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttn_hoanthanh;
    }
}