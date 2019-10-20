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
        public String AddCustomer(CustomerCreateDto CustomerDto)
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
                return e
                    .EntityValidationErrors
                    .FirstOrDefault()
                    .ValidationErrors
                    .FirstOrDefault()
                    .ErrorMessage;
            }
            return "Success";
        }

        public String UpdateCustomer(CustomerCreateDto cusdto,String sdt)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerCreateDto, Customer>();
            });

            IMapper mapper = config.CreateMapper();
            var a = mapper.Map<CustomerCreateDto, Customer>(cusdto);

            Customer cus = new Customer();
            cus = GetCustomerFromNumberPhone(sdt);
            cus.Name = a.Name;
            cus.NumberPhone = a.NumberPhone;
            cus.IdentifyNumber = a.IdentifyNumber;
            cus.BirthDate = a.BirthDate;
            cus.Email = a.Email;

            try
            {
                db.Customers.AddOrUpdate(cus);
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                return e
                    .EntityValidationErrors
                    .FirstOrDefault()
                    .ValidationErrors
                    .FirstOrDefault()
                    .ErrorMessage;

            }
            return "Success";

        }

        public List<Customer> GetListCustomer(String name)
        {
            return db.Customers.Where(x => x.Name.Equals(name)).ToList();

        }
        public Customer GetCustomerFromNumberPhone(String sdt)
        {
            return db.Customers.Where(x => x.NumberPhone.Equals(sdt)).FirstOrDefault();
        }
    }
}
