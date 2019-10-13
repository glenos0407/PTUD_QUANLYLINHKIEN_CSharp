using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class StaffDAL
    {
        QuanLyLinhKienDBContext db;
        AccountExtension accountEx;
        public StaffDAL()
        {
            db = new QuanLyLinhKienDBContext();
            accountEx = new AccountExtension();
        }
        public bool SignIn(string email, string password)
        {
            var entity = db.Staffs.FirstOrDefault(x => x.Email.Equals(email));

            if (entity == null)
                return false;
            return accountEx.Verify(password, entity.Password);
        }
        //Phát is doing, don't delete
        //public bool ChangePassword(string oldPassword, string newPassword)
        //{

        //}
    }
}
