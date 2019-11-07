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
using System.IO;
using System.Reflection;
using Model;

namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmAccessories : Form
    {
        frmMainUI_Staff frm_main;
        AccesoryBLL accsorybll;
        ProducerBLL producerBLL;
        CategoryBLL categoryBLL;
        BindingSource bindingSource;

        public frmAccessories()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            cbx_Producer.SelectedIndex = 0;
            cbx_Category.SelectedIndex = 0;
            cbx_Producer.ForeColor = Color.DarkGray;
            cbx_Category.ForeColor = Color.DarkGray;
            bunifuCustomDataGridAccessory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Detail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public frmAccessories(frmMainUI_Staff f)
        {
            InitializeComponent();
            frm_main = f;
            bindingSource = new BindingSource();
            cbx_Producer.SelectedIndex = 0;
            cbx_Category.SelectedIndex = 0;
            cbx_Producer.ForeColor = Color.DarkGray;
            cbx_Category.ForeColor = Color.DarkGray;
            bunifuCustomDataGridAccessory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Detail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Custom_Theme()
        {
            btnSearch.Image = imgs_Icon.Images[0];
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
        private void CustomDetail()
        {
            dgv_Detail.Columns["STT"].Width = 30;
            dgv_Detail.Columns["TenHang"].Width = 190;
        }
        private void Custom_GridView()
        {
            foreach (DataGridViewColumn column in bunifuCustomDataGridAccessory.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                column.HeaderCell.Style.Font = new Font("Segoe UI", 12);
            }
            bunifuCustomDataGridAccessory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bunifuCustomDataGridAccessory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void CreateDataGridViewAccessory(BindingSource bindingSource)
        {

            bunifuCustomDataGridAccessory.DataSource = bindingSource;
            bunifuCustomDataGridAccessory.ClearSelection();

            Custom_GridView();
            bunifuCustomDataGridAccessory.Columns["Id"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["Avatar"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["GoodsReceiptDate"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["WarrantyTime"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["CPU"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["ProcessingSpeed"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["Socket"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["Memory"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["Chipset"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["Size"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["Version"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["Bus"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["BIT"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["Power"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["ProducerId"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["CategoryId"].Visible = false;
            //bunifuCustomDataGridAccessory.Columns["Producer"].Visible = false;
            //bunifuCustomDataGridAccessory.Columns["Category"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["Cores"].Visible = false;
            bunifuCustomDataGridAccessory.Columns["Threads"].Visible = false;

            bunifuCustomDataGridAccessory.Columns["STT"].Width = 30;
            bunifuCustomDataGridAccessory.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGridAccessory.Columns["Name"].Width = 160;
            bunifuCustomDataGridAccessory.Columns["Price"].Width = 80;
            bunifuCustomDataGridAccessory.Columns["Inventory"].Width = 80;
            bunifuCustomDataGridAccessory.Columns["CalculationUnit"].Width = 100;

            bunifuCustomDataGridAccessory.Columns["Name"].HeaderText = "Tên Linh Kiện";
            bunifuCustomDataGridAccessory.Columns["Inventory"].HeaderText = "Hiện Có";
            bunifuCustomDataGridAccessory.Columns["Price"].HeaderText = "Đơn Giá";
            bunifuCustomDataGridAccessory.Columns["CalculationUnit"].HeaderText = "Đơn Vị Tính";
        }

        private void CreateDataGridViewDetail()
        {
            dgv_Detail.ClearSelection();
            foreach (DataGridViewColumn column in dgv_Detail.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                column.HeaderCell.Style.Font = new Font("Segoe UI Semibold", 10);
            }
            dgv_Detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Detail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void frmAccessories_Load(object sender, EventArgs e)
        {
            accsorybll = new AccesoryBLL();
            producerBLL = new ProducerBLL();
            categoryBLL = new CategoryBLL();
            bunifuCustomDataGridAccessory.Columns.Add("STT", "STT");
            Custom_Theme();
            bindingSource.DataSource = accsorybll.GetAllAccessories();
            CreateDataGridViewAccessory(bindingSource);
            CustomDetail();
            CreateDataGridViewDetail();
            CreateComboBox();
        }

        private void txtSearch_Enter_1(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Black;
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
            bunifuCustomDataGridAccessory.Rows.Clear();
            bunifuCustomDataGridAccessory.Refresh();
            bindingSource.DataSource = null;

            int producerId = Convert.ToInt32(
                (cbx_Producer.SelectedItem as ComboBoxItem) == null ? "0" : (cbx_Producer.SelectedItem as ComboBoxItem).Value
                );

            string categoryId =
                (cbx_Category.SelectedItem as ComboBoxItem) == null ? "" : (cbx_Category.SelectedItem as ComboBoxItem).Value.ToString();

            string accessoryName = txtSearch.Text;
            bindingSource.DataSource = accsorybll.GetAccessoriesByFilter(producerId, categoryId, accessoryName);

            CreateDataGridViewAccessory(bindingSource);
        }

        private void cbx_GiaTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_GiaTien.SelectedItem.ToString() == "Giá Tăng Dần")
            {
                bindingSource.DataSource = accsorybll.GetAllAccessories().OrderBy(x => x.Price).ToList();
            }
            if (cbx_GiaTien.SelectedItem.ToString() == "Giá Giảm Dần")
            {
                bindingSource.DataSource = accsorybll.GetAllAccessories().OrderByDescending(x => x.Price).ToList();
            }
            if (cbx_GiaTien.SelectedItem.ToString() == "Tên A-Z")
            {
                bindingSource.DataSource = accsorybll.GetAllAccessories().OrderBy(x => x.Name).ToList();
            }
            if (cbx_GiaTien.SelectedItem.ToString() == "Tên Z-A")
            {
                bindingSource.DataSource = accsorybll.GetAllAccessories().OrderByDescending(x => x.Name).ToList();
            }
        }
        private void bunifuCustomDataGrid1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            bunifuCustomDataGridAccessory.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgv_Detail_SelectionChanged(object sender, EventArgs e)
        {
            btnThem.Text = "Xóa";
            if (dgv_Detail.SelectedRows.Count > 0)
            {
                if (dgv_Detail.Rows.Count > 1 && dgv_Detail.SelectedRows[0].Cells["STT"].Value != null)
                {
                    //var category = dgv_Detail.SelectedRows[0].Cells["CategoryId"].Value.ToString();

                    //lbDescription.Text = CreateLabelDescription(category);

                    //var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    //outPutDirectory = outPutDirectory.Replace(@"\QUANLYLINHKIEN_PTUD\bin\Debug", @"\Dataaccess\Images\AccessoryAvatar");

                    //outPutDirectory += @"\";
                    //outPutDirectory += dgv_Detail.SelectedRows[0].Cells["Avatar"].Value;
                    //string directoryPath = new Uri(outPutDirectory).LocalPath;

                    //pictureBox1.Image = new Bitmap(directoryPath);
                    
                }
            }
        }
        private string CreateLabelDescription(string category)
        {
            string s = "";

            if (category.Equals("CPU"))
            {
                s += "CPU   : " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["CPU"].Value.ToString() + "\n\n";
                s += "Tốc độ: " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["ProcessingSpeed"].Value.ToString() + "\n\n";
                s += "Socket: " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Socket"].Value.ToString();
            }
            if (category.Equals("CAC"))
            {
                s += "Kích thước   : " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Size"].Value.ToString();
            }
            if (category.Equals("MAB"))
            {
                s += "CPU       : " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["CPU"].Value.ToString() + "\n\n";
                s += "Kích thước: " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Size"].Value.ToString() + "\n\n";
                s += "Chipset   : " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Chipset"].Value.ToString();
            }
            if (category.Equals("PSU"))
            {
                s += "Công suất   : " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Power"].Value.ToString();
            }
            if (category.Equals("RAM"))
            {
                s += "Bộ nhớ : " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Memory"].Value.ToString() + "\n\n";
                s += "Chuẩn  : " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Version"].Value.ToString() + "\n\n";
                s += "Bus    : " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Bus"].Value.ToString();
            }
            if (category.Equals("VGA"))
            {
                s += "Bộ nhớ : " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Memory"].Value.ToString() + "\n\n";
                s += "Bus    : " + bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Bus"].Value.ToString();
            }
            return s;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGridAccessory.SelectedRows.Count > 0)
            {
                if (btnThem.Text.Contains("Thêm"))
                {
                    DataGridViewRow row = (DataGridViewRow)dgv_Detail.Rows[0].Clone();

                    row.Cells[1].Value = bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Name"].Value;

                    row.Cells[2].Value = bunifuCustomDataGridAccessory.SelectedRows[0].Cells["CalculationUnit"].Value;

                    row.Cells[3].Value = bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Inventory"].Value; ;

                    //row.Cells[4].Value = bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Avatar"].Value;
                    //row.Cells[5].Value = bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Price"].Value;
                    //row.Cells[6].Value = bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Id"].Value;

                    dgv_Detail.Rows.Add(row);
                }
                else
                    if (dgv_Detail.Rows.Count > 1 /*&& dgv_Detail.SelectedRows[0].Index < (dgv_Detail.Rows.Count - 1)*/)
                        dgv_Detail.Rows.RemoveAt(dgv_Detail.SelectedRows[0].Index);
            }
            dgv_Detail.ClearSelection();
            bunifuCustomDataGridAccessory.ClearSelection();
        }

        private void dgv_Detail_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv_Detail.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void bunifuCustomDataGridAccessory_SelectionChanged(object sender, EventArgs e)
        {
            btnThem.Text = "Thêm";
            if (bunifuCustomDataGridAccessory.SelectedRows.Count > 0)
            {
                if (Convert.ToInt32(bunifuCustomDataGridAccessory.SelectedRows[0].Cells["STT"].Value) != bunifuCustomDataGridAccessory.Rows.Count)
                {
                    var category = bunifuCustomDataGridAccessory.SelectedRows[0].Cells["CategoryId"].Value.ToString();

                    lbDetail.Text = CreateLabelDescription(category);
                    var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    outPutDirectory = outPutDirectory.Replace(@"\QUANLYLINHKIEN_PTUD\bin\Debug", @"\Dataaccess\Images\AccessoryAvatar");

                    outPutDirectory += @"\";
                    outPutDirectory += bunifuCustomDataGridAccessory.SelectedRows[0].Cells["Avatar"].Value;
                    string directoryPath = new Uri(outPutDirectory).LocalPath;

                    pictureBox1.Image = new Bitmap(directoryPath);
                }
            }
        }
    }
}
