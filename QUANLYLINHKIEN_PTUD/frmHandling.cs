using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYLINHKIEN_PTUD
{
    public partial class frmHandling : Form
    {
        public frmHandling()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Resource_Image.bg_loading;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void timer_loading_Tick(object sender, EventArgs e)
        {
            if (cpb_loading.Value < 100)
            {
                cpb_loading.Value += 10;
            }
            else
                this.Close();
        }

        private void lb_Loading_Click(object sender, EventArgs e)
        {

        }
    }
}
