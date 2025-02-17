namespace GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttn_Login = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 388);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Location = new System.Drawing.Point(253, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(366, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(323, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 37);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.bttn_Login);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(253, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 343);
            this.panel2.TabIndex = 1;
            // 
            // bttn_Login
            // 
            this.bttn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.bttn_Login.FlatAppearance.BorderSize = 3;
            this.bttn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(83)))), ((int)(((byte)(185)))));
            this.bttn_Login.Location = new System.Drawing.Point(62, 219);
            this.bttn_Login.Name = "bttn_Login";
            this.bttn_Login.Size = new System.Drawing.Size(285, 52);
            this.bttn_Login.TabIndex = 3;
            this.bttn_Login.Text = "Login";
            this.bttn_Login.UseVisualStyleBackColor = false;
            this.bttn_Login.Click += new System.EventHandler(this.bttn_Login_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.txtPass);
            this.panel5.Controls.Add(this.iconButton2);
            this.panel5.Location = new System.Drawing.Point(25, 131);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(364, 56);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.panel6.Location = new System.Drawing.Point(57, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 1);
            this.panel6.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtPass.Location = new System.Drawing.Point(57, 15);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(285, 23);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Password";
            this.txtPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPass_MouseClick);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.Location = new System.Drawing.Point(16, 15);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 36);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.TabStop = false;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtUsername);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Location = new System.Drawing.Point(25, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 56);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.panel4.Location = new System.Drawing.Point(57, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 1);
            this.panel4.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.txtUsername.Location = new System.Drawing.Point(57, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(285, 23);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsername_MouseClick);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(16, 15);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(35, 36);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.TabStop = false;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(187)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(659, 386);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Button bttn_Login;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPass;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtUsername;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

