using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Business;
using Model;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmCustomer : Form
    {
        frmMainUI_Staff frm_main;
        CustomerBLL customerbll;
        bool isEnter = false;

        public frmCustomer()
        {
            InitializeComponent();
            customerbll = new CustomerBLL();
            //MessageBox.Show(customerbll.GetAllCustomer().ToString());
        }

        public frmCustomer(frmMainUI_Staff f)
        {
            InitializeComponent();
            frm_main = f;
            customerbll = new CustomerBLL();

        }

        private void Custom_Theme()
        {
            btnSearch.Image = imgs_Icon.Images[0];
            btnThemKH.Image = imgs_ButtonIcon.Images[0];
            btnSuaKH.Image = imgs_ButtonIcon.Images[1];
            btnLuu.Image = imgs_ButtonIcon.Images[2];
            btnReset.Image = imgs_ButtonIcon.Images[3];

            //Chuyển Trạng Thái TextBox Thành Readonly
            Enable_TextBox(false);
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Custom_Theme();
            rbtnSoDienThoai.Checked = true;
            btnLuu.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Đã Lưu Tất Cả Thay Đổi.\nXác Nhận Thoát Giao Diện Quản Lý Khách Hàng ?", "THOÁT GIAO DIỆN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.ForeColor = Color.Black;
            isEnter = true;
        }

        private void Enable_TextBox(bool s)
        {
            txtHoKH.Enabled = s;
            txtTenKH.Enabled = s;
            txtCMND.Enabled = s;
            txtEmail.Enabled = s;
            txtSDT.Enabled = s;
            dtmNgaySinh.Enabled = s;
        }

        private void Clear_TextBox()
        {
            txtHoKH.Clear();
            txtTenKH.Clear();
            txtCMND.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            dtmNgaySinh.Value = DateTime.Now;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (btnThemKH.Text == "Hủy")
            {
                btnThemKH.Text = "Thêm";
                btnLuu.Enabled = false;
                btnSuaKH.Enabled = true;
                Enable_TextBox(false);
                btnLuu.Text = "Lưu";
            }
            else
            {
                Enable_TextBox(true);
                Clear_TextBox();
                txtHoKH.Focus();
                btnLuu.Text = "Lưu Mới";
                btnSuaKH.Enabled = false;
                btnLuu.Enabled = true;
                btnThemKH.Text = "Hủy";
            }

        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (btnSuaKH.Text == "Hủy")
            {
                btnSuaKH.Text = "Sửa";
                btnLuu.Text = "Lưu";
                btnThemKH.Enabled = true;
                btnLuu.Enabled = false;
                Enable_TextBox(false);

            }
            else
            {
                btnSuaKH.Text = "Hủy";
                txtHoKH.Focus();
                btnThemKH.Enabled = false;
                btnLuu.Text = "Lưu Đổi";
                btnLuu.Enabled = true;
                Enable_TextBox(true);
            }


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text == "Lưu Mới")
            {
                btnThemKH.Text = "Thêm";
                btnLuu.Text = "Lưu";
                btnLuu.Enabled = false;
                btnSuaKH.Enabled = true;
                CustomerCreateDto cus = new CustomerCreateDto()
                {
                    Name = txtHoKH.Text.ToString() + " " + txtTenKH.Text.ToString(),
                    NumberPhone = txtSDT.Text.ToString(),
                    Email = txtEmail.Text.ToString(),
                    IdentifyNumber = txtCMND.Text.ToString(),
                    BirthDate = dtmNgaySinh.Value
                };
                MessageBox.Show("Test123456");
                //MessageBox.Show(customerbll.AddCustomer(cus));
            }
            else
            {
                btnSuaKH.Text = "Sửa";
                btnLuu.Text = "Lưu";
                btnThemKH.Enabled = true;
                btnLuu.Enabled = false;
                MessageBox.Show("TestSua123456");

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear_TextBox();
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            String txt = txtSearch.Text.ToString();
            if (txt == "" && isEnter == true)
            {
                MessageBox.Show("Hãy nhập thông tin");
                return;
            }
            if (isEnter == false)
            {
                MessageBox.Show("Hãy nhập thông tin");
                return;
            }
            if (rbtnKhachHang.Checked == true)
            {
                MessageBox.Show(customerbll.GetListCustomer(txt).ToString());
            }
            else if (rbtnSoDienThoai.Checked == true)
            {
                if (customerbll.GetCustomerFromNumberPhone(txt) == null)

                    MessageBox.Show("AHIJ");

            }
        }
        private void cbx_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_SapXep.SelectedItem == "Tên từ A-Z")
            {

            }
            if (cbx_SapXep.SelectedItem == "Tên từ Z-A")
            {

            }
        }
    }
}
