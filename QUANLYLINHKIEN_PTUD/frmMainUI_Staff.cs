using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Model;

namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmMainUI_Staff : Form
    {
        bool isClickShow = false;
        static int staffId;
        public frmMainUI_Staff(int _staffId)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            staffId = _staffId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Kiểm Tra Có Form Sub nào đang chạy không ?
            if (this.pnlRight.Controls.Count == 1)
            {
                MessageBox.Show("Hãy Đóng Giao Diện Hiện Tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn Có Muốn Thoát Phần Mềm ?", "THOÁT PHẦN MỀM", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

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
            Staff s = new Staff();
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
            this.btnBill.Image = imgs_BtnICon.Images[8];
        }

        private void frmMainUI_Staff_Load(object sender, EventArgs e)
        {
            Custom_Theme();
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            if (isClickShow == false)
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

            frmAccessories fa = new frmAccessories(this);
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            fa.FormBorderStyle = FormBorderStyle.None;
            fa.ShowInTaskbar = false;
            fa.Show();

            this.pnlRight.Controls.Add(fa);
        }


        private void btnAccessories_Click(object sender, EventArgs e)
        {

            //Kiểm Tra Có Form Sub nào đang chạy không ?
            if (this.pnlRight.Controls.Count == 1)
            {
                MessageBox.Show("Hãy Đóng Giao Diện Hiện Tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            open_frmLinhKien();
        }

        private void ChangePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kiểm Tra Có Form Sub nào đang chạy không ?
            if (this.pnlRight.Controls.Count == 1)
            {
                MessageBox.Show("Hãy Đóng Giao Diện Hiện Tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmChangePassword frm_dmk = new frmChangePassword();
            frm_dmk.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

            //Kiểm Tra Có Form Sub nào đang chạy không ?
            if (this.pnlRight.Controls.Count == 1)
            {
                MessageBox.Show("Hãy Đóng Giao Diện Hiện Tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            open_frmCustomer();
        }
        private void open_frmCustomer()
        {
            this.pnlRight.Controls.Clear();

            frmCustomer fc = new frmCustomer(this);
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            fc.FormBorderStyle = FormBorderStyle.None;
            fc.ShowInTaskbar = false;
            fc.Show();

            this.pnlRight.Controls.Add(fc);
        }

      

        private void QuanLyNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kiểm Tra Có Form Sub nào đang chạy không ?
            if (this.pnlRight.Controls.Count == 1)
            {
                MessageBox.Show("Hãy Đóng Giao Diện Hiện Tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmStaffManager fsm = new frmStaffManager(this);
            fsm.TopLevel = false;
            fsm.Dock = DockStyle.Fill;
            fsm.FormBorderStyle = FormBorderStyle.None;
            fsm.ShowInTaskbar = false;
            fsm.Show();

            this.pnlRight.Controls.Add(fsm);
        }

        private void back_login()
        {
            Application.Run(new frmLogin());
        }
        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kiểm Tra Có Form Sub nào đang chạy không ?
            if (this.pnlRight.Controls.Count == 1)
            {
                MessageBox.Show("Hãy Đóng Giao Diện Hiện Tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn Có Muốn Đăng Xuất Không ?", "QUAY VỀ ĐĂNG NHẬP", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Thread th = new Thread(back_login);
#pragma warning disable CS0618 // Type or member is obsolete
                th.ApartmentState = ApartmentState.STA;
#pragma warning restore CS0618 // Type or member is obsolete
                th.Start();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            //Kiểm Tra Có Form Sub nào đang chạy không ?
            if (this.pnlRight.Controls.Count == 1)
            {
                MessageBox.Show("Hãy Đóng Giao Diện Hiện Tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            open_frmBillManager();
        }
        private void open_frmBillManager()
        {
            this.pnlRight.Controls.Clear();

            frmBillManager fa = new frmBillManager(this);
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            fa.FormBorderStyle = FormBorderStyle.None;
            fa.ShowInTaskbar = false;
            fa.Show();

            this.pnlRight.Controls.Add(fa);
        }

        private void open_frmSale()
        {
            this.pnlRight.Controls.Clear();

            frmSale fa = new frmSale(this, staffId);
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            fa.FormBorderStyle = FormBorderStyle.None;
            fa.ShowInTaskbar = false;
            fa.Show();

            this.pnlRight.Controls.Add(fa);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            //Kiểm Tra Có Form Sub nào đang chạy không ?
            if (this.pnlRight.Controls.Count == 1)
            {
                MessageBox.Show("Hãy Đóng Giao Diện Hiện Tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            open_frmSale();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            //Kiểm Tra Có Form Sub nào đang chạy không ?
            if (this.pnlRight.Controls.Count == 1)
            {
                MessageBox.Show("Hãy Đóng Giao Diện Hiện Tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            //Kiểm Tra Có Form Sub nào đang chạy không ?
            if (this.pnlRight.Controls.Count == 1)
            {
                MessageBox.Show("Hãy Đóng Giao Diện Hiện Tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnReport_MouseClick(object sender, MouseEventArgs e)
        {
            cmstrp_Report.Show(btnReport, new Point(e.X, e.Y));
        }

        /*
         *Kiểu Báo Cáo
         *0: là Báo Cáo Doanh Thu
         * 1: là Báo Cáo Số Lượng Tồn
        */
        private void open_frmReport(int kieuBaoCao)
        {
            this.pnlRight.Controls.Clear();

            frmReport fr = new frmReport(this,kieuBaoCao);
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.ShowInTaskbar = false;
            fr.Show();

            this.pnlRight.Controls.Add(fr);
        }

        private void baoCaoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kiểm Tra Có Form Sub nào đang chạy không ?
            if (this.pnlRight.Controls.Count == 1)
            {
                MessageBox.Show("Hãy Đóng Giao Diện Hiện Tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            open_frmReport(0);
        }

        private void baoCaoSoLuongTonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kiểm Tra Có Form Sub nào đang chạy không ?
            if (this.pnlRight.Controls.Count == 1)
            {
                MessageBox.Show("Hãy Đóng Giao Diện Hiện Tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            open_frmReport(1);
        }

       
    }
}
