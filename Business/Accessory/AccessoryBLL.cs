using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dataaccess;
using System.Threading.Tasks;

namespace Business
{
    public class AccesoryBLL
    {
        AccessoryDAL acc;
        public AccesoryBLL()
        {
            acc = new AccessoryDAL();
        }

        public List<AccessoryGettingDTO> GetAllAccessories()
        {
            return acc.GetAllAccessories();
        }
        public Accessory GetAccessory(string id)
        {
            return acc.GetAccessory(id);
        }

        public List<AccessoryGettingDTO> GetAccessoriesByFilter(int producerId, string categoryId, string accessoryName)
        {
            return acc.GetListAccessoriesByFilter(producerId, categoryId, accessoryName);
        }
    }
}
