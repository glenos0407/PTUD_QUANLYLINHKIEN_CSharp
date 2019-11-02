using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Model;

namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmSale : Form
    {
        static int staffId;
        frmMainUI_Staff fmain;
        AccesoryBLL accesoryBLL;
        CustomerBLL customerBLL;
        OrderBLL orderBLL;
        OrderDetailBLL orderDetailBLL;
        ProducerBLL producerBLL;
        CategoryBLL categoryBLL;
        BindingSource bindingSource;

        public frmSale()
        {
            InitializeComponent();
            cbx_Producer.SelectedIndex = 0;
            cbx_Category.SelectedIndex = 0;
            cbx_Producer.ForeColor = Color.DarkGray;
            cbx_Category.ForeColor = Color.DarkGray;
            this.FormBorderStyle = FormBorderStyle.None;
            bindingSource = new BindingSource();
            //bindingSource.DataSource
        }

        public frmSale(frmMainUI_Staff fm, int _staffId)
        {
            InitializeComponent();
            cbx_Producer.SelectedIndex = 0;
            cbx_Category.SelectedIndex = 0;
            cbx_Producer.ForeColor = Color.DarkGray;
            cbx_Category.ForeColor = Color.DarkGray;
            this.FormBorderStyle = FormBorderStyle.None;
            staffId = _staffId; 
            fmain = fm;
            bindingSource = new BindingSource();
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
            cbx_Producer.ForeColor = Color.Black;
        }

        private void cbx_LoaiLinhKien_Enter(object sender, EventArgs e)
        {
            cbx_Category.ForeColor = Color.Black;
        }

        private void CreateComboBox()
        {
            List<Producer> producers = producerBLL.GetAllProducer();
            List<Category> categories = categoryBLL.GetAllCategory();

            cbx_Producer.DisplayMember = "Text";
            cbx_Producer.ValueMember = "Value";

            foreach (var producer in producers)
            {
                cbx_Producer.Items.Add(new ComboBoxItem()
                {
                    Text = producer.Name,
                    Value = producer.Id
                });
            }

            cbx_Category.DisplayMember = "Text";
            cbx_Category.ValueMember = "Value";

            foreach (var category in categories)
            {
                cbx_Category.Items.Add(new ComboBoxItem()
                {
                    Text = category.Name,
                    Value = category.Id
                });
            }
            cbx_Category.SelectedIndex = 0;
        }

        private void CreateDataGridViewAccessory(BindingSource bindingSource)
        {
            dgv_Accessories.DataSource = bindingSource;
            dgv_Accessories.ClearSelection();
            Custom_GridView();
            dgv_Accessories.Columns["Id"].Visible = false;
            //dgv_Accessories.Columns["Id"].HeaderText = "STT";
            dgv_Accessories.Columns["Avatar"].Visible = false;
            dgv_Accessories.Columns["GoodsReceiptDate"].Visible = false;
            dgv_Accessories.Columns["WarrantyTime"].Visible = false;
            dgv_Accessories.Columns["CPU"].Visible = false;
            dgv_Accessories.Columns["ProcessingSpeed"].Visible = false;
            dgv_Accessories.Columns["Socket"].Visible = false;
            dgv_Accessories.Columns["Memory"].Visible = false;
            dgv_Accessories.Columns["Chipset"].Visible = false;
            dgv_Accessories.Columns["Size"].Visible = false;
            dgv_Accessories.Columns["Version"].Visible = false;
            dgv_Accessories.Columns["Bus"].Visible = false;
            dgv_Accessories.Columns["BIT"].Visible = false;
            dgv_Accessories.Columns["Power"].Visible = false;
            dgv_Accessories.Columns["ProducerId"].Visible = false;
            dgv_Accessories.Columns["CategoryId"].Visible = false;
            //dgv_Accessories.Columns["Producer"].Visible = false;
            //dgv_Accessories.Columns["Category"].Visible = false;
            dgv_Accessories.Columns["Cores"].Visible = false;
            dgv_Accessories.Columns["Threads"].Visible = false;

            //    Id 
            //    Name 
            //    Avatar
            //    Inventory
            //    GoodsReceiptDate 
            //    Price
            //    WarrantyTime
            //    CalculationUnit
            //    Description 
            //    CPU
            //    Generation
            //    ProcessingSpeed 
            //    Size
            //    Socket 
            //    Memory
            //    Chipset
            //    Version 
            //    Bus 
            //    BIT 
            //    Power 
            //    ProducerId 
            //    CategoryId 

            dgv_Accessories.Columns["STT"].Width = 30;
            dgv_Accessories.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Accessories.Columns["Name"].Width = 200;
            dgv_Accessories.Columns["Price"].Width = 80;
            dgv_Accessories.Columns["Inventory"].Width = 50;
            dgv_Accessories.Columns["CalculationUnit"].Width = 40;

            dgv_Accessories.Columns["Name"].HeaderText = "Tên Linh Kiện";
            dgv_Accessories.Columns["Inventory"].HeaderText = "Hiện Có";
            dgv_Accessories.Columns["Price"].HeaderText = "Đơn Giá";
            dgv_Accessories.Columns["CalculationUnit"].HeaderText = "Đơn Vị Tính";
        }

        private void CreateDataGridViewCart()
        {
            dgv_Cart.ClearSelection();
            foreach (DataGridViewColumn column in dgv_Accessories.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                column.HeaderCell.Style.Font = new Font("Segoe UI", 12);
            }
            dgv_Cart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Cart.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Custom_GridView()
        {
            foreach (DataGridViewColumn column in dgv_Accessories.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                column.HeaderCell.Style.Font = new Font("Segoe UI", 12);
            }
            dgv_Accessories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Accessories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            orderBLL = new OrderBLL();
            orderDetailBLL = new OrderDetailBLL();
            customerBLL = new CustomerBLL();
            accesoryBLL = new AccesoryBLL();
            producerBLL = new ProducerBLL();
            categoryBLL = new CategoryBLL();
            dgv_Accessories.Columns.Add("STT", "STT");
            bindingSource.DataSource = accesoryBLL.GetAllAccessories();
            CreateComboBox();
            CreateDataGridViewAccessory(bindingSource);
            CreateDataGridViewCart();
        }

        private void dgv_Accessories_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv_Accessories.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgv_Accessories_SelectionChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "THÊM VÀO GIỎ HÀNG";
            if (dgv_Accessories.SelectedRows.Count > 0)
            {
                if (Convert.ToInt32(dgv_Accessories.SelectedRows[0].Cells["STT"].Value) != dgv_Accessories.Rows.Count)
                {
                    var category = dgv_Accessories.SelectedRows[0].Cells["CategoryId"].Value.ToString();

                    lbDescription.Text = CreateLabelDescription(category);

                    var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    outPutDirectory = outPutDirectory.Replace(@"\QUANLYLINHKIEN_PTUD\bin\Debug", @"\Dataaccess\Images\AccessoryAvatar");

                    outPutDirectory += @"\";
                    outPutDirectory += dgv_Accessories.SelectedRows[0].Cells["Avatar"].Value;
                    string directoryPath = new Uri(outPutDirectory).LocalPath;

                    picbx_LinhKien.Image = new Bitmap(directoryPath);
                }
            }
        }

        private string CreateLabelDescription(string category)
        {
            string s = "";

            if (category.Equals("CPU"))
            {
                s+= "CPU   : " + dgv_Accessories.SelectedRows[0].Cells["CPU"].Value.ToString() + "\n\n";
                s+= "Tốc độ: " + dgv_Accessories.SelectedRows[0].Cells["ProcessingSpeed"].Value.ToString() + "\n\n";
                s+= "Socket: " + dgv_Accessories.SelectedRows[0].Cells["Socket"].Value.ToString();
            }            
            if (category.Equals("CAC"))
            {
                s+= "Kích thước   : " + dgv_Accessories.SelectedRows[0].Cells["Size"].Value.ToString();
            }            
            if (category.Equals("MAB"))
            {
                s+= "CPU       : " + dgv_Accessories.SelectedRows[0].Cells["CPU"].Value.ToString() + "\n\n";
                s+= "Kích thước: " + dgv_Accessories.SelectedRows[0].Cells["Size"].Value.ToString() + "\n\n";
                s+= "Chipset   : " + dgv_Accessories.SelectedRows[0].Cells["Chipset"].Value.ToString();
            }            
            if (category.Equals("PSU"))
            {
                s+= "Công suất   : " + dgv_Accessories.SelectedRows[0].Cells["Power"].Value.ToString();
            }
            if (category.Equals("RAM"))
            {
                s += "Bộ nhớ : " + dgv_Accessories.SelectedRows[0].Cells["Memory"].Value.ToString() + "\n\n";
                s += "Chuẩn  : " + dgv_Accessories.SelectedRows[0].Cells["Version"].Value.ToString() + "\n\n";
                s += "Bus    : " + dgv_Accessories.SelectedRows[0].Cells["Bus"].Value.ToString();
            }
            if (category.Equals("VGA"))
            {
                s += "Bộ nhớ : " + dgv_Accessories.SelectedRows[0].Cells["Memory"].Value.ToString() + "\n\n";
                s += "Bus    : " + dgv_Accessories.SelectedRows[0].Cells["Bus"].Value.ToString();
            }
            return s;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgv_Accessories.SelectedRows.Count > 0)
            {
                if (btnAdd.Text.Contains("THÊM"))
                {
                    var Total = 0;

                    DataGridViewRow row = (DataGridViewRow)dgv_Cart.Rows[0].Clone();
                    row.Cells[0].ToolTipText = "Giá :" + dgv_Accessories.SelectedRows[0].Cells["Price"].Value.ToString();

                    row.Cells[1].Value = dgv_Accessories.SelectedRows[0].Cells["Name"].Value;
                    row.Cells[1].ToolTipText = "Giá :" + dgv_Accessories.SelectedRows[0].Cells["Price"].Value.ToString();

                    row.Cells[2].Value = dgv_Accessories.SelectedRows[0].Cells["CalculationUnit"].Value;
                    row.Cells[2].ToolTipText = "Giá :" + dgv_Accessories.SelectedRows[0].Cells["Price"].Value.ToString();

                    row.Cells[3].Value = "0";
                    //row.Cells[2].ToolTipText = dgv_Accessories.SelectedRows[0].Cells["Price"].Value.ToString();

                    row.Cells[4].Value = dgv_Accessories.SelectedRows[0].Cells["Avatar"].Value;
                    row.Cells[5].Value = dgv_Accessories.SelectedRows[0].Cells["Price"].Value;
                    row.Cells[6].Value = dgv_Accessories.SelectedRows[0].Cells["Id"].Value;

                    Total += Convert.ToInt32(dgv_Accessories.SelectedRows[0].Cells["Price"].Value);

                    dgv_Cart.Rows.Add(row);
                    lb_TongTien.Text = Total.ToString() + "VNĐ"; 
                }
                else
                    if(dgv_Cart.Rows.Count > 1 && dgv_Cart.SelectedRows[0].Index < (dgv_Cart.Rows.Count - 1))
                        dgv_Cart.Rows.RemoveAt(dgv_Cart.SelectedRows[0].Index);
            }
            dgv_Cart.ClearSelection();
            dgv_Accessories.ClearSelection();
        }

        private void dgv_Cart_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv_Cart.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgv_Cart_SelectionChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "XÓA KHỎI GIỎ HÀNG";
            if (dgv_Cart.SelectedRows.Count > 0)
            {
                if (dgv_Cart.Rows.Count > 1 && dgv_Cart.SelectedRows[0].Cells["STT"].Value != null)
                {
                    //var category = dgv_Cart.SelectedRows[0].Cells["CategoryId"].Value.ToString();

                    //lbDescription.Text = CreateLabelDescription(category);

                    var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    outPutDirectory = outPutDirectory.Replace(@"\QUANLYLINHKIEN_PTUD\bin\Debug", @"\Dataaccess\Images\AccessoryAvatar");

                    outPutDirectory += @"\";
                    outPutDirectory += dgv_Cart.SelectedRows[0].Cells["Avatar"].Value;
                    string directoryPath = new Uri(outPutDirectory).LocalPath;

                    picbx_LinhKien.Image = new Bitmap(directoryPath);
                }
            }
        }

        private void btn_CreateOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Yes;
            if (string.IsNullOrEmpty(txt_CustomerName.Text))
                dialogResult = MessageBox.Show("Khách hàng không muốn cộng điểm???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dgv_Cart.Rows.Count <= 1 && dialogResult.Equals(DialogResult.Yes))
                MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                var order = new Order()
                {
                    StaffId = staffId,
                    CustomerId = customerBLL.GetCustomerIdByNumberPhone(txt_PhoneCustomer.Text),
                    CreationTime = DateTime.Now
                };

                var newOrderId = Convert.ToInt32(orderBLL.CreateOrder(order).ToString());

                for (int i = 0; i < (dgv_Cart.Rows.Count - 1); i++)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.OrderId = newOrderId;
                    orderDetail.AccessoryCalculationUnit = dgv_Cart.Rows[i].Cells["CalculationUnit"].Value.ToString();
                    orderDetail.AccessoryName = dgv_Cart.Rows[i].Cells["NameAccessory"].Value.ToString();
                    orderDetail.AccessoryId = dgv_Cart.Rows[i].Cells["Id"].Value.ToString();
                    orderDetail.Quantity = Convert.ToInt32(dgv_Cart.Rows[i].Cells["Quantity"].Value.ToString());
                    orderDetail.AccessoryPrice = Convert.ToDouble(dgv_Cart.Rows[i].Cells["Price"].Value.ToString());

                    orderDetailBLL.CreateOrderDetail(orderDetail);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgv_Accessories.Rows.Clear();
            dgv_Accessories.Refresh();
            bindingSource.DataSource = null;

            int producerId = Convert.ToInt32(
                (cbx_Producer.SelectedItem as ComboBoxItem) == null? "0" : (cbx_Producer.SelectedItem as ComboBoxItem).Value
                );

            string categoryId =
                (cbx_Category.SelectedItem as ComboBoxItem) == null ? "" : (cbx_Category.SelectedItem as ComboBoxItem).Value.ToString();

            string accessoryName = txtSearch.Text;

            bindingSource.DataSource = accesoryBLL.GetAccessoriesByFilter(producerId, categoryId, accessoryName);

            CreateDataGridViewAccessory(bindingSource);
        }

        private void btn_SearchCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_PhoneCustomer.Text))
            {
                var customerName = customerBLL.GetCustomerNameByNumberPhone(txt_PhoneCustomer.Text);
                if (!string.IsNullOrEmpty(customerName))
                {
                    txt_CustomerName.Text = customerName;
                }
            }
            else
                MessageBox.Show("Nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
