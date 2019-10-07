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
        TabControl tab_c;
        TabControl main;
        frmMainUI_Staff frm_main;

        public frmCustomer()
        {
            InitializeComponent();
        }

        public frmCustomer(frmMainUI_Staff f, TabControl tc)
        {
            InitializeComponent();
            frm_main = f;
            tab_c = tc;
            main = tc;
        }

        private void Custom_Theme()
        {
            btnSearch.Image = imgs_Icon.Images[0];
            btnThemKH.Image = imgs_ButtonIcon.Images[0];
            btnSuaKH.Image = imgs_ButtonIcon.Images[4];
            btnXoaKH.Image = imgs_ButtonIcon.Images[2];
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Custom_Theme();
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Đã Lưu Tất Cả Thay Đổi.\nXác Nhận Thoát Giao Diện Quản Lý Linh Kiện ?", "THOÁT GIAO DIỆN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                foreach (TabPage item in tab_c.TabPages)
                {
                    if (item.Tag.Equals("KhachHang"))
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

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.ForeColor = Color.Black;
        }
        private void open_frmCustomer_Add()
        {
            Panel pnlRight = frm_main.getPanel();
            pnlRight.Controls.Clear();

            TabPage tp = new TabPage();
            tp.Text = "Thêm khách hàng";
            tp.Tag = "KhachHang_Add";
            main.TabPages.Add(tp);

            frmCustomer_Add fa = new frmCustomer_Add(frm_main, main);
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            fa.FormBorderStyle = FormBorderStyle.None;
            fa.ShowInTaskbar = false;
            fa.Show();

            tp.Controls.Add(fa);
            pnlRight.Controls.Add(main);
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name.Equals("frmCustomer_Add"))
                {
                    return;
                }
            }
            open_frmCustomer_Add();
        }
    }
}
