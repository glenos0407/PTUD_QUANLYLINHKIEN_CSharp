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
    public partial class frmReport : Form
    {
        frmMainUI_Staff fmain;
        int kieuBaoCao;
        public frmReport()
        {
            InitializeComponent();
        }

        public frmReport(frmMainUI_Staff f, int kbc)
        {
            InitializeComponent();
            fmain = f;
            KieuBaoCao = kbc;
        }

        public int KieuBaoCao
        {    get{ return kieuBaoCao; }
             set { kieuBaoCao = value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Đã Lưu Tất Cả Thay Đổi.\nXác Nhận Thoát Giao Diện Báo Cáo ?", "THOÁT GIAO DIỆN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            if(KieuBaoCao == 0)
            {
                lbTieuDe.Text = "Báo Cáo Thống Kê Doanh Thu";
            }
            if (KieuBaoCao == 1)
            {
                lbTieuDe.Text = "Báo Cáo Thống Kê Số Lượng Tồn";
            }
        }
    }
}
