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
        public Result AddOrUpdateCustomer(CustomerCreateDto CustomerDto)
        {
            var entityTemp = db.Customers.FirstOrDefault(x => x.Email.Equals(CustomerDto.Email));
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerCreateDto, Customer>();
            });

            IMapper mapper = config.CreateMapper();
            var cus = mapper.Map<CustomerCreateDto, Customer>(CustomerDto);

            if(entityTemp == null)
            {
                db.Customers.Add(cus);
            }
            else
            {
                entityTemp.Name = CustomerDto.Name;
                entityTemp.NumberPhone = CustomerDto.NumberPhone;
                entityTemp.IdentifyNumber = CustomerDto.IdentifyNumber;
                entityTemp.BirthDate = CustomerDto.BirthDate;
                entityTemp.Email = CustomerDto.Email;
            }
            
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
                ResultMessage = "Thao Tác thành công",
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
