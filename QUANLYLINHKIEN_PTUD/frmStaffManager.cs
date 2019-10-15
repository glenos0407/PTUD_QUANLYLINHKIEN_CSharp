using Business;
using Model;
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
        StaffBLL staffbll;
        frmMainUI_Staff fmain;

        public frmStaffManager()
        {
            InitializeComponent();
            Custom_Theme();
            staffbll = new StaffBLL();
            List<string> RoleTypes = new List<string>() { "Quản Lý", "Nhân viên thủ kho", "Nhân viên bán hàng"};
            cbx_Role.DataSource = RoleTypes;
        }

        public frmStaffManager(frmMainUI_Staff f)
        {
            InitializeComponent();
            fmain = f;
            Custom_Theme();
            staffbll = new StaffBLL();
        }

        private void frmStaffManager_Load(object sender, EventArgs e)
        {
            //btnSua.Enabled = false;
            //btnLuu.Enabled = false;
            //btnUpdateAvatar.Enabled = false;
            //Enable_TextBox(false);
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
            txt_Name.Enabled = s;
            txt_Identify.Enabled = s;
            txt_Email.Enabled = s;
            txt_Password.Enabled = s;
            txt_RePassword.Enabled = s;
            txt_Phone.Enabled = s;
            dtp_BirthDate.Enabled = s;
        }
        private void Clear_TextBox()
        {
            txt_Name.Clear();
            txt_Identify.Clear();
            txt_Email.Clear();
            txt_Password.Clear();
            txt_RePassword.Clear();
            txt_Phone.Clear();
            dtp_BirthDate.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Text = "Lưu Thay Đổi";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Enable_TextBox(true);
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

            string rePassword = txt_RePassword.Text.ToString();

            StaffCreateDto staff = new StaffCreateDto()
            {
                Name = txt_Name.Text.ToString(),
                Email = txt_Email.Text.ToString(),
                IdentifyNumber = txt_Identify.Text.ToString(),
                NumberPhone = txt_Identify.Text.ToString(),
                BirthDate = dtp_BirthDate.Value,
                Role = Convert.ToInt32(cbx_Role.SelectedIndex) + 1,
                Password = txt_Password.Text.ToString()
            };
            MessageBox.Show(staffbll.CreateStaff(staff, rePassword));
        }
    }
}
