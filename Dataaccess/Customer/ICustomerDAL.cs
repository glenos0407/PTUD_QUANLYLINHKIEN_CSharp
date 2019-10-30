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
        List<Customer> GetAllCustomer();
        Result AddOrUpdateCustomer(CustomerCreateDto CustomerDto);
        List<Customer> GetListCustomer(String name);
        List<Customer> GetCustomerFromNumberPhone(String sdt);

    }
}
