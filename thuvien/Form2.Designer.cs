namespace thuvien
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MuonSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.sinhViênToolStripMenuItem,
            this.MuonSachToolStripMenuItem,
            this.returnBookDetailsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.xemSáchToolStripMenuItem});
            this.bookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookToolStripMenuItem.Image")));
            this.bookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(94, 54);
            this.bookToolStripMenuItem.Text = "Sách";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewBookToolStripMenuItem.Image")));
            this.addNewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(190, 56);
            this.addNewBookToolStripMenuItem.Text = "Thêm Sách Mới";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // xemSáchToolStripMenuItem
            // 
            this.xemSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xemSáchToolStripMenuItem.Image")));
            this.xemSáchToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.xemSáchToolStripMenuItem.Name = "xemSáchToolStripMenuItem";
            this.xemSáchToolStripMenuItem.Size = new System.Drawing.Size(190, 56);
            this.xemSáchToolStripMenuItem.Text = "Xem Sách";
            this.xemSáchToolStripMenuItem.Click += new System.EventHandler(this.xemSáchToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmSinhViênToolStripMenuItem,
            this.xemThôngTinSinhViênToolStripMenuItem});
            this.sinhViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sinhViênToolStripMenuItem.Image")));
            this.sinhViênToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(118, 54);
            this.sinhViênToolStripMenuItem.Text = "Sinh Viên";
            // 
            // thêmSinhViênToolStripMenuItem
            // 
            this.thêmSinhViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmSinhViênToolStripMenuItem.Image")));
            this.thêmSinhViênToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.thêmSinhViênToolStripMenuItem.Name = "thêmSinhViênToolStripMenuItem";
            this.thêmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(240, 56);
            this.thêmSinhViênToolStripMenuItem.Text = "Thêm Sinh Viên";
            this.thêmSinhViênToolStripMenuItem.Click += new System.EventHandler(this.thêmSinhViênToolStripMenuItem_Click);
            // 
            // xemThôngTinSinhViênToolStripMenuItem
            // 
            this.xemThôngTinSinhViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xemThôngTinSinhViênToolStripMenuItem.Image")));
            this.xemThôngTinSinhViênToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.xemThôngTinSinhViênToolStripMenuItem.Name = "xemThôngTinSinhViênToolStripMenuItem";
            this.xemThôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(240, 56);
            this.xemThôngTinSinhViênToolStripMenuItem.Text = "Xem Thông Tin Sinh Viên";
            this.xemThôngTinSinhViênToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinSinhViênToolStripMenuItem_Click);
            // 
            // MuonSachToolStripMenuItem
            // 
            this.MuonSachToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("MuonSachToolStripMenuItem.Image")));
            this.MuonSachToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MuonSachToolStripMenuItem.Name = "MuonSachToolStripMenuItem";
            this.MuonSachToolStripMenuItem.Size = new System.Drawing.Size(128, 54);
            this.MuonSachToolStripMenuItem.Text = "Mượn sách";
            this.MuonSachToolStripMenuItem.Click += new System.EventHandler(this.MuonSachToolStripMenuItem_Click);
            // 
            // returnBookDetailsToolStripMenuItem
            // 
            this.returnBookDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnBookDetailsToolStripMenuItem.Image")));
            this.returnBookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnBookDetailsToolStripMenuItem.Name = "returnBookDetailsToolStripMenuItem";
            this.returnBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(160, 54);
            this.returnBookDetailsToolStripMenuItem.Text = "Sách Đang Mượn";
            this.returnBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.returnBookDetailsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(88, 54);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 631);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MuonSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}