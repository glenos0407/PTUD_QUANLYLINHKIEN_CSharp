using System;
using AutoMapper;
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
        public List<AccessoryGettingDTO> GetAllAccessories()
        {
            return db.Accessories
            .Select(n => new AccessoryGettingDTO
            {
                Id = n.Id,
                Name = n.Name,
                Avatar = n.Avatar,
                Inventory = n.Inventory,
                GoodsReceiptDate = n.GoodsReceiptDate,
                Price = n.Price,
                WarrantyTime = n.WarrantyTime,
                CalculationUnit = n.CalculationUnit,
                Description = n.Description,
                CPU = n.CPU,
                Generation = n.Generation,
                ProcessingSpeed = n.ProcessingSpeed,
                Size = n.Size,
                Socket = n.Socket,
                Memory = n.Memory,
                Chipset = n.Chipset,
                Version = n.Version,
                Bus = n.Bus,
                BIT = n.BIT,
                Power = n.Power,
                ProducerId = n.ProducerId,
                CategoryId = n.CategoryId
            }).ToList();
        }

        public Accessory GetAccessory(string id)
        {
            return db.Accessories.FirstOrDefault(x => x.Id == id);
        }

        public List<Accessory> GetListAccessories(string name, bool Producer1, bool Category1, bool AccessoriyName1)
        {
            throw new NotImplementedException();
        }

        //public List<Accessory> GetListAccessories(string nameAccessory, string, string Category1, string AccessoriyName1)
        //{
        //    //if (Category1)
        //    //{
        //    //    return db.Accessories.Where(x => x.Category.Name.Equals(name)).ToList();
        //    //}
        //    //else if (Producer1)
        //    //{
        //    //    return db.Accessories.Where(x => x.Producer.Name.Equals(name)).ToList();
        //    //}
        //    //return db.Accessories.Where(x => x.Name.Equals(name)).ToList();
        //}



    }
}
