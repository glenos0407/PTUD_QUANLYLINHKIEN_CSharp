﻿namespace QUANLYLINHKIEN_PTUD
{
    partial class frmAccessories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccessories));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.imgs_Icon = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgv_Detail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbDetail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbChiTietKH = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbx_GiaTien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_Category = new System.Windows.Forms.ComboBox();
            this.cbx_Producer = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bunifuCustomDataGridAccessory = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGridAccessory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 30);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(508, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Quản Lý Linh Kiện";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnExit.Location = new System.Drawing.Point(1110, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imgs_Icon
            // 
            this.imgs_Icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_Icon.ImageStream")));
            this.imgs_Icon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgs_Icon.Images.SetKeyName(0, "icon_search.png");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.dgv_Detail);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lbChiTietKH);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(743, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 612);
            this.panel4.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 577);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(401, 32);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm vào cơ sở dữ liệu ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgv_Detail
            // 
            this.dgv_Detail.AllowUserToAddRows = false;
            this.dgv_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_Detail.Location = new System.Drawing.Point(6, 348);
            this.dgv_Detail.Name = "dgv_Detail";
            this.dgv_Detail.RowHeadersVisible = false;
            this.dgv_Detail.Size = new System.Drawing.Size(401, 223);
            this.dgv_Detail.TabIndex = 4;
            this.dgv_Detail.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_Detail_RowPostPaint);
            this.dgv_Detail.SelectionChanged += new System.EventHandler(this.dgv_Detail_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Linh Kiện";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loại Linh Kiện";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbDetail);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(410, 304);
            this.panel5.TabIndex = 3;
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDetail.Location = new System.Drawing.Point(86, 184);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(10, 15);
            this.lbDetail.TabIndex = 3;
            this.lbDetail.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(125, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbChiTietKH
            // 
            this.lbChiTietKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(102)))));
            this.lbChiTietKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbChiTietKH.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietKH.ForeColor = System.Drawing.SystemColors.Window;
            this.lbChiTietKH.Location = new System.Drawing.Point(0, 0);
            this.lbChiTietKH.Name = "lbChiTietKH";
            this.lbChiTietKH.Size = new System.Drawing.Size(410, 38);
            this.lbChiTietKH.TabIndex = 1;
            this.lbChiTietKH.Text = "Linh Kiện";
            this.lbChiTietKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnNhapHang);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 121);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm Linh Kiện";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapHang.BackColor = System.Drawing.Color.Maroon;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Location = new System.Drawing.Point(662, 41);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(75, 74);
            this.btnNhapHang.TabIndex = 11;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.cbx_GiaTien);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(459, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 93);
            this.panel3.TabIndex = 10;
            // 
            // cbx_GiaTien
            // 
            this.cbx_GiaTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_GiaTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_GiaTien.FormattingEnabled = true;
            this.cbx_GiaTien.Items.AddRange(new object[] {
            "Giá Tăng Dần",
            "Giá Giảm Dần",
            "Tên A-Z",
            "Tên Z-A"});
            this.cbx_GiaTien.Location = new System.Drawing.Point(5, 61);
            this.cbx_GiaTien.Name = "cbx_GiaTien";
            this.cbx_GiaTien.Size = new System.Drawing.Size(181, 29);
            this.cbx_GiaTien.TabIndex = 4;
            this.cbx_GiaTien.SelectedIndexChanged += new System.EventHandler(this.cbx_GiaTien_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sắp Xếp Giá Tiền";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 93);
            this.panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbx_Category);
            this.groupBox1.Controls.Add(this.cbx_Producer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Theo";
            // 
            // cbx_Category
            // 
            this.cbx_Category.FormattingEnabled = true;
            this.cbx_Category.Items.AddRange(new object[] {
            "Loại Linh Kiện"});
            this.cbx_Category.Location = new System.Drawing.Point(231, 23);
            this.cbx_Category.Name = "cbx_Category";
            this.cbx_Category.Size = new System.Drawing.Size(201, 25);
            this.cbx_Category.TabIndex = 10;
            // 
            // cbx_Producer
            // 
            this.cbx_Producer.FormattingEnabled = true;
            this.cbx_Producer.Items.AddRange(new object[] {
            "Nhà Sản Xuất"});
            this.cbx_Producer.Location = new System.Drawing.Point(9, 23);
            this.cbx_Producer.Name = "cbx_Producer";
            this.cbx_Producer.Size = new System.Drawing.Size(200, 25);
            this.cbx_Producer.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(361, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(8, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(347, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter_1);
            // 
            // bunifuCustomDataGridAccessory
            // 
            this.bunifuCustomDataGridAccessory.AllowUserToAddRows = false;
            this.bunifuCustomDataGridAccessory.AllowUserToResizeColumns = false;
            this.bunifuCustomDataGridAccessory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGridAccessory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGridAccessory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGridAccessory.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGridAccessory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGridAccessory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGridAccessory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGridAccessory.ColumnHeadersHeight = 30;
            this.bunifuCustomDataGridAccessory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGridAccessory.DoubleBuffered = true;
            this.bunifuCustomDataGridAccessory.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGridAccessory.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuCustomDataGridAccessory.HeaderForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomDataGridAccessory.Location = new System.Drawing.Point(0, 151);
            this.bunifuCustomDataGridAccessory.Name = "bunifuCustomDataGridAccessory";
            this.bunifuCustomDataGridAccessory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGridAccessory.RowHeadersVisible = false;
            this.bunifuCustomDataGridAccessory.Size = new System.Drawing.Size(743, 491);
            this.bunifuCustomDataGridAccessory.TabIndex = 8;
            this.bunifuCustomDataGridAccessory.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.bunifuCustomDataGrid1_RowPostPaint);
            this.bunifuCustomDataGridAccessory.SelectionChanged += new System.EventHandler(this.bunifuCustomDataGridAccessory_SelectionChanged);
            // 
            // frmAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(1153, 642);
            this.Controls.Add(this.bunifuCustomDataGridAccessory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccessories";
            this.Text = "frmAccessories";
            this.Load += new System.EventHandler(this.frmAccessories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGridAccessory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imgs_Icon;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbx_GiaTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGridAccessory;
        private System.Windows.Forms.Label lbChiTietKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.DataGridView dgv_Detail;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.ComboBox cbx_Category;
        private System.Windows.Forms.ComboBox cbx_Producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}