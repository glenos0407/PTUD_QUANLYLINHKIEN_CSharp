namespace QUANLYLINHKIEN_PTUD
{
    partial class frmMainUI_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainUI_Staff));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAccessories = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.cmstrp_Account = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChiTietTKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgs_BtnICon = new System.Windows.Forms.ImageList(this.components);
            this.pnlTop.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.cmstrp_Account.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlTop.Controls.Add(this.btnShowMenu);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(942, 33);
            this.pnlTop.TabIndex = 0;
            // 
            // btnShowMenu
            // 
            this.btnShowMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowMenu.FlatAppearance.BorderSize = 0;
            this.btnShowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMenu.Location = new System.Drawing.Point(0, 0);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(42, 33);
            this.btnShowMenu.TabIndex = 3;
            this.btnShowMenu.UseVisualStyleBackColor = true;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(329, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phần Mềm Quản Lý Mua Bán Linh Kiện";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(911, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = " X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.btnAccount);
            this.pnl_Menu.Controls.Add(this.btnBackUp);
            this.pnl_Menu.Controls.Add(this.btnReport);
            this.pnl_Menu.Controls.Add(this.btnAccessories);
            this.pnl_Menu.Controls.Add(this.btnCustomer);
            this.pnl_Menu.Controls.Add(this.btnPOS);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 33);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(106, 506);
            this.pnl_Menu.TabIndex = 1;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(0, 426);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(1);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(106, 80);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAccount_MouseClick);
            // 
            // btnBackUp
            // 
            this.btnBackUp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBackUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackUp.FlatAppearance.BorderSize = 0;
            this.btnBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackUp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.ForeColor = System.Drawing.Color.White;
            this.btnBackUp.Location = new System.Drawing.Point(0, 320);
            this.btnBackUp.Margin = new System.Windows.Forms.Padding(1);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(106, 80);
            this.btnBackUp.TabIndex = 4;
            this.btnBackUp.Text = "Sao Lưu";
            this.btnBackUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackUp.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(0, 240);
            this.btnReport.Margin = new System.Windows.Forms.Padding(1);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(106, 80);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Báo Cáo";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btnAccessories
            // 
            this.btnAccessories.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAccessories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccessories.FlatAppearance.BorderSize = 0;
            this.btnAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccessories.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessories.ForeColor = System.Drawing.Color.White;
            this.btnAccessories.Location = new System.Drawing.Point(0, 160);
            this.btnAccessories.Margin = new System.Windows.Forms.Padding(1);
            this.btnAccessories.Name = "btnAccessories";
            this.btnAccessories.Size = new System.Drawing.Size(106, 80);
            this.btnAccessories.TabIndex = 2;
            this.btnAccessories.Text = "Linh Kiện";
            this.btnAccessories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccessories.UseVisualStyleBackColor = false;
            this.btnAccessories.Click += new System.EventHandler(this.btnAccessories_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(0, 80);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(1);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(106, 80);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Khách Hàng";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Location = new System.Drawing.Point(0, 0);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(1);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(106, 80);
            this.btnPOS.TabIndex = 0;
            this.btnPOS.Text = "Bán Hàng";
            this.btnPOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPOS.UseVisualStyleBackColor = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(106, 33);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(836, 506);
            this.pnlRight.TabIndex = 2;
            // 
            // cmstrp_Account
            // 
            this.cmstrp_Account.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmstrp_Account.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaiKhoanToolStripMenuItem,
            this.DangXuatToolStripMenuItem});
            this.cmstrp_Account.Name = "cmstrp_Account";
            this.cmstrp_Account.Size = new System.Drawing.Size(156, 56);
            // 
            // TaiKhoanToolStripMenuItem
            // 
            this.TaiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChiTietTKToolStripMenuItem,
            this.ChangePassToolStripMenuItem});
            this.TaiKhoanToolStripMenuItem.Name = "TaiKhoanToolStripMenuItem";
            this.TaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.TaiKhoanToolStripMenuItem.Text = "Tài Khoản";
            // 
            // ChiTietTKToolStripMenuItem
            // 
            this.ChiTietTKToolStripMenuItem.Name = "ChiTietTKToolStripMenuItem";
            this.ChiTietTKToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.ChiTietTKToolStripMenuItem.Text = "Thông Tin Chi Tiết";
            // 
            // ChangePassToolStripMenuItem
            // 
            this.ChangePassToolStripMenuItem.Name = "ChangePassToolStripMenuItem";
            this.ChangePassToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.ChangePassToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.ChangePassToolStripMenuItem.Click += new System.EventHandler(this.ChangePassToolStripMenuItem_Click);
            // 
            // DangXuatToolStripMenuItem
            // 
            this.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            this.DangXuatToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.DangXuatToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // imgs_BtnICon
            // 
            this.imgs_BtnICon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_BtnICon.ImageStream")));
            this.imgs_BtnICon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgs_BtnICon.Images.SetKeyName(0, "icon_account.png");
            this.imgs_BtnICon.Images.SetKeyName(1, "icon_baocao.png");
            this.imgs_BtnICon.Images.SetKeyName(2, "icon_pos.png");
            this.imgs_BtnICon.Images.SetKeyName(3, "icon_save.png");
            this.imgs_BtnICon.Images.SetKeyName(4, "icon_vga.png");
            this.imgs_BtnICon.Images.SetKeyName(5, "icon_custommer.png");
            this.imgs_BtnICon.Images.SetKeyName(6, "icon_menu.png");
            // 
            // frmMainUI_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 539);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainUI_Staff";
            this.Text = "frmMainUI_Staff";
            this.Load += new System.EventHandler(this.frmMainUI_Staff_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnl_Menu.ResumeLayout(false);
            this.cmstrp_Account.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAccessories;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.ContextMenuStrip cmstrp_Account;
        private System.Windows.Forms.ToolStripMenuItem TaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChiTietTKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangXuatToolStripMenuItem;
        private System.Windows.Forms.ImageList imgs_BtnICon;
        private System.Windows.Forms.Button btnShowMenu;
    }
}