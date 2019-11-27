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
        public int SignIn(string email, string password)
        {
            return dal.SignIn(email, password);
        }
        public bool ChangePassword(int staffId, string oldPassword, string newPassword)
        {
            var entity = dal.GetStaffByStaffId(staffId);
            if (entity == null)
                return false;
            if (!entity.Password.Equals(oldPassword))
                return false;
            
            return dal.ChangePassword(entity, newPassword);
        }
        public Result CreateOrUpdateStaff
            (StaffCreatingDto staff, string rePassword)
        {
            if (!staff.Password.Equals(rePassword))
                return new Result
                {
                    ResultMessage = "Mật khẩu không trùng",
                    IsSuccess = false
                };
            return  dal.CreateOrUpdateStaff(staff);
        }
        public Staff GetStaffByStaffEmail(string email)
        {
            return dal.GetStaffByStaffEmail(email);
        }
        public List<StaffGettingDto> GetAllStaffDto()
        {
            return dal.GetAllStaffDto();
        }
        public int CountStaff()
        {
            return dal.CountStaff();
        }
        public string GetStaffNameById(int staffId)
        {
            return dal.GetStaffNameById(staffId);
        }
    }
}
