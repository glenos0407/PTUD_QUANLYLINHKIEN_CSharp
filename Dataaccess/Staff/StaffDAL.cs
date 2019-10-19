using AutoMapper;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class StaffDAL
    {
        private readonly QuanLyLinhKienDBContext db;
        private readonly AccountExtension accountEx;
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
        public bool ChangePassword(Staff staff, string newPassword)
        {
            staff.Password = newPassword;

            db.SaveChanges();
            return true;
        }
        public Staff GetStaffByStaffId(int staffId)
        {
            return db.Staffs.FirstOrDefault(x => x.Id.Equals(staffId));
        }
        public Staff GetStaffByStaffEmail(string email)
        {
            return db.Staffs.FirstOrDefault(x => x.Email.Equals(email));
        }
        public List<StaffGettingDto> GetAllStaffDto()
        {
            return db.Staffs
                .Select(s => new StaffGettingDto
                {
                    Name = s.Name,
                    Avatar = s.Avatar,
                    BirthDate = s.BirthDate,
                    Email = s.Email,
                    IdentifyNumber = s.IdentifyNumber,
                    NumberPhone = s.NumberPhone,
                    Password = s.Password,
                    Role = s.Role
                })
                .ToList();
        }
        public Result CreateStaff(StaffCreatingDto entity)
        {
            entity.Password = accountEx.Hash(entity.Password);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StaffCreatingDto, Staff>();
            });
            IMapper mapper = config.CreateMapper();

            var staff = mapper.Map<StaffCreatingDto, Staff>(entity);
            staff.IsActived = true;

            db.Staffs.Add(staff);
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                return new Result
                {
                    ResultMessage = e
                        .EntityValidationErrors
                        .FirstOrDefault()
                        .ValidationErrors
                        .FirstOrDefault()
                        .ErrorMessage,
                    IsSuccess = false
                };
            }
            return new Result
            {
                ResultMessage = "Tạo nhân viên thành công",
                IsSuccess = true
            };
        }
    }
}
