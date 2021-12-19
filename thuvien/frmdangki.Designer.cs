namespace thuvien
{
    partial class frmdangki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangki));
            this.txtNUser = new System.Windows.Forms.TextBox();
            this.txtNpassword = new System.Windows.Forms.TextBox();
            this.btnNDangki = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNUser
            // 
            this.txtNUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtNUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNUser.Font = new System.Drawing.Font("Minion Pro", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUser.ForeColor = System.Drawing.Color.White;
            this.txtNUser.Location = new System.Drawing.Point(90, 127);
            this.txtNUser.Name = "txtNUser";
            this.txtNUser.Size = new System.Drawing.Size(154, 15);
            this.txtNUser.TabIndex = 2;
            this.txtNUser.Text = "Nhập Tên tài khoản mới";
            this.txtNUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNUser_MouseClick);
            // 
            // txtNpassword
            // 
            this.txtNpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtNpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNpassword.Font = new System.Drawing.Font("Minion Pro", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNpassword.ForeColor = System.Drawing.Color.White;
            this.txtNpassword.Location = new System.Drawing.Point(90, 171);
            this.txtNpassword.Name = "txtNpassword";
            this.txtNpassword.Size = new System.Drawing.Size(152, 15);
            this.txtNpassword.TabIndex = 3;
            this.txtNpassword.Text = "Nhập Mật khẩu";
            this.txtNpassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNpassword_MouseClick);
            // 
            // btnNDangki
            // 
            this.btnNDangki.BackColor = System.Drawing.Color.White;
            this.btnNDangki.CausesValidation = false;
            this.btnNDangki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNDangki.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNDangki.Location = new System.Drawing.Point(69, 255);
            this.btnNDangki.Name = "btnNDangki";
            this.btnNDangki.Size = new System.Drawing.Size(149, 38);
            this.btnNDangki.TabIndex = 4;
            this.btnNDangki.Text = "Đăng kí";
            this.btnNDangki.UseVisualStyleBackColor = false;
            this.btnNDangki.Click += new System.EventHandler(this.btnNDangki_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(240, 11);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(61, 32);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(90, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 1);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(90, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 1);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(41, 162);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(41, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmdangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(308, 411);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNDangki);
            this.Controls.Add(this.txtNpassword);
            this.Controls.Add(this.txtNUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdangki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmdangki";
            this.Load += new System.EventHandler(this.frmdangki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNUser;
        private System.Windows.Forms.TextBox txtNpassword;
        private System.Windows.Forms.Button btnNDangki;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}