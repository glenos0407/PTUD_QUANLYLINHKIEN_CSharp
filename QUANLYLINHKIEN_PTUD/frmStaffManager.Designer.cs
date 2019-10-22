namespace QUANLYLINHKIEN_PTUD
{
    partial class frmStaffManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffManager));
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Identify = new System.Windows.Forms.TextBox();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnUpdateAvatar = new System.Windows.Forms.Button();
            this.dgv_StaffInfor = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.picbxAvatar = new System.Windows.Forms.PictureBox();
            this.lb_ListStaff = new System.Windows.Forms.Label();
            this.lb_Role = new System.Windows.Forms.Label();
            this.cbx_Role = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_RePassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StaffInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(409, 48);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(280, 33);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.Text = "VD: Ngọc Thụ Lâm Phong";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(409, 122);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(280, 33);
            this.txt_Phone.TabIndex = 3;
            this.txt_Phone.Text = "VD: 0123456789";
            // 
            // txt_Identify
            // 
            this.txt_Identify.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Identify.Location = new System.Drawing.Point(409, 161);
            this.txt_Identify.Name = "txt_Identify";
            this.txt_Identify.Size = new System.Drawing.Size(280, 33);
            this.txt_Identify.TabIndex = 4;
            this.txt_Identify.Text = "VD: 023601265458";
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.CalendarForeColor = System.Drawing.Color.Black;
            this.dtp_BirthDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtp_BirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_BirthDate.Location = new System.Drawing.Point(409, 88);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.Size = new System.Drawing.Size(280, 29);
            this.dtp_BirthDate.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(333, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(274, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "CMND/Căn Cước";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(305, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(475, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Quản Lý Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 29);
            this.panel1.TabIndex = 40;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnExit.Location = new System.Drawing.Point(1124, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Maroon;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(609, 217);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(129, 53);
            this.btnLuu.TabIndex = 49;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNhapLai.FlatAppearance.BorderSize = 0;
            this.btnNhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapLai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.ForeColor = System.Drawing.Color.White;
            this.btnNhapLai.Location = new System.Drawing.Point(756, 217);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(129, 53);
            this.btnNhapLai.TabIndex = 50;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnUpdateAvatar
            // 
            this.btnUpdateAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateAvatar.FlatAppearance.BorderSize = 0;
            this.btnUpdateAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAvatar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAvatar.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAvatar.Location = new System.Drawing.Point(31, 238);
            this.btnUpdateAvatar.Name = "btnUpdateAvatar";
            this.btnUpdateAvatar.Size = new System.Drawing.Size(180, 32);
            this.btnUpdateAvatar.TabIndex = 51;
            this.btnUpdateAvatar.Text = "Cập Nhật Ảnh";
            this.btnUpdateAvatar.UseVisualStyleBackColor = false;
            this.btnUpdateAvatar.Click += new System.EventHandler(this.btnUpdateAvatar_Click);
            // 
            // dgv_StaffInfor
            // 
            this.dgv_StaffInfor.AllowUserToResizeColumns = false;
            this.dgv_StaffInfor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_StaffInfor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_StaffInfor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StaffInfor.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_StaffInfor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_StaffInfor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_StaffInfor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_StaffInfor.ColumnHeadersHeight = 30;
            this.dgv_StaffInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_StaffInfor.DoubleBuffered = true;
            this.dgv_StaffInfor.EnableHeadersVisualStyles = false;
            this.dgv_StaffInfor.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_StaffInfor.HeaderForeColor = System.Drawing.SystemColors.Window;
            this.dgv_StaffInfor.Location = new System.Drawing.Point(0, 334);
            this.dgv_StaffInfor.Name = "dgv_StaffInfor";
            this.dgv_StaffInfor.ReadOnly = true;
            this.dgv_StaffInfor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_StaffInfor.RowHeadersVisible = false;
            this.dgv_StaffInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_StaffInfor.Size = new System.Drawing.Size(1169, 189);
            this.dgv_StaffInfor.TabIndex = 54;
            this.dgv_StaffInfor.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_StaffInfor_RowPostPaint);
            this.dgv_StaffInfor.SelectionChanged += new System.EventHandler(this.dgv_StaffInfor_SelectionChanged);
            // 
            // picbxAvatar
            // 
            this.picbxAvatar.Location = new System.Drawing.Point(31, 51);
            this.picbxAvatar.Name = "picbxAvatar";
            this.picbxAvatar.Size = new System.Drawing.Size(180, 180);
            this.picbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxAvatar.TabIndex = 0;
            this.picbxAvatar.TabStop = false;
            // 
            // lb_ListStaff
            // 
            this.lb_ListStaff.BackColor = System.Drawing.Color.Silver;
            this.lb_ListStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_ListStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ListStaff.ForeColor = System.Drawing.Color.Maroon;
            this.lb_ListStaff.Location = new System.Drawing.Point(0, 300);
            this.lb_ListStaff.Name = "lb_ListStaff";
            this.lb_ListStaff.Padding = new System.Windows.Forms.Padding(440, 6, 0, 0);
            this.lb_ListStaff.Size = new System.Drawing.Size(1169, 34);
            this.lb_ListStaff.TabIndex = 56;
            this.lb_ListStaff.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // lb_Role
            // 
            this.lb_Role.AutoSize = true;
            this.lb_Role.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Role.ForeColor = System.Drawing.Color.White;
            this.lb_Role.Location = new System.Drawing.Point(747, 167);
            this.lb_Role.Name = "lb_Role";
            this.lb_Role.Size = new System.Drawing.Size(126, 25);
            this.lb_Role.TabIndex = 64;
            this.lb_Role.Text = "Vị trí làm việc";
            // 
            // cbx_Role
            // 
            this.cbx_Role.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Role.FormattingEnabled = true;
            this.cbx_Role.Location = new System.Drawing.Point(879, 164);
            this.cbx_Role.Name = "cbx_Role";
            this.cbx_Role.Size = new System.Drawing.Size(280, 33);
            this.cbx_Role.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(700, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 62;
            this.label7.Text = "Nhập Lại Mật Khẩu";
            // 
            // txt_RePassword
            // 
            this.txt_RePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RePassword.Location = new System.Drawing.Point(879, 124);
            this.txt_RePassword.Name = "txt_RePassword";
            this.txt_RePassword.Size = new System.Drawing.Size(280, 33);
            this.txt_RePassword.TabIndex = 61;
            this.txt_RePassword.Text = "password";
            this.txt_RePassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(780, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Mật Khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(815, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "Email";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(879, 85);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(280, 33);
            this.txt_Password.TabIndex = 58;
            this.txt_Password.Text = "password";
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(879, 45);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(280, 33);
            this.txt_Email.TabIndex = 57;
            this.txt_Email.Text = "VD: ptud.nhom17@gmail.com";
            // 
            // frmStaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(69)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(1169, 523);
            this.Controls.Add(this.lb_Role);
            this.Controls.Add(this.cbx_Role);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_RePassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lb_ListStaff);
            this.Controls.Add(this.dgv_StaffInfor);
            this.Controls.Add(this.btnUpdateAvatar);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picbxAvatar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_BirthDate);
            this.Controls.Add(this.txt_Identify);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_Name);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStaffManager";
            this.Text = "frmStaffManager";
            this.Load += new System.EventHandler(this.frmStaffManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StaffInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picbxAvatar;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Identify;
        private System.Windows.Forms.DateTimePicker dtp_BirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnUpdateAvatar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_StaffInfor;
        private System.Windows.Forms.Label lb_ListStaff;
        private System.Windows.Forms.Label lb_Role;
        private System.Windows.Forms.ComboBox cbx_Role;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_RePassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Email;
    }
}