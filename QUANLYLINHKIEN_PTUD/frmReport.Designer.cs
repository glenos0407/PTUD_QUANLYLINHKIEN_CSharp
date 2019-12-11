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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_LastMonthDown = new System.Windows.Forms.Label();
            this.lb_YesterdayDown = new System.Windows.Forms.Label();
            this.lb_Reply = new System.Windows.Forms.Label();
            this.lb_Revenue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_Accessory = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlNgayThangNam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accessory)).BeginInit();
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
            this.btnBaoCaoNam.Click += new System.EventHandler(this.btnBaoCaoNam_Click);
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
            this.btnBaoCaoThang.Click += new System.EventHandler(this.btnBaoCaoThang_Click);
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
            this.btnBaoCaoNgay.Click += new System.EventHandler(this.btnBaoCaoNgay_Click);
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
            // chartRevenue
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea2);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend2);
            this.chartRevenue.Location = new System.Drawing.Point(0, 0);
            this.chartRevenue.Name = "chartRevenue";
            series2.ChartArea = "ChartArea1";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Doanh thu";
            this.chartRevenue.Series.Add(series2);
            this.chartRevenue.Size = new System.Drawing.Size(550, 405);
            this.chartRevenue.TabIndex = 4;
            this.chartRevenue.Text = "chartRevenue";
            this.chartRevenue.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_LastMonthDown);
            this.groupBox1.Controls.Add(this.lb_YesterdayDown);
            this.groupBox1.Controls.Add(this.lb_Reply);
            this.groupBox1.Controls.Add(this.lb_Revenue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KẾT QUẢ BÁN HÀNG HÔM NAY";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(813, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "So với cùng kỳ tháng trước ";
            this.label16.Click += new System.EventHandler(this.label7_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(568, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "So với hôm qua";
            this.label13.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Sản phẩm";
            this.label10.Click += new System.EventHandler(this.label7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Doanh thu thuần";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lb_LastMonthDown
            // 
            this.lb_LastMonthDown.AutoSize = true;
            this.lb_LastMonthDown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LastMonthDown.Location = new System.Drawing.Point(811, 37);
            this.lb_LastMonthDown.Name = "lb_LastMonthDown";
            this.lb_LastMonthDown.Size = new System.Drawing.Size(173, 30);
            this.lb_LastMonthDown.TabIndex = 6;
            this.lb_LastMonthDown.Text = "Tổng doanh thu";
            this.lb_LastMonthDown.Click += new System.EventHandler(this.label6_Click);
            // 
            // lb_YesterdayDown
            // 
            this.lb_YesterdayDown.AutoSize = true;
            this.lb_YesterdayDown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_YesterdayDown.Location = new System.Drawing.Point(566, 37);
            this.lb_YesterdayDown.Name = "lb_YesterdayDown";
            this.lb_YesterdayDown.Size = new System.Drawing.Size(173, 30);
            this.lb_YesterdayDown.TabIndex = 6;
            this.lb_YesterdayDown.Text = "Tổng doanh thu";
            this.lb_YesterdayDown.Click += new System.EventHandler(this.label6_Click);
            // 
            // lb_Reply
            // 
            this.lb_Reply.AutoSize = true;
            this.lb_Reply.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Reply.Location = new System.Drawing.Point(321, 37);
            this.lb_Reply.Name = "lb_Reply";
            this.lb_Reply.Size = new System.Drawing.Size(173, 30);
            this.lb_Reply.TabIndex = 6;
            this.lb_Reply.Text = "Tổng doanh thu";
            this.lb_Reply.Click += new System.EventHandler(this.label6_Click);
            // 
            // lb_Revenue
            // 
            this.lb_Revenue.AutoSize = true;
            this.lb_Revenue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Revenue.Location = new System.Drawing.Point(76, 37);
            this.lb_Revenue.Name = "lb_Revenue";
            this.lb_Revenue.Size = new System.Drawing.Size(151, 30);
            this.lb_Revenue.TabIndex = 6;
            this.lb_Revenue.Text = "1,000,000,000";
            this.lb_Revenue.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Gửi bảo hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng doanh thu";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(745, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(500, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(255, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_Accessory);
            this.panel4.Controls.Add(this.chartRevenue);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1023, 405);
            this.panel4.TabIndex = 6;
            // 
            // dgv_Accessory
            // 
            this.dgv_Accessory.AllowUserToResizeColumns = false;
            this.dgv_Accessory.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Accessory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Accessory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Accessory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Accessory.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Accessory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Accessory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Accessory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Accessory.ColumnHeadersHeight = 30;
            this.dgv_Accessory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.dgv_Accessory.DoubleBuffered = true;
            this.dgv_Accessory.EnableHeadersVisualStyles = false;
            this.dgv_Accessory.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Accessory.HeaderForeColor = System.Drawing.SystemColors.Window;
            this.dgv_Accessory.Location = new System.Drawing.Point(556, 3);
            this.dgv_Accessory.Name = "dgv_Accessory";
            this.dgv_Accessory.ReadOnly = true;
            this.dgv_Accessory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Accessory.RowHeadersVisible = false;
            this.dgv_Accessory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Accessory.Size = new System.Drawing.Size(467, 399);
            this.dgv_Accessory.TabIndex = 5;
            this.dgv_Accessory.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_Accessory_RowPostPaint);
            // 
            // STT
            // 
            this.STT.FillWeight = 114.2132F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(1023, 615);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accessory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLuuBaoCao;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbTieuDe;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Revenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_Reply;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_LastMonthDown;
        private System.Windows.Forms.Label lb_YesterdayDown;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Accessory;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
    }
}