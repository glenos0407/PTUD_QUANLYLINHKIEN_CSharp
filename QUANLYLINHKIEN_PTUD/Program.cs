using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYLINHKIEN_PTUD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLoading("1.0"));
            //Application.Run(new frmMainUI_Staff());
            //Application.Run(new frmBillManager());
            //Application.Run(new frmAccessories());
            Application.Run(new frmSale());
            //Application.Run(new frmResult());
        }
    }
}
