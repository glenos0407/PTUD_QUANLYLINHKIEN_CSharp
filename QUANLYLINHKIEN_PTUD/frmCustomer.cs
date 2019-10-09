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
    public partial class frmCustomer : Form
    {
        frmMainUI_Staff frm_main;

        public frmCustomer()
        {
            InitializeComponent();
        }

        public frmCustomer(frmMainUI_Staff f)
        {
            InitializeComponent();
            frm_main = f;
        }

        private void Custom_Theme()
        {
            btnSearch.Image = imgs_Icon.Images[0];
            btnThemKH.Image = imgs_ButtonIcon.Images[0];
            btnSuaKH.Image = imgs_ButtonIcon.Images[1];
            btnLuu.Image = imgs_ButtonIcon.Images[2];
            btnReset.Image = imgs_ButtonIcon.Images[3];
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Custom_Theme();
            rbtnSoDienThoai.Checked = true;
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

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.ForeColor = Color.Black;
        }
        
        private void btnThemKH_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
