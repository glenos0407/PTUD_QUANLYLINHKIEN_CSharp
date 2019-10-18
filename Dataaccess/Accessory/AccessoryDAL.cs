using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class AccessoryDAL : IAccessoryDAL
    {
        QuanLyLinhKienDBContext db;
        public AccessoryDAL()
        {
            db = new QuanLyLinhKienDBContext();
        }
        public List<Accessory> GetAllAccessories()
        {
            return db.Accessories.ToList();
        }
        public Accessory GetAccessory(string id)
        {
            return db.Accessories.FirstOrDefault(x => x.Id == id);
        }

        public List<Accessory> GetListAccessories(String name, bool Producer1, bool Category1, bool AccessoriyName1)
        {
            if (Category1)
            {
                return db.Accessories.Where(x => x.Category.Name.Equals(name)).ToList();
            }
            else if (Producer1)
            {
                return db.Accessories.Where(x => x.Producer.Name.Equals(name)).ToList();
            }
            return db.Accessories.Where(x => x.Name.Equals(name)).ToList();
        }



    }
}
