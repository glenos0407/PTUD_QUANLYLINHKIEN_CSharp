﻿using System;
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

        public String AddCustomer(CustomerCreateDto a)
        {
            return cus.AddCustomer(a);
        }

        public bool UpdateCustomer(Customer a)
        {
            return cus.UpdateCustomer(a);
        }
        public List<Customer> GetListCustomer(String name)
        {
            return cus.GetListCustomer(name);

        }
        public Customer GetCustomerFromNumberPhone(String sdt)
        {
            return cus.GetCustomerFromNumberPhone(sdt);
        }

    }
}