using Business;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmStaffManager : Form
    {
        StaffBLL staffbll;
        frmMainUI_Staff fmain;
        string openFileName;
        List<string> roleTypes;
        BindingSource bs;
        public frmStaffManager()
        {
            InitializeComponent();
            Custom_Theme();
            staffbll = new StaffBLL();
            roleTypes = new List<string>() { "Quản Lý", "Nhân viên thủ kho", "Nhân viên bán hàng" };
            cbx_Role.DataSource = roleTypes;
            dtp_BirthDate.Format = DateTimePickerFormat.Custom;
            bs = new BindingSource();
            dtp_BirthDate.CustomFormat = "dd/MM/yyyy";
            CreateDataGridView();
        }
        private void FillTextBox()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            outPutDirectory = outPutDirectory.Replace(@"\QUANLYLINHKIEN_PTUD\bin\Debug", @"\Dataaccess\Images\StaffAvatar");

            var entity = staffbll.GetStaffByStaffEmail("chautruongphat123@gmail.com");
            txt_Name.Text = entity.Name;
            txt_Email.Text = entity.Email;
            txt_Identify.Text = entity.IdentifyNumber;
            dtp_BirthDate.Value = entity.BirthDate;
            cbx_Role.SelectedIndex = entity.Role;
            txt_Password.Text = entity.Password;

            outPutDirectory += @"\";
            outPutDirectory += entity.Avatar;
            string directoryPath = new Uri(outPutDirectory).LocalPath;

            picbxAvatar.Image = new Bitmap(directoryPath);
        }
        private void CreateDataGridView()
        {
            dgv_StaffInfor.Columns.Add("STT","STT");
            dgv_StaffInfor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_StaffInfor.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_StaffInfor.DataSource = staffbll.GetAllStaffDto();
            dgv_StaffInfor.Columns["Avatar"].Visible = false;
        }

        public frmStaffManager(frmMainUI_Staff f)
        {
            InitializeComponent();
            fmain = f;
            Custom_Theme();
            staffbll = new StaffBLL();
            roleTypes = new List<string>() { "Quản Lý", "Nhân viên thủ kho", "Nhân viên bán hàng" };
            cbx_Role.DataSource = roleTypes;
            dtp_BirthDate.Format = DateTimePickerFormat.Custom;
            dtp_BirthDate.CustomFormat = "dd/MM/yyyy";
            CreateDataGridView();

        }

        private void frmStaffManager_Load(object sender, EventArgs e)
        {

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
            string[] str = { };

            string rePassword = txt_RePassword.Text.ToString();

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            outPutDirectory = outPutDirectory.Replace(@"\QUANLYLINHKIEN_PTUD\bin\Debug", @"\Dataaccess\Images\StaffAvatar");
            string directoryPath = new Uri(outPutDirectory).LocalPath;
            if (!string.IsNullOrEmpty(outPutDirectory))
            {
                File.Copy(openFileName, Path.Combine(directoryPath, Path.GetFileName(openFileName)), true);
                str = openFileName.Split(new[] { @"\" }, StringSplitOptions.RemoveEmptyEntries);
            }
            StaffCreatingDto staff = new StaffCreatingDto()
            {
                Name = txt_Name.Text.ToString(),
                Email = txt_Email.Text.ToString(),
                IdentifyNumber = txt_Identify.Text.ToString(),
                NumberPhone = txt_Identify.Text.ToString(),
                BirthDate = dtp_BirthDate.Value,
                Role = Convert.ToInt32(cbx_Role.SelectedIndex),
                Password = txt_Password.Text.ToString(),
                Avatar = str == null? null : str[str.Length - 1]
            };
            var taskCreateStaff = Task.Factory.StartNew(
                () => MessageBox.Show(staffbll.CreateStaff(staff, rePassword)));
            openWaitingForm();
            taskCreateStaff.Wait();

            //Phat is working here, don't delete
            //string[] str1 = openFileName.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            //File.Move(openFileName,"Staff." + str1[str1.Length - 1]);
            //MessageBox.Show(openFileName);

            btnLuu.Enabled = true;
        }

        public void openWaitingForm()
        {
            frmHandling frm = new frmHandling();
            frm.ShowDialog();
        }

        private void btnUpdateAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                openFileName = fileDialog.FileName;
                picbxAvatar.Image = new Bitmap(fileDialog.FileName);
            }
        }
    }
}
