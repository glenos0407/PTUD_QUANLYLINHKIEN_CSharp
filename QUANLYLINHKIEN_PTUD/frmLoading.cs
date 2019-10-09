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
    public partial class frmLoading : Form
    {
        string version;

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }

        public frmLoading()
        {
            InitializeComponent();
        }

        public frmLoading(string ver)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Version = ver;
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            lbVersion.Text = "Version " + version;
            Custom_Theme();
        }

        private void Custom_Theme()
        {

            this.BackgroundImage = Resource_Image.bg_loading;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FormBorderStyle = FormBorderStyle.None;

            this.picbx_Logo.Image = Resource_Image.Logo_PTUD;
            this.picbx_Logo.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void open_login()
        {
            Application.Run(new frmLogin());
        }


        private void timer_loading_Tick(object sender, EventArgs e)
        {
            if(b_pbrLoading.Value < 100)
            {
                b_pbrLoading.Value += 20;
                lbPercent.Text = b_pbrLoading.Value.ToString() + "%";
            }
            else
            {
                Thread th = new Thread(open_login);
                Thread.Sleep(500);
#pragma warning disable CS0618 // Type or member is obsolete
                th.ApartmentState = ApartmentState.STA;
#pragma warning restore CS0618 // Type or member is obsolete
                th.Start();
                
                timer_loading.Stop();
                this.Close();
            }
        }
    }
}
