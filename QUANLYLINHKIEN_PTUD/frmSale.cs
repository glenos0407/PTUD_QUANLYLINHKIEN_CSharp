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

namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmSale : Form
    {
        frmMainUI_Staff fmain;
        AccesoryBLL accesoryBLL;
        BindingSource bindingSource;

        public frmSale()
        {
            InitializeComponent();
            cbx_NhaSanXuat.SelectedIndex = 0;
            cbx_LoaiLinhKien.SelectedIndex = 0;
            cbx_NhaSanXuat.ForeColor = Color.DarkGray;
            cbx_LoaiLinhKien.ForeColor = Color.DarkGray;
            this.FormBorderStyle = FormBorderStyle.None;
            bindingSource = new BindingSource();
            //bindingSource.DataSource
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
            cbx_NhaSanXuat.ForeColor = Color.Black;
        }

        private void cbx_LoaiLinhKien_Enter(object sender, EventArgs e)
        {
            cbx_LoaiLinhKien.ForeColor = Color.Black;
        }

        private void CreateDataGridView()
        {
            bindingSource.DataSource = accesoryBLL.GetAllAccessories();
            dgv_Accessories.Columns.Add("STT", "STT");
            dgv_Accessories.DataSource = bindingSource;
            Custom_GridView();
            dgv_Accessories.Columns["Id"].Visible = false;
            //dgv_Accessories.Columns["Id"].HeaderText = "STT";
            dgv_Accessories.Columns["Avatar"].Visible = false;
            dgv_Accessories.Columns["GoodsReceiptDate"].Visible = false;
            dgv_Accessories.Columns["WarrantyTime"].Visible = false;
            dgv_Accessories.Columns["Description"].Visible = false;
            dgv_Accessories.Columns["CPU"].Visible = false;
            dgv_Accessories.Columns["Generation"].Visible = false;
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
            
            

            //for (int i = 0; i < dgv_StaffInfor.Rows.Count - 1; i++)
            //{
            //    dgv_StaffInfor.Rows[i].Cells[0].Value = (i + 1).ToString();
            //}
        }

        private void Custom_GridView()
        {
            foreach (DataGridViewColumn column in dgv_Accessories.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                column.HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12);
            }
            dgv_Accessories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Accessories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            accesoryBLL = new AccesoryBLL();
            CreateDataGridView();
        }

        private void dgv_Accessories_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv_Accessories.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgv_Accessories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Accessories.SelectedRows.Count > 0)
            {
                if (Convert.ToInt32(dgv_Accessories.SelectedRows[0].Cells["STT"].Value) != dgv_Accessories.Rows.Count)
                {
                    Label lb_Name = new Label();
                    lb_Name.DataBindings.Add("Text", bindingSource, "Name");
                    //lb_Name.Location = new Point(20, 205);
                    lb_Name.AutoSize = false;
                    lb_Name.Size = new Size(300, 45);
                    lb_Name.Anchor = AnchorStyles.Top;
                    lb_Name.Dock = DockStyle.Top;
                    groupBox2.Controls.Add(lb_Name);
                    picbx_LinhKien.Dock = DockStyle.Top;

                    Label lb_TitleCPU = new Label();
                    Label lb_ProcessingSpeed = new Label();
                    Label lb_Socket = new Label();

                    var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    outPutDirectory = outPutDirectory.Replace(@"\QUANLYLINHKIEN_PTUD\bin\Debug", @"\Dataaccess\Images\AccessoryAvatar");

                    outPutDirectory += @"\";
                    outPutDirectory += dgv_Accessories.SelectedRows[0].Cells["Avatar"].Value;
                    string directoryPath = new Uri(outPutDirectory).LocalPath;

                    picbx_LinhKien.Image = new Bitmap(directoryPath);
                }
            }
                  



            //if (dgv_Accessories.SelectedRows[0].Cells["Id"].Value.ToString().Contains("CPU"))
            //{
            //    Label lb_Name = new Label();
            //    lb_Name.Text = "Tên: ";
            //    Label lb_Name = new Label();
            //    lb_Name.Text = "Tên: ";
            //}


            //Label lb_Name = new Label();
            //lb_Name.Text = "Tên: "; 
            //Label lb_Name = new Label();
            //lb_Name.Text = "Tên: ";
            //Label lb_Name = new Label();
            //lb_Name.Text = "Tên: "; 
            //Label lb_Name = new Label();
            //lb_Name.Text = "Tên: "; 
            //Label lb_Name = new Label();
            //lb_Name.Text = "Tên: "; 
            //Label lb_Name = new Label();
            //lb_Name.Text = "Tên: "; 
            //Label lb_Name = new Label();
            //lb_Name.Text = "Tên: ";
        }
    }
}
