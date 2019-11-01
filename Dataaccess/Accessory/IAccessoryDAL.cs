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
        List<AccessoryGettingDTO> GetListAccessoriesByFilter(int producerId, string categoryId, string accessoryId);
    }
}
