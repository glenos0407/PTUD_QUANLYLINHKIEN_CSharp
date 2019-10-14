﻿using AutoMapper;
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
        public Staff GetStaff(int staffId)
        {
            return db.Staffs.FirstOrDefault(x => x.Id.Equals(staffId));
        }
        public string CreateStaff(StaffCreateDto entity)
        {
            entity.Password = accountEx.Hash(entity.Password);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StaffCreateDto, Staff>();
            });
            IMapper mapper = config.CreateMapper();

            var staff = mapper.Map<StaffCreateDto, Staff>(entity);
            staff.IsActived = true;

            db.Staffs.Add(staff);
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                string s = "";
                foreach (var eve in e.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        s = "Error: " + ve.ErrorMessage;
                    }
                }
                return s;
            }
            return "Success";
        }
    }
}
