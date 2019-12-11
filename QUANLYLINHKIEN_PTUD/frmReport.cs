using Business;
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
        private OrderBLL orderBLL;
        private BindingSource bindingSource;
        private OrderDetailBLL orderDetailBLL;
        private AccesoryBLL accesoryBLL;

        public int ReportType { get; set; }
        frmMainUI_Staff fmain;
        int kieuBaoCao;
        public frmReport()
        {
            InitializeComponent();
            orderBLL = new OrderBLL();
            bindingSource = new BindingSource();
            orderDetailBLL = new OrderDetailBLL();
            accesoryBLL = new AccesoryBLL();
        }

        public frmReport(frmMainUI_Staff f, int kbc)
        {
            InitializeComponent();
            fmain = f;
            kieuBaoCao = kbc;
            orderBLL = new OrderBLL();
            bindingSource = new BindingSource();
            orderDetailBLL = new OrderDetailBLL();
            accesoryBLL = new AccesoryBLL();
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
            if(ReportType == 0)
            {
                lbTieuDe.Text = "Báo Cáo Thống Kê Doanh Thu";
            }
            if (ReportType == 1)
            {
                lbTieuDe.Text = "Báo Cáo Thống Kê Số Lượng Tồn";
            }
            btnBaoCaoNam.BackColor = Color.Green;
            btnBaoCaoThang.BackColor = Color.Firebrick;
            btnBaoCaoNgay.BackColor = Color.Firebrick;

            var list = orderBLL.GetRevenueForMonthAndYear(2019);
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "{0:###,###,###,###}";
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chartRevenue.ChartAreas[0].Position.Width = 95;
            chartRevenue.ChartAreas[0].Position.Height = 100;

            var series = chartRevenue.Series["Doanh thu"];
            series.Points.Clear();
            series.Enabled = true;

            series.Points.AddXY("Tháng 1", list.Count > 0 ? list[0].Revenue : 0);
            series.Points.AddXY("Tháng 2", list.Count > 1 ? list[1].Revenue : 0);
            series.Points.AddXY("Tháng 3", list.Count > 2 ? list[2].Revenue : 0);
            series.Points.AddXY("Tháng 4", list.Count > 3 ? list[3].Revenue : 0);
            series.Points.AddXY("Tháng 5", list.Count > 4 ? list[4].Revenue : 0);
            series.Points.AddXY("Tháng 6", list.Count > 5 ? list[5].Revenue : 0);
            series.Points.AddXY("Tháng 7", list.Count > 6 ? list[6].Revenue : 0);
            series.Points.AddXY("Tháng 8", list.Count > 7 ? list[7].Revenue : 0);
            series.Points.AddXY("Tháng 9", list.Count > 8 ? list[8].Revenue : 0);
            series.Points.AddXY("Tháng 10", list.Count > 9 ? list[9].Revenue : 0);
            series.Points.AddXY("Tháng 11", list.Count > 10 ? list[10].Revenue : 0);
            series.Points.AddXY("Tháng 12", list.Count > 11 ? list[11].Revenue : 0);

            bindingSource.DataSource = orderDetailBLL.GetListOrderDetailForStaticByDay(0, 0, 2019);
            dgv_Accessory.DataSource = bindingSource;

            dgv_Accessory.Columns["Name"].HeaderText = "Tên Linh Kiện";
            dgv_Accessory.Columns["SoldOut"].HeaderText = "Bán ra";
            dgv_Accessory.Columns["Inventory"].HeaderText = "Còn lại";
            dgv_Accessory.Columns["Guarantee"].HeaderText = "Đang bảo hành";

            dgv_Accessory.Columns["STT"].Width = 41;
            dgv_Accessory.Columns["Name"].Width = 211;
            dgv_Accessory.Columns["SoldOut"].Width = 90;
            dgv_Accessory.Columns["Inventory"].Width = 90;
            dgv_Accessory.Columns["Guarantee"].Width = 92;

            lb_Revenue.Text = orderBLL.GetRevenueForDay() == 0 ? "0" : string.Format("{0:###,###,###,###}", orderBLL.GetRevenueForDay());
            lb_Reply.Text = accesoryBLL.GetGuarantee().ToString();
            lb_YesterdayDown.Text = orderBLL.CompareRevenueForYesterday();
            lb_LastMonthDown.Text = orderBLL.CompareRevenueForLastMonth();
        }

        private void btnLuuBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnBaoCaoNgay_Click(object sender, EventArgs e)
        {
            btnBaoCaoNgay.BackColor = Color.Green;
            btnBaoCaoNam.BackColor = Color.Firebrick;
            btnBaoCaoThang.BackColor = Color.Firebrick;

            var series = chartRevenue.Series["Doanh thu"];
            series.Points.Clear();

            bindingSource.DataSource = orderDetailBLL.GetListOrderDetailForStaticByDay(20, 3, 2019);
        }

        private void btnBaoCaoThang_Click(object sender, EventArgs e)
        {
            btnBaoCaoThang.BackColor = Color.Green;
            btnBaoCaoNam.BackColor = Color.Firebrick;
            btnBaoCaoNgay.BackColor = Color.Firebrick;

            //chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "{0:###,###,###,###}";
            //chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            //chartRevenue.ChartAreas[0].AxisX.Minimum = 0;
            //chartRevenue.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            var series = chartRevenue.Series["Doanh thu"];
            series.Points.Clear();

            series.Points.AddXY("1 - 5", orderBLL.GetRevenueForMonth(2019,1,1,5));
            series.Points.AddXY("6 - 10", orderBLL.GetRevenueForMonth(2019, 1, 6, 10));
            series.Points.AddXY("11 - 15", orderBLL.GetRevenueForMonth(2019, 1, 11, 15));
            series.Points.AddXY("16 - 20", orderBLL.GetRevenueForMonth(2019, 1, 16, 20));
            series.Points.AddXY("21 - 25", orderBLL.GetRevenueForMonth(2019, 1, 21, 25));
            series.Points.AddXY("26 - Hết tháng", orderBLL.GetRevenueForMonth(2019, 11, 26, 30));

            bindingSource.DataSource = orderDetailBLL.GetListOrderDetailForStaticByDay(0, 3, 2019);

        }

        private void btnBaoCaoNam_Click(object sender, EventArgs e)
        {
            btnBaoCaoNam.BackColor = Color.Green;
            btnBaoCaoThang.BackColor = Color.Firebrick;
            btnBaoCaoNgay.BackColor = Color.Firebrick;

            var list = orderBLL.GetRevenueForMonthAndYear(2019);
            //chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "{0:###,###,###,###}";
            //chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            //chartRevenue.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            //chartRevenue.ChartAreas[0].Position.Width = 95;

            var series = chartRevenue.Series["Doanh thu"];
            series.Points.Clear();
            series.Enabled = true;

            series.Points.AddXY("Tháng 1", list.Count > 0 ? list[0].Revenue : 0);
            series.Points.AddXY("Tháng 2", list.Count > 1 ? list[1].Revenue : 0);
            series.Points.AddXY("Tháng 3", list.Count > 2 ? list[2].Revenue : 0);
            series.Points.AddXY("Tháng 4", list.Count > 3 ? list[3].Revenue : 0);
            series.Points.AddXY("Tháng 5", list.Count > 4 ? list[4].Revenue : 0);
            series.Points.AddXY("Tháng 6", list.Count > 5 ? list[5].Revenue : 0);
            series.Points.AddXY("Tháng 7", list.Count > 6 ? list[6].Revenue : 0);
            series.Points.AddXY("Tháng 8", list.Count > 7 ? list[7].Revenue : 0);
            series.Points.AddXY("Tháng 9", list.Count > 8 ? list[8].Revenue : 0);
            series.Points.AddXY("Tháng 10", list.Count > 9 ? list[9].Revenue : 0);
            series.Points.AddXY("Tháng 11", list.Count > 10 ? list[10].Revenue : 0);
            series.Points.AddXY("Tháng 12", list.Count > 11 ? list[11].Revenue : 0);

            bindingSource.DataSource = orderDetailBLL.GetListOrderDetailForStaticByDay(0, 0, 2019);

            dgv_Accessory.Columns["Name"].HeaderText = "Tên Linh Kiện";
            dgv_Accessory.Columns["SoldOut"].HeaderText = "Bán ra";
            dgv_Accessory.Columns["Inventory"].HeaderText = "Còn lại";
            dgv_Accessory.Columns["Guarantee"].HeaderText = "Đang bảo hành";

            dgv_Accessory.Columns["STT"].Width = 41;
            dgv_Accessory.Columns["Name"].Width = 211;
            dgv_Accessory.Columns["SoldOut"].Width = 90;
            dgv_Accessory.Columns["Inventory"].Width = 90;
            dgv_Accessory.Columns["Guarantee"].Width = 92;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Accessory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv_Accessory.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
