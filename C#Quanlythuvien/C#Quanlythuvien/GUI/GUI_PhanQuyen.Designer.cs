namespace GUI
{
    partial class GUI_PhanQuyen
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_maQuyen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_tenQuyen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_moTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.tb_tenquyen = new System.Windows.Forms.TextBox();
            this.tb_maquyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_maQuyen,
            this.col_tenQuyen,
            this.col_moTa});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 26);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1234, 473);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // col_maQuyen
            // 
            this.col_maQuyen.Text = "Mã quyền";
            // 
            // col_tenQuyen
            // 
            this.col_tenQuyen.Text = "Tên quyền";
            // 
            // col_moTa
            // 
            this.col_moTa.Text = "Mô tả";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(942, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_mota);
            this.groupBox1.Controls.Add(this.tb_tenquyen);
            this.groupBox1.Controls.Add(this.tb_maquyen);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1234, 182);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(551, 52);
            this.tb_mota.Multiline = true;
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.ReadOnly = true;
            this.tb_mota.Size = new System.Drawing.Size(221, 30);
            this.tb_mota.TabIndex = 4;
            // 
            // tb_tenquyen
            // 
            this.tb_tenquyen.Location = new System.Drawing.Point(199, 115);
            this.tb_tenquyen.Name = "tb_tenquyen";
            this.tb_tenquyen.ReadOnly = true;
            this.tb_tenquyen.Size = new System.Drawing.Size(221, 30);
            this.tb_tenquyen.TabIndex = 4;
            // 
            // tb_maquyen
            // 
            this.tb_maquyen.Location = new System.Drawing.Point(199, 52);
            this.tb_maquyen.Name = "tb_maquyen";
            this.tb_maquyen.ReadOnly = true;
            this.tb_maquyen.Size = new System.Drawing.Size(221, 30);
            this.tb_maquyen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô Tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Quyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Quyền";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(35, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1240, 502);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách";
            // 
            // GUI_PhanQuyen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1319, 776);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GUI_PhanQuyen";
            this.Text = "GUI_PhanQuyen";
            this.Load += new System.EventHandler(this.GUI_PhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader col_maQuyen;
        private System.Windows.Forms.ColumnHeader col_tenQuyen;
        private System.Windows.Forms.ColumnHeader col_moTa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.TextBox tb_tenquyen;
        private System.Windows.Forms.TextBox tb_maquyen;
    }
}