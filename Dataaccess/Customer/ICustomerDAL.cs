using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public interface ICustomerDAL
    {
        String AddCustomer(CustomerCreateDto CustomerDto);
        List<Customer> GetAllCustomer();
        bool UpdateCustomer(Customer a);
        List<Customer> GetListCustomer(String name);
        Customer GetCustomerFromNumberPhone(String sdt);

    }
}
