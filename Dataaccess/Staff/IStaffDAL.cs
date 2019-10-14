using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public interface IStaffDAL
    {
        bool SignIn(string email, string password);
        bool ChangePassword(Staff staff, string newPassword);
        Staff GetStaff(int staffId);
    }
}
