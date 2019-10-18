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

        public List<Accessory> GetAllAccessories()
        {
            return acc.GetAllAccessories();
        }
        public Accessory GetAccessory(string id)
        {
            return acc.GetAccessory(id);
        }

        public List<Accessory> GetListAccessories(String name, bool Producer1, bool Category1, bool AccessoriyName1)
        {
            return acc.GetListAccessories(name, Producer1, Category1, AccessoriyName1);
        }
    }
}
