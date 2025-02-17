namespace GUI
{
    partial class GiaHanThe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateBatdau = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dateBatdau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // dateBatdau
            // 
            this.dateBatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBatdau.Location = new System.Drawing.Point(146, 31);
            this.dateBatdau.Name = "dateBatdau";
            this.dateBatdau.Size = new System.Drawing.Size(341, 30);
            this.dateBatdau.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 5);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGiaHan);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gia hạn thẻ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dateKetThuc);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(21, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 70);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(499, 5);
            this.panel4.TabIndex = 3;
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateKetThuc.Location = new System.Drawing.Point(146, 31);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Size = new System.Drawing.Size(341, 30);
            this.dateKetThuc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày kết thúc";
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnGiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaHan.ForeColor = System.Drawing.Color.White;
            this.btnGiaHan.Location = new System.Drawing.Point(218, 224);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(119, 49);
            this.btnGiaHan.TabIndex = 2;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // GiaHanThe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(603, 357);
            this.Controls.Add(this.groupBox1);
            this.Name = "GiaHanThe";
            this.Text = "GiaHanThe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateBatdau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiaHan;
    }
}