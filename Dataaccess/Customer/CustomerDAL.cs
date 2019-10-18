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

        public bool UpdateCustomer(Customer a)
        {
            Customer customer = new Model.Customer();
            customer = db.Customers.Where(x => x.Id == a.Id).FirstOrDefault();
            customer.Name = a.Name;
            customer.NumberPhone = a.NumberPhone;
            customer.IdentifyNumber = a.IdentifyNumber;
            customer.BirthDate = a.BirthDate;
            customer.Email = a.Email;

            try
            {
                db.Customers.AddOrUpdate(customer);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            return true;

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
