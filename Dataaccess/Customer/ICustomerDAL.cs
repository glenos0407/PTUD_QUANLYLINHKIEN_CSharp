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
        Result AddCustomer(CustomerCreateDto CustomerDto);
        List<Customer> GetAllCustomer();
        Result UpdateCustomer(CustomerCreateDto cusdto, String sdt);
        List<Customer> GetListCustomer(String name);
        List<Customer> GetCustomerFromNumberPhone(String sdt);

    }
}
