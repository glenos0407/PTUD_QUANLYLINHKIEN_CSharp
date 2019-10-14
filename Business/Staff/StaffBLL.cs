using Dataaccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class StaffBLL
    {
        private readonly StaffDAL dal;
        public StaffBLL()
        {
            dal = new StaffDAL();
        }
        public bool SignIn(string email, string password)
        {
            return dal.SignIn(email, password);
        }
        public bool ChangePassword(int staffId, string oldPassword, string newPassword)
        {
            var entity = dal.GetStaff(staffId);
            if (entity == null)
                return false;
            if (!entity.Password.Equals(oldPassword))
                return false;
            
            return dal.ChangePassword(entity, newPassword);
        }
        public string CreateStaff(StaffCreateDto staff)
        {
            return dal.CreateStaff(staff);
        }
    }
}
