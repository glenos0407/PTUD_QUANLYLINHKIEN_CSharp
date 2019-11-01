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
        BindingSource bindingSource;
        #region Cunstructor
        public frmStaffManager()
        {
            InitializeComponent();
            Custom_Theme();
            staffbll = new StaffBLL();
            roleTypes = new List<string>() { "Quản Lý", "Nhân viên thủ kho", "Nhân viên bán hàng" };
            cbx_Role.DataSource = roleTypes;
            dtp_BirthDate.Format = DateTimePickerFormat.Custom;
            bindingSource = new BindingSource();
            dtp_BirthDate.CustomFormat = "dd/MM/yyyy";
            bindingSource.DataSource = staffbll.GetAllStaffDto();
            CreateDataGridView();
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
            bindingSource = new BindingSource();
            bindingSource.DataSource = staffbll.GetAllStaffDto();
            CreateDataGridView();
        }

        #endregion

        private void FillTextBox()
        {
            txt_Name.DataBindings.Clear();
            txt_Email.DataBindings.Clear();
            txt_Identify.DataBindings.Clear();
            txt_Password.DataBindings.Clear();
            txt_Phone.DataBindings.Clear();
            dtp_BirthDate.DataBindings.Clear();

            txt_Name.DataBindings.Add("Text", bindingSource, "Name");
            txt_Email.DataBindings.Add("Text", bindingSource, "Email");
            txt_Identify.DataBindings.Add("Text", bindingSource, "IdentifyNumber");
            txt_Password.DataBindings.Add("Text", bindingSource, "Password");
            txt_Phone.DataBindings.Add("Text", bindingSource, "NumberPhone");
            dtp_BirthDate.DataBindings.Add("Value", bindingSource, "BirthDate");
        }
        private void CreateDataGridView()
        {
            bindingSource.DataSource = staffbll.GetAllStaffDto();

            dgv_StaffInfor.Columns.Add("STT", "STT");
            dgv_StaffInfor.DataSource = bindingSource;
            dgv_StaffInfor.Columns["Avatar"].Visible = false;
            dgv_StaffInfor.Columns["Role"].Visible = false;
            dgv_StaffInfor.Columns["STT"].Width = 28;
            dgv_StaffInfor.Columns["Name"].Width = 150;
            dgv_StaffInfor.Columns["IdentifyNumber"].Width = 120;
            dgv_StaffInfor.Columns["Email"].Width = 200;

            dgv_StaffInfor.Columns["Name"].HeaderText = "Họ tên";
            dgv_StaffInfor.Columns["BirthDate"].HeaderText = "Ngày sinh";
            dgv_StaffInfor.Columns["NumberPhone"].HeaderText = "Số điện thoại";
            dgv_StaffInfor.Columns["IdentifyNumber"].HeaderText = "Số CMND";
            dgv_StaffInfor.Columns["Password"].HeaderText = "Mật khẩu";

            //for (int i = 0; i < dgv_StaffInfor.Rows.Count - 1; i++)
            //{
            //    dgv_StaffInfor.Rows[i].Cells[0].Value = (i + 1).ToString();
            //}
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
            if (!string.IsNullOrEmpty(openFileName))
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
                Avatar = (openFileName == null)? null : str[str.Length - 1]
            };
            Result result = null;
            var taskCreateStaff = Task.Factory.StartNew(() => result = staffbll.CreateOrUpdateStaff(staff, rePassword));
            var taskOpenWaitingForm = Task.Factory.StartNew(() =>  openWaitingForm());
            taskOpenWaitingForm.Wait();
            taskCreateStaff.Wait();
            //bindingSource.Add(staff);

            if(!result.IsSuccess)
                CreateDataGridView();
            //if(result.IsSuccess)
            //    MessageBox.Show(result.ResultMessage, "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            //else
            //    MessageBox.Show(result.ResultMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            MessageBox.Show(result.ResultMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


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

        private void dgv_StaffInfor_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv_StaffInfor.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgv_StaffInfor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_StaffInfor.SelectedRows.Count > 0)
            {
                if (Convert.ToInt32(dgv_StaffInfor.SelectedRows[0].Cells["STT"].Value) != dgv_StaffInfor.Rows.Count)
                {
                    FillTextBox();

                    var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    outPutDirectory = outPutDirectory.Replace(@"\QUANLYLINHKIEN_PTUD\bin\Debug", @"\Dataaccess\Images\StaffAvatar");
                    cbx_Role.SelectedIndex = Convert.ToInt16(dgv_StaffInfor.SelectedRows[0].Cells["Role"].Value);

                    outPutDirectory += @"\";
                    outPutDirectory += dgv_StaffInfor.SelectedRows[0].Cells["Avatar"].Value;
                    string directoryPath = new Uri(outPutDirectory).LocalPath;

                    picbxAvatar.Image = new Bitmap(directoryPath);
                }
            }
        }
    }
}
