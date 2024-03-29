﻿using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmLogin : Form
    {
        StaffBLL staffbll;
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            staffbll = new StaffBLL();
        }

        private void Custom_Theme()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.picbx_Logo.Image = Resource_Image.Logo_PTUD;
            this.picbx_Logo.SizeMode = PictureBoxSizeMode.StretchImage;

            //Load Background Title Bar
            this.panel1.BackColor = Color.FromArgb(26, 58, 102);

            //Load Hình
            this.pic_User.Image = Resource_Image.icon_user;
            this.pic_User.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Password.Image = Resource_Image.icon_lock;
            this.pic_Password.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn Có Muốn Thoát Chương Trình", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Custom_Theme();
            txt_Password.UseSystemPasswordChar = true;
            txt_Password.Text = "123qwe";
            txt_User.Text = "chautruongphat123@gmail.com";
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txt_User.Clear();
            txt_User.ForeColor = Color.Black;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
            txt_Password.Clear();
            txt_Password.ForeColor = Color.Black;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = txt_User.Text.ToString();
            string password = txt_Password.Text.ToString();
            int staffId = staffbll.SignIn(account, password);
            if (staffId > 0)
            {
                frmMainUI_Staff frm = new frmMainUI_Staff(staffId);
                frm.ShowDialog();
                this.Close();
            }
        }

        private void pnl_Right_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
