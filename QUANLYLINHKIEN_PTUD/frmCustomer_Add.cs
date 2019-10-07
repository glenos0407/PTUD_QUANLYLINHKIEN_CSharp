using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmCustomer_Add : Form
    {
        TabControl tab_c;
        frmMainUI_Staff frm_main;
        ErrorProvider errProvider;

        public frmCustomer_Add()
        {
            InitializeComponent();
        }

        public frmCustomer_Add(frmMainUI_Staff f, TabControl tc)
        {
            InitializeComponent();
            frm_main = f;
            tab_c = tc;
        }
        private void frmCustomer_Add_Load(object sender, EventArgs e)
        {
            errProvider = new ErrorProvider();
            errorSetting();
        }
        private void errorSetting()
        {
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.SetError(txtHoTen, "Vui lòng nhập họ tên!");
            errProvider.SetError(dtmNgaySinh, "Vui lòng nhập ngày sinh!");
            errProvider.SetError(txtCMND, "Vui lòng nhập chứng minh thư, thẻ căn cước!");
            errProvider.SetError(txtSDT, "Vui lòng nhập số điện thoại!");
            errProvider.SetError(txtEmail, "Vui lòng nhập Email!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Đã Lưu Tất Cả Thay Đổi.\nXác Nhận Thoát Giao Diện Quản Lý Linh Kiện ?", "THOÁT GIAO DIỆN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                foreach (TabPage item in tab_c.TabPages)
                {
                    if (item.Tag.Equals("KhachHang_Add"))
                    {
                        tab_c.TabPages.Remove(item);
                    }
                }
                this.Close();
            }
            else
            {
                return;
            }
        }
        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            Regex regHoTen = new Regex(@"^([A-Z][a-z]+)+");
            if (txtHoTen.Text.Trim().Equals(""))
            {
                errProvider.SetError(txtHoTen, "Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return;
            }
            if (!regHoTen.IsMatch(txtHoTen.Text.Trim()))
            {
                errProvider.SetError(txtHoTen, "Vui lòng nhập đúng họ tên!");
                txtHoTen.Focus();
                return;
            }
            errProvider.SetError(txtHoTen, "");
        }
        private void dtmNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            if (dtmNgaySinh.Value.Year >= System.DateTime.Now.Year)
            {
                errProvider.SetError(dtmNgaySinh, "Vui lòng nhập đúng ngày sinh!");
                dtmNgaySinh.Focus();
                return;
            }
            errProvider.SetError(dtmNgaySinh, System.String.Empty);
        }
        private void txtCMND_Validating(object sender, CancelEventArgs e)
        {
            Regex regCMND = new Regex(@"^(\d{12})$");
            if (txtCMND.Text.Trim().Equals(""))
            {
                errProvider.SetError(txtCMND, "Vui lòng nhập chứng minh thư, thẻ căn cước!");
                txtCMND.Focus();
                return;
            }
            if (!regCMND.IsMatch(txtCMND.Text.Trim()))
            {
                errProvider.SetError(txtCMND, "Vui lòng nhập đúng chứng minh thư, thẻ căn cước!");
                txtCMND.Focus();
                return;
            }
            errProvider.SetError(txtCMND, "");
        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            Regex regSDT = new Regex(@"^(\d{10})$");
            if (txtSDT.Text.Trim().Equals(""))
            {
                errProvider.SetError(txtSDT, "Vui lòng nhập số điện thoại!");
                txtSDT.Focus();
                return;
            }
            if (!regSDT.IsMatch(txtSDT.Text.Trim()))
            {
                errProvider.SetError(txtSDT, "Vui lòng nhập đúng số điện thoại!");
                txtSDT.Focus();
                return;
            }
            errProvider.SetError(txtSDT, "");
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regEmail = new Regex(@"^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})$");
            if (txtEmail.Text.Trim().Equals(""))
            {
                errProvider.SetError(txtEmail, "Vui lòng nhập Email!");
                txtEmail.Focus();
                return;
            }
            if (!regEmail.IsMatch(txtEmail.Text.Trim()))
            {
                errProvider.SetError(txtEmail, "Vui lòng nhập đúng Email!");
                txtEmail.Focus();
                return;
            }
            errProvider.SetError(txtEmail, "");
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.groupBox2.Controls)
            {
                if(c is TextBox)
                    c.Text = "";
            }
            errorSetting();
        }
        private bool errorCheck()
        {
            foreach (Control c in this.groupBox2.Controls)
            {
                if (!(c is Label) && !(c is Button) && !(c is DateTimePicker))
                {
                    if (errProvider.GetError(c) != "")
                    {
                        MessageBox.Show(errProvider.GetError(c), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        c.Focus();
                        return false;
                    }
                }else if(c is DateTimePicker)
                {
                    if (dtmNgaySinh.Value.Year >= System.DateTime.Now.Year)
                    {
                        MessageBox.Show(errProvider.GetError(c), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        c.Focus();
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(errorCheck())
            {
                MessageBox.Show("Ok!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//else MessageBox.Show("NOT Ok!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

