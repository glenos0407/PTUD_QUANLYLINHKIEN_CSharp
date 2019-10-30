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

namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmAccessories : Form
    {
        frmMainUI_Staff frm_main;
        AccesoryBLL accsorybll;
        bool isEnter = false;
        BindingSource bindingSource;

        public frmAccessories()
        {
            InitializeComponent();
            accsorybll = new AccesoryBLL();
            bindingSource = new BindingSource();
            bunifuCustomDataGrid1.Columns.Add("STT", "STT");
            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public frmAccessories(frmMainUI_Staff f)
        {
            InitializeComponent();
            frm_main = f;
            radioButton1.Checked = true;
            accsorybll = new AccesoryBLL();
            bindingSource = new BindingSource();
            bunifuCustomDataGrid1.Columns.Add("STT", "STT");
        }

        private void Custom_Theme()
        {
            btnSearch.Image = imgs_Icon.Images[0];
            radioButton1.Checked = true;
        }

        private void CreateDataGridView()
        {
            bindingSource.DataSource = accsorybll.GetAllAccessories();


            bunifuCustomDataGrid1.DataSource = bindingSource;

            bunifuCustomDataGrid1.Columns["Id"].Visible = false;
            bunifuCustomDataGrid1.Columns["Avatar"].Visible = false;

            //bunifuCustomDataGrid1.Columns["Name"].Width = 120;
            //bunifuCustomDataGrid1.Columns["Points"].Width = 70;
            //bunifuCustomDataGrid1.Columns["Email"].Width = 150;
            //bunifuCustomDataGrid1.Columns["STT"].Width = 30;
            //bunifuCustomDataGrid1.Columns["BirthDate"].Width = 110;
            //bunifuCustomDataGrid1.Columns["NumberPhone"].Width = 80;
            //bunifuCustomDataGrid1.Columns["IdentifyNumber"].Width = 80;

            //bunifuCustomDataGrid1.Columns["Name"].HeaderText = "Họ tên";
            //bunifuCustomDataGrid1.Columns["BirthDate"].HeaderText = "Ngày sinh";
            //bunifuCustomDataGrid1.Columns["NumberPhone"].HeaderText = "Số điện thoại";
            //bunifuCustomDataGrid1.Columns["IdentifyNumber"].HeaderText = "Số CMND";
            //bunifuCustomDataGrid1.Columns["Points"].HeaderText = "Điểm Thưởng";

            bunifuCustomDataGrid1.ClearSelection();


        }
        private void frmAccessories_Load(object sender, EventArgs e)
        {
            Custom_Theme();

        }

        private void txtSearch_Enter_1(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.ForeColor = Color.Black;
            isEnter = true;
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
            String txt = txtSearch.Text.ToString();
            if (txt == "" && isEnter == true)
            {
                MessageBox.Show("Hãy Nhập Thông Tin Tìm kiếm");
                return;
            }
            if (isEnter == false)
            {
                MessageBox.Show("Hãy Nhập Thông Tin Tìm kiếm");
                return;
            }
            bindingSource.DataSource = accsorybll.GetListAccessories(txt, radioButton3.Checked, radioButton2.Checked, radioButton1.Checked).ToString();
        }

        private void cbx_GiaTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_GiaTien.SelectedItem.ToString() == "Giá Tăng Dần")
            {
                //bunifuCustomDataGrid1.Sort(bunifuCustomDataGrid1.Columns[n], ListSortDirection.Ascending);
                bindingSource.DataSource = accsorybll.GetAllAccessories().OrderBy(x => x.Price).ToList();
            }
            if (cbx_GiaTien.SelectedItem.ToString() == "Giá Giảm Dần")
            {
                //bunifuCustomDataGrid1.Sort(bunifuCustomDataGrid1.Columns[n], ListSortDirection.Descending);
                bindingSource.DataSource = accsorybll.GetAllAccessories().OrderByDescending(x => x.Price).ToList();
            }
        }

        private void bunifuCustomDataGrid1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
