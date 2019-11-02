using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;
using Dataaccess;

namespace Business
{
    public class CustomerBLL
    {
        CustomerDAL cus;
        public CustomerBLL()
        {
            cus = new CustomerDAL();
        }
        public List<Customer> GetAllCustomer()
        {
            return cus.GetAllCustomer();
        }

        public Result AddOrUpdateCustomer(CustomerCreateDto CustomerDto)
        {
            return cus.AddOrUpdateCustomer(CustomerDto);
        }

        public List<Customer> GetListCustomer(string name)
        {
            return cus.GetListCustomer(name);

        }
        public Customer GetCustomerFromNumberPhone(string sdt)
        {
            return cus.GetCustomerFromNumberPhone(sdt);
        }
        public int GetCustomerIdByNumberPhone(string sdt)
        {
            return cus.GetCustomerByNumberPhone(sdt);
        }
        public string GetCustomerNameByNumberPhone(string phone)
        {
            return cus.GetCustomerNameByNumberPhone(phone);
        }
    }
}
