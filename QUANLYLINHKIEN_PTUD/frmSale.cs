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
    public partial class frmSale : Form
    {
        frmMainUI_Staff fmain;

        public frmSale()
        {
            InitializeComponent();
            cbx_NhaSanXuat.SelectedIndex = 0;
            cbx_LoaiLinhKien.SelectedIndex = 0;
            cbx_NhaSanXuat.ForeColor = Color.DarkGray;
            cbx_LoaiLinhKien.ForeColor = Color.DarkGray;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public frmSale(frmMainUI_Staff fm)
        {
            InitializeComponent();
            cbx_NhaSanXuat.SelectedIndex = 0;
            cbx_LoaiLinhKien.SelectedIndex = 0;
            cbx_NhaSanXuat.ForeColor = Color.DarkGray;
            cbx_LoaiLinhKien.ForeColor = Color.DarkGray;
            this.FormBorderStyle = FormBorderStyle.None;
            fmain = fm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Đã Lưu Tất Cả Thay Đổi.\nXác Nhận Thoát Giao Diện Bán Hàng ?", "THOÁT GIAO DIỆN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void cbxNhaSanXuat_Enter(object sender, EventArgs e)
        {
            cbx_NhaSanXuat.ForeColor = Color.Black;
        }

        private void cbx_LoaiLinhKien_Enter(object sender, EventArgs e)
        {
            cbx_LoaiLinhKien.ForeColor = Color.Black;
        }
    }
}
