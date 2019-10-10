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
    public partial class frmStaffManager : Form
    {
        frmMainUI_Staff fmain;

        public frmStaffManager()
        {
            InitializeComponent();
            Custom_Theme();
        }

        public frmStaffManager(frmMainUI_Staff f)
        {
            InitializeComponent();
            fmain = f;
            Custom_Theme();
        }

        private void frmStaffManager_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnUpdateAvatar.Enabled = false;
            Enable_TextBox(false);
        }

        private void Custom_Theme()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.picbxAvatar.Image = Resource_Image.icon_user;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Đã Lưu Tất Cả Thay Đổi.\nXác Nhận Thoát Giao Diện Quản Lý Nhân Viên ?", "THOÁT GIAO DIỆN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Enable_TextBox(bool s)
        {
            txtHoTen.Enabled = s;
            txtCMND.Enabled = s;
            txtEmail.Enabled = s;
            txtMatKhau.Enabled = s;
            txtNhapLaiMatKhau.Enabled = s;
            txtSDTNV.Enabled = s;
            dtmNgaySinh.Enabled = s;
        }
        private void Clear_TextBox()
        {
            txtHoTen.Clear();
            txtCMND.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtNhapLaiMatKhau.Clear();
            txtSDTNV.Clear();
            dtmNgaySinh.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Text = "Lưu Thay Đổi";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Enable_TextBox(true);
            btnLuu.Text = "Lưu Mới";
            btnUpdateAvatar.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            Clear_TextBox();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnLuu.Text = "Lưu";
            btnLuu.Enabled = false;
        }
    }
}
