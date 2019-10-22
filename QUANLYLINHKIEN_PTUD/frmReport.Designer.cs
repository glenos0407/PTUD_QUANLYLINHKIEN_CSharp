namespace QUANLYLINHKIEN_PTUD
{
    partial class frmReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.pnlNgayThangNam = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaoCaoNam = new System.Windows.Forms.Button();
            this.btnBaoCaoThang = new System.Windows.Forms.Button();
            this.btnBaoCaoNgay = new System.Windows.Forms.Button();
            this.btnLuuBaoCao = new System.Windows.Forms.Button();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlNgayThangNam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lbTieuDe);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 28);
            this.panel2.TabIndex = 1;
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lbTieuDe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.Maroon;
            this.lbTieuDe.Location = new System.Drawing.Point(15, 4);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(950, 21);
            this.lbTieuDe.TabIndex = 2;
            this.lbTieuDe.Text = "Báo Cáo Thống Kê";
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnExit.Location = new System.Drawing.Point(971, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 28);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlNgayThangNam);
            this.panel1.Controls.Add(this.btnLuuBaoCao);
            this.panel1.Controls.Add(this.btnXuatBaoCao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 88);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtp_NgayKetThuc);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtp_NgayBatDau);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(183, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 88);
            this.panel3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(208, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "-->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Đến";
            // 
            // dtp_NgayKetThuc
            // 
            this.dtp_NgayKetThuc.CalendarForeColor = System.Drawing.Color.Black;
            this.dtp_NgayKetThuc.CalendarTitleForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtp_NgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayKetThuc.Location = new System.Drawing.Point(247, 46);
            this.dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            this.dtp_NgayKetThuc.Size = new System.Drawing.Size(153, 29);
            this.dtp_NgayKetThuc.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bắt Đầu Từ";
            // 
            // dtp_NgayBatDau
            // 
            this.dtp_NgayBatDau.CalendarForeColor = System.Drawing.Color.Black;
            this.dtp_NgayBatDau.CalendarTitleForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtp_NgayBatDau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayBatDau.Location = new System.Drawing.Point(43, 46);
            this.dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            this.dtp_NgayBatDau.Size = new System.Drawing.Size(153, 29);
            this.dtp_NgayBatDau.TabIndex = 29;
            // 
            // pnlNgayThangNam
            // 
            this.pnlNgayThangNam.Controls.Add(this.label1);
            this.pnlNgayThangNam.Controls.Add(this.btnBaoCaoNam);
            this.pnlNgayThangNam.Controls.Add(this.btnBaoCaoThang);
            this.pnlNgayThangNam.Controls.Add(this.btnBaoCaoNgay);
            this.pnlNgayThangNam.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNgayThangNam.Location = new System.Drawing.Point(0, 0);
            this.pnlNgayThangNam.Name = "pnlNgayThangNam";
            this.pnlNgayThangNam.Size = new System.Drawing.Size(183, 88);
            this.pnlNgayThangNam.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Báo Cáo Theo";
            // 
            // btnBaoCaoNam
            // 
            this.btnBaoCaoNam.BackColor = System.Drawing.Color.Firebrick;
            this.btnBaoCaoNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoNam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoNam.ForeColor = System.Drawing.Color.White;
            this.btnBaoCaoNam.Location = new System.Drawing.Point(125, 43);
            this.btnBaoCaoNam.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaoCaoNam.Name = "btnBaoCaoNam";
            this.btnBaoCaoNam.Size = new System.Drawing.Size(55, 32);
            this.btnBaoCaoNam.TabIndex = 15;
            this.btnBaoCaoNam.Text = "Năm";
            this.btnBaoCaoNam.UseVisualStyleBackColor = false;
            // 
            // btnBaoCaoThang
            // 
            this.btnBaoCaoThang.BackColor = System.Drawing.Color.Firebrick;
            this.btnBaoCaoThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoThang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoThang.ForeColor = System.Drawing.Color.White;
            this.btnBaoCaoThang.Location = new System.Drawing.Point(70, 43);
            this.btnBaoCaoThang.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaoCaoThang.Name = "btnBaoCaoThang";
            this.btnBaoCaoThang.Size = new System.Drawing.Size(55, 32);
            this.btnBaoCaoThang.TabIndex = 14;
            this.btnBaoCaoThang.Text = "Tháng";
            this.btnBaoCaoThang.UseVisualStyleBackColor = false;
            // 
            // btnBaoCaoNgay
            // 
            this.btnBaoCaoNgay.BackColor = System.Drawing.Color.Firebrick;
            this.btnBaoCaoNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoNgay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoNgay.ForeColor = System.Drawing.Color.White;
            this.btnBaoCaoNgay.Location = new System.Drawing.Point(15, 43);
            this.btnBaoCaoNgay.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaoCaoNgay.Name = "btnBaoCaoNgay";
            this.btnBaoCaoNgay.Size = new System.Drawing.Size(55, 32);
            this.btnBaoCaoNgay.TabIndex = 13;
            this.btnBaoCaoNgay.Text = "Ngày";
            this.btnBaoCaoNgay.UseVisualStyleBackColor = false;
            // 
            // btnLuuBaoCao
            // 
            this.btnLuuBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuBaoCao.BackColor = System.Drawing.Color.Chocolate;
            this.btnLuuBaoCao.FlatAppearance.BorderSize = 0;
            this.btnLuuBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnLuuBaoCao.Location = new System.Drawing.Point(741, 15);
            this.btnLuuBaoCao.Name = "btnLuuBaoCao";
            this.btnLuuBaoCao.Size = new System.Drawing.Size(134, 60);
            this.btnLuuBaoCao.TabIndex = 9;
            this.btnLuuBaoCao.Text = "Lưu Báo Cáo";
            this.btnLuuBaoCao.UseVisualStyleBackColor = false;
            this.btnLuuBaoCao.Click += new System.EventHandler(this.btnLuuBaoCao_Click);
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatBaoCao.BackColor = System.Drawing.Color.Green;
            this.btnXuatBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXuatBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXuatBaoCao.Location = new System.Drawing.Point(881, 15);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(131, 60);
            this.btnXuatBaoCao.TabIndex = 6;
            this.btnXuatBaoCao.Text = "Xuất Báo Cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = false;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 116);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1023, 499);
            this.bunifuCustomDataGrid1.TabIndex = 3;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(1023, 615);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlNgayThangNam.ResumeLayout(false);
            this.pnlNgayThangNam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLuuBaoCao;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbTieuDe;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Panel pnlNgayThangNam;
        private System.Windows.Forms.Button btnBaoCaoNam;
        private System.Windows.Forms.Button btnBaoCaoThang;
        private System.Windows.Forms.Button btnBaoCaoNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_NgayKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_NgayBatDau;
        private System.Windows.Forms.Label label4;
    }
}