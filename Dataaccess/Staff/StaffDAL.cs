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
        public bool ChangePassword(int staffId,string oldPassword, string newPassword)
        {
            var entity = db.Staffs.FirstOrDefault(x => x.Id.Equals(staffId));
            if (entity == null)
                return false;
            if (!entity.Password.Equals(oldPassword))
                return false;

            db.SaveChanges();
            return true;
        }
    }
}
