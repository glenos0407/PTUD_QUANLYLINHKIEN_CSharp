using Business;
using Model;
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
    public partial class frmCreateStaff : Form
    {
        private readonly StaffBLL staffbll;
        public frmCreateStaff()
        {
            InitializeComponent();
            staffbll = new StaffBLL();
            dtp_BirthDate.Format = DateTimePickerFormat.Custom;
            dtp_BirthDate.CustomFormat = "dd/MM/yyyy";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffCreateDto staff = new StaffCreateDto()
            {
                //Name = txt_Name.Text.ToString(),
                //Email = txt_Email.Text.ToString(),
                //IdentifyNumber = txt_Identify.Text.ToString(),
                //NumberPhone = txt_Identify.Text.ToString(),
                //BirthDate = dtp_BirthDate.Value,
                //Role = Convert.ToInt32(cbx_Role.Text.ToString()),
                //Password = txt_Password.Text.ToString()
                Name = "John Cena",
                Email = "chautruongphat123@gmail.com",
                IdentifyNumber = "123456789",
                NumberPhone = "123456789",
                BirthDate = dtp_BirthDate.Value,
                Role = Convert.ToInt32(cbx_Role.Text.ToString()),
                Password = "123qwe"
            };
            MessageBox.Show(staffbll.CreateStaff(staff));
          
        }
    }
}
