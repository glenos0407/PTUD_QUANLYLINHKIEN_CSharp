using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmFileImport : Form
    {
        public string ExcelURL { get; private set; }

        private String New;
        public frmFileImport()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmFileImport_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.btnOpenFile.Image = imgs_Button.Images[0];
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel 97-2003 |*.xls|Excel WorkBook|*.xlsx" ;
            openFileDialog.FilterIndex = 2;
            openFileDialog.Multiselect = false;

            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog.FileName;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn Muốn Hủy Nhập Hàng ?", "THOÁT GIAO DIỆN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            if(txt != "")
            {

                if(txt.Contains(".xls") || txt.Contains(".xlsx"))
                {
                    ExcelURL = txt;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn Cần Phải Truyền Vào File Excel");
                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn File");
            }
        }
    }
}
