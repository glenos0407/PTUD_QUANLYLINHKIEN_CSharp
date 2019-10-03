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
    public partial class frmMainUI_Staff : Form
    {
        bool isClickShow = false;
        TabControl tc;

        public frmMainUI_Staff()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void Custom_Theme()
        {
            this.pnlTop.BackColor = Color.FromArgb(26, 58, 102);
            this.pnl_Menu.BackColor = Color.LightGray;
            this.btnShowMenu.BackColor = Color.FromArgb(26, 58, 102);
            this.btnShowMenu.Image = imgs_BtnICon.Images[6];
            

            this.btnAccount.Image = imgs_BtnICon.Images[0];
            this.btnPOS.Image = imgs_BtnICon.Images[2];
            this.btnBackUp.Image = imgs_BtnICon.Images[3];
            this.btnAccessories.Image = imgs_BtnICon.Images[4];
            this.btnReport.Image = imgs_BtnICon.Images[1];
            this.btnCustomer.Image = imgs_BtnICon.Images[5];
        }

        private void frmMainUI_Staff_Load(object sender, EventArgs e)
        {
            Custom_Theme();

            tc = new TabControl();
            tc.Dock = DockStyle.Fill;
            tc.Font = new Font("Segoe UI Semibold", 12);
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            if(isClickShow == false)
            {
                pnl_Menu.Visible = false;
                isClickShow = true;
            }
            else
            {
                pnl_Menu.Visible = true;
                isClickShow = false;
            }
        }

        private void btnAccount_MouseClick(object sender, MouseEventArgs e)
        {
            cmstrp_Account.Show(btnAccount, new Point(e.X, e.Y));
        }

        private void open_frmLinhKien()
        {
            this.pnlRight.Controls.Clear();

            TabPage tp = new TabPage();
            tp.Text = "Quản Lý Linh Kiện";
            tp.Tag = "LinhKien";
            tc.TabPages.Add(tp);

            frmAccessories fa = new frmAccessories(this,tc);
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            fa.FormBorderStyle = FormBorderStyle.None;
            fa.ShowInTaskbar = false;
            fa.Show();

            tp.Controls.Add(fa);
            this.pnlRight.Controls.Add(tc);
        }


        private void btnAccessories_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if(item.Name.Equals("frmAccessories"))
                {
                    return;
                }
            }
            open_frmLinhKien();
        }
    }
}
