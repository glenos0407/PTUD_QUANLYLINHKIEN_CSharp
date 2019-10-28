using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public interface IAccessoryDAL
    {
        List<AccessoryGettingDTO> GetAllAccessories();

        Accessory GetAccessory(string id);

        List<Accessory> GetListAccessories(String name, bool Producer1, bool Category1, bool AccessoriyName1);


    }
}
