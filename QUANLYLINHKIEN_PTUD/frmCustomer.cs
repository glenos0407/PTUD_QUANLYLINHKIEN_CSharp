using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Business;
using Model;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmCustomer : Form
    {
        frmMainUI_Staff frm_main;
        CustomerBLL customerbll;
        BindingSource bindingSource;
        bool isEnter = false;
        
        public frmCustomer()
        {
            InitializeComponent();
            customerbll = new CustomerBLL();
            bindingSource = new BindingSource();
            bunifuCustomDataGrid1.Columns.Add("STT", "STT");
            bindingSource.DataSource = customerbll.GetAllCustomer();
            bunifuCustomDataGrid1.MultiSelect = false;
            bunifuCustomDataGrid1.ReadOnly = true;
            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CreateDataGridView();
            
        }

        public frmCustomer(frmMainUI_Staff f)
        {
            InitializeComponent();
            frm_main = f;
            customerbll = new CustomerBLL();
            bindingSource = new BindingSource();
            //bunifuCustomDataGrid1.Columns.Add("STT", "STT");
            //bindingSource.DataSource = customerbll.GetAllCustomer();
            //CreateDataGridView();
        }

        private void Custom_Theme()
        {
            btnSearch.Image = imgs_Icon.Images[0];
            btnLuu.Image = imgs_ButtonIcon.Images[2];
            btnReset.Image = imgs_ButtonIcon.Images[3];

            //Chuyển Trạng Thái TextBox Thành Readonly
            //Enable_TextBox(false);
        }
       
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Custom_Theme();
            rbtnSoDienThoai.Checked = true;
            bunifuCustomDataGrid1.MultiSelect = false;
        }

        private void FillTextBox()
        {
            txtHoKH.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            dtmNgaySinh.DataBindings.Clear();

            txtHoKH.DataBindings.Add("Text", bindingSource, "Name");
            txtEmail.DataBindings.Add("Text", bindingSource, "Email");
            txtCMND.DataBindings.Add("Text", bindingSource, "IdentifyNumber");
            txtSDT.DataBindings.Add("Text", bindingSource, "NumberPhone");
            dtmNgaySinh.DataBindings.Add("Value", bindingSource, "BirthDate");
        }
        private void CreateDataGridView()
        {
            bindingSource.DataSource = customerbll.GetAllCustomer();

            
            bunifuCustomDataGrid1.DataSource = bindingSource;

            bunifuCustomDataGrid1.Columns["Id"].Visible = false;
            bunifuCustomDataGrid1.Columns["Orders"].Visible = false;

            bunifuCustomDataGrid1.Columns["Name"].Width = 120;
            bunifuCustomDataGrid1.Columns["Points"].Width = 70;
            bunifuCustomDataGrid1.Columns["Email"].Width = 150;
            bunifuCustomDataGrid1.Columns["STT"].Width = 30;
            bunifuCustomDataGrid1.Columns["BirthDate"].Width = 110;
            bunifuCustomDataGrid1.Columns["NumberPhone"].Width = 80;
            bunifuCustomDataGrid1.Columns["IdentifyNumber"].Width = 80;
            
            bunifuCustomDataGrid1.Columns["Name"].HeaderText = "Họ tên";
            bunifuCustomDataGrid1.Columns["BirthDate"].HeaderText = "Ngày sinh";
            bunifuCustomDataGrid1.Columns["NumberPhone"].HeaderText = "Số điện thoại";
            bunifuCustomDataGrid1.Columns["IdentifyNumber"].HeaderText = "Số CMND";
            bunifuCustomDataGrid1.Columns["Points"].HeaderText = "Điểm Thưởng";

            bunifuCustomDataGrid1.ClearSelection();
            bunifuCustomDataGrid1.Rows[0].Selected = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hãy Chắc Rằng Bạn Đã Lưu Tất Cả Thay Đổi.\nXác Nhận Thoát Giao Diện Quản Lý Khách Hàng ?", "THOÁT GIAO DIỆN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            isEnter = true;
        }

        private void Enable_TextBox(bool s)
        {
            txtHoKH.Enabled = s;
            txtCMND.Enabled = s;
            txtEmail.Enabled = s;
            txtSDT.Enabled = s;
            dtmNgaySinh.Enabled = s;
        }

        private void Clear_TextBox()
        {
            txtHoKH.Clear();
            txtCMND.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            dtmNgaySinh.Value = DateTime.Now;
        }

        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            CustomerCreateDto cus = new CustomerCreateDto()
            {
                Name = txtHoKH.Text.ToString(),
                NumberPhone = txtSDT.Text.ToString(),
                Email = txtEmail.Text.ToString(),
                Points = 0,
                IdentifyNumber = txtCMND.Text.ToString(),
                BirthDate = dtmNgaySinh.Value
            };
            Result result = null;
            var taskCreateStaff = Task.Factory.StartNew(() => result = customerbll.AddOrUpdateCustomer(cus));
            var taskOpenWaitingForm = Task.Factory.StartNew(() => openWaitingForm());
            taskOpenWaitingForm.Wait();
            taskCreateStaff.Wait();
                
            if (!result.IsSuccess)
            {
                CreateDataGridView();
            }                
            if(result.IsSuccess)
            {
                MessageBox.Show(result.ResultMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }          
            else
            {
                MessageBox.Show(result.ResultMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }           
            bindingSource.DataSource = customerbll.GetAllCustomer();
            CreateDataGridView();
        }

        private void openWaitingForm()
        {
            frmHandling frm = new frmHandling();
            frm.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear_TextBox();
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            String txt = txtSearch.Text.ToString();
            if (txt == "" && isEnter == true)
            {
                MessageBox.Show("Hãy nhập thông tin");
                return;
            }
            if (isEnter == false)
            {
                MessageBox.Show("Hãy nhập thông tin");
                return;
            }
            if (rbtnKhachHang.Checked == true)
            {
                if(customerbll.GetListCustomer(txt).Count != 0)
                {
                    CreateDataGridView();
                    bindingSource.DataSource = customerbll.GetListCustomer(txt);
                }
                else
                {
                    MessageBox.Show("Không Tìm Thấy");
                }
                
            }
            else if (rbtnSoDienThoai.Checked == true)
            {
                if (customerbll.GetCustomerFromNumberPhone(txt).Count != 0)
                {
                    CreateDataGridView();
                    bindingSource.DataSource = customerbll.GetCustomerFromNumberPhone(txt);
                }
                else
                {
                    MessageBox.Show("Không Tìm Thấy");
                }
            }
        }
        private void cbx_SapXep_SelectedIndexChanged(object sender, EventArgs e)//lỗi
        {
            if (cbx_SapXep.SelectedItem.ToString() == "Tên từ A-Z")
            {
                
                //bunifuCustomDataGrid1.Sort(bunifuCustomDataGrid1.Columns[1], ListSortDirection.Descending);

                //bunifuCustomDataGrid1.Columns["Name"].SortMode = DataGridViewColumnSortMode.Automatic;
                bindingSource.DataSource = customerbll.GetAllCustomer().OrderBy(x => x.Name).ToList();
                //CreateDataGridView();

            }
            if (cbx_SapXep.SelectedItem.ToString() == "Tên từ Z-A")
            {
                //bunifuCustomDataGrid1.Sort(bunifuCustomDataGrid1.Columns[0], ListSortDirection.Descending);
                bindingSource.DataSource = customerbll.GetAllCustomer().OrderByDescending(x => x.Name).ToList();
            }
        }

        private void bunifuCustomDataGrid1_SelectionChanged(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                if (Convert.ToInt32(bunifuCustomDataGrid1.SelectedRows[0].Cells["STT"].Value) != bunifuCustomDataGrid1.Rows.Count)
                {
                    FillTextBox();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDataGridView();
            bindingSource.DataSource = customerbll.GetAllCustomer();
        }

        private void bunifuCustomDataGrid1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
