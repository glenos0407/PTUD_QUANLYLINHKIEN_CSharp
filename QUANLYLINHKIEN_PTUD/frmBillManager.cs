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
    public partial class frmBillManager : Form
    {
        frmMainUI_Staff frm_main;
        private BindingSource bindingSource;
        private BindingSource bindingSourceOrderDetail;
        private OrderBLL orderBLL;
        private OrderDetailBLL orderDetailBLL;

        public frmBillManager()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            orderBLL = new OrderBLL();
            bindingSourceOrderDetail = new BindingSource();
            orderDetailBLL = new OrderDetailBLL();
        }

        public frmBillManager(frmMainUI_Staff f)
        {
            InitializeComponent();
            frm_main = f;
            bindingSource = new BindingSource();
            orderBLL = new OrderBLL();
            bindingSourceOrderDetail = new BindingSource();
            orderDetailBLL = new OrderDetailBLL();
        }

        private void Custom_Theme()
        {
            btnSearch.Image = imgs_Icon.Images[0];
        }

        private void frmBillManager_Load(object sender, EventArgs e)
        {
            Custom_Theme();
            listViewSetting();
            bindingSource.DataSource = orderBLL.GetListOrder();
            dgv_Order.DataSource = bindingSource;
            dgv_Order.Columns["OrderId"].HeaderText = "Mã Hóa Đơn";
            dgv_Order.Columns["CreationTime"].HeaderText = "Ngày lập";
            dgv_Order.Columns["TotalPrice"].HeaderText = "Tổng hóa đơn";
            dgv_Order.Columns["StaffName"].HeaderText = "Người lập";
            dgv_Order.Columns["CustomerName"].HeaderText = "Tên khách hàng";

            dgv_Order.Columns["OrderId"].Width = 60;
        }
        private void listViewSetting()
        {
            this.lstvOrderDetail.View = View.Details;
            this.lstvOrderDetail.GridLines = true;
            this.lstvOrderDetail.FullRowSelect = true;
            this.lstvOrderDetail.MultiSelect = false;

            this.lstvOrderDetail.Columns.Add("", 0);
            this.lstvOrderDetail.Columns.Add("Mã hàng", 60);
            this.lstvOrderDetail.Columns.Add("Tên hàng",165);
            this.lstvOrderDetail.Columns.Add("Số lượng", 55);
            this.lstvOrderDetail.Columns.Add("Đơn vị", 60);
            this.lstvOrderDetail.Columns.Add("Đơn giá", 86);
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

        private void cbx_GiaTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Sort.SelectedItem.ToString() == "Giảm dần")
            {
                bindingSource.DataSource = orderBLL.GetListOrder().OrderByDescending(x => x.TotalPrice);
            }
            if (cbx_Sort.SelectedItem.ToString() == "Tăng dần")
            {
                bindingSource.DataSource = orderBLL.GetListOrder().OrderBy(x => x.TotalPrice);
            }
            dgv_Order.DataSource = bindingSource;

        }

        private void dgv_Order_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_Order.SelectedRows.Count > 0)
            {
                lstvOrderDetail.Items.Clear();

                var orderId = Convert.ToInt32(dgv_Order.SelectedRows[0].Cells["OrderId"].Value);
                var list = orderDetailBLL.GetListGetListOrderDetailByOrderId(orderId);

                foreach (var item in list)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(item.AccessoryId);
                    lvi.SubItems.Add(item.AccessoryName);
                    lvi.SubItems.Add(item.Quantity.ToString());
                    lvi.SubItems.Add(item.AccessoryCalculationUnit);
                    lvi.SubItems.Add(item.AccessoryPrice.ToString());

                    lstvOrderDetail.Items.Add(lvi);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var order = string.IsNullOrEmpty(txtSearch.Text) ? orderBLL.GetListOrder() : orderBLL.GetOrderById(Convert.ToInt32(txtSearch.Text));
                if (order.Count == 0)
                    MessageBox.Show("Không tìm thấy hóa đơn");
                else
                    bindingSource.DataSource = order;
            }
            catch (Exception)
            {
                MessageBox.Show("Mã hóa đơn phải là số");
            }
        }
    }
}
