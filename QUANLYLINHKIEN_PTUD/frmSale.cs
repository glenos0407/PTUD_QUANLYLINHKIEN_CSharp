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
        public frmSale()
        {
            InitializeComponent();
            comboBox1.Text = "TIM kiem";
            comboBox1.ForeColor = Color.LightGray;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.ForeColor = Color.Black;
        }
    }
}
