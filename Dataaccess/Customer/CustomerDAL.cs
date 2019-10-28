using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using AutoMapper;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;

namespace Dataaccess
{
    public class CustomerDAL : ICustomerDAL
    {
        QuanLyLinhKienDBContext db;

        public CustomerDAL()
        {
            db = new QuanLyLinhKienDBContext();
        }

        public List<Customer> GetAllCustomer()
        {
            return db.Customers.ToList();
        }
        
        public Customer GetCustomer(int id)
        {
            return db.Customers.FirstOrDefault(x => x.Id == id);
        }
        public Result AddCustomer(CustomerCreateDto CustomerDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerCreateDto, Customer>();
            });

            IMapper mapper = config.CreateMapper();
            var cus = mapper.Map<CustomerCreateDto, Customer>(CustomerDto);
            db.Customers.Add(cus);
            
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
                        .LastOrDefault()
                        .ValidationErrors
                        .LastOrDefault()
                        .ErrorMessage,
                    IsSuccess = false
                };
            }
            return new Result
            {
                ResultMessage = "Tạo Khách Hàng thành công",
                IsSuccess = true
            };
        }

        public Result UpdateCustomer(CustomerCreateDto cusdto,String email)
        {
            var entityTemp = db.Staffs.FirstOrDefault(x => x.Email.Equals(email));
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerCreateDto, Customer>();
            });

            IMapper mapper = config.CreateMapper();
            var a = mapper.Map<CustomerCreateDto, Customer>(cusdto);

            entityTemp.Name = cusdto.Name;
            entityTemp.NumberPhone = cusdto.NumberPhone;
            entityTemp.IdentifyNumber = cusdto.IdentifyNumber;
            entityTemp.BirthDate = cusdto.BirthDate;
            entityTemp.Email = cusdto.Email;

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
                        .LastOrDefault()
                        .ValidationErrors
                        .LastOrDefault()
                        .ErrorMessage,
                    IsSuccess = false
                };
            }
            return new Result
            {
                ResultMessage = "Sửa Khách Hàng thành công",
                IsSuccess = true
            };
        }

        public List<Customer> GetListCustomer(String name)
        {
            return db.Customers.Where(x => x.Name.Equals(name)).ToList();

        }
        public List<Customer> GetCustomerFromNumberPhone(String sdt)
        {
            return db.Customers.Where(x => x.NumberPhone.Equals(sdt)).ToList();
        }
        
    }
}
