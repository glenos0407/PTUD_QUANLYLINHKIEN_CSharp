using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Business;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmAccessories : Form
    {
        frmMainUI_Staff frm_main;
        AccesoryBLL accsorybll;
        bool isEnter = false;

        public frmAccessories()
        {
            InitializeComponent();
            accsorybll = new AccesoryBLL();
            //MessageBox.Show(accsorybll.GetAllAccessories().ToString());
        }

        public frmAccessories(frmMainUI_Staff f)
        {
            InitializeComponent();
            frm_main = f;
            radioButton1.Checked = true;
        }

        private void Custom_Theme()
        {
            btnSearch.Image = imgs_Icon.Images[0];
            radioButton1.Checked = true;
        }

        private void frmAccessories_Load(object sender, EventArgs e)
        {
            Custom_Theme();

        }

        private void txtSearch_Enter_1(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.ForeColor = Color.Black;
            isEnter = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Đã Lưu Tất Cả Thay Đổi.\nXác Nhận Thoát Giao Diện Quản Lý Linh Kiện ?", "THOÁT GIAO DIỆN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmFileImport frmfi = new frmFileImport();
            frmfi.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String txt = txtSearch.Text.ToString();
            if (txt == "" && isEnter == true)
            {
                MessageBox.Show("Hãy Nhập Thông Tin Tìm kiếm");
                return;
            }
            if (isEnter == false)
            {
                MessageBox.Show("Hãy Nhập Thông Tin Tìm kiếm");
                return;
            }
            //MessageBox.Show(accsorybll.GetListAccessories(txt, radioButton3.Checked, radioButton2.Checked, radioButton1.Checked).ToString());
            MessageBox.Show("testTK");
        }


    }
}
