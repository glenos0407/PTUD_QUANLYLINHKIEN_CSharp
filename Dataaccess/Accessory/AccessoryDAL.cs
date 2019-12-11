using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
                CPU = n.CPU,
                ProcessingSpeed = n.ProcessingSpeed,
                Size = n.Size,
                Socket = n.Socket,
                Memory = n.Memory,
                Chipset = n.Chipset,
                Version = n.Version,
                Bus = n.Bus,
                BIT = n.BIT,
                Power = n.Power,
                Cores = n.Cores,
                Threads = n.Threads,
                ProducerId = n.ProducerId,
                CategoryId = n.CategoryId
            }).ToList();
        }

        public Accessory GetAccessory(string id)
        {
            return db.Accessories.FirstOrDefault(x => x.Id == id);
        }
        public bool UpdateInventoryAccessoryFromExcelFile(string Name,int SoLuong)
        {
            var Acc = db.Accessories.FirstOrDefault(x => x.Name.Equals(Name));
            if(Acc == null)
            {
                return false;
            }
            Acc.Inventory = Acc.Inventory + SoLuong;
            return true;
        }
        public List<AccessoryGettingDTO> GetListAccessoriesByFilter(int producerId, string categoryId, string accessoryName)
        {
            var query = db.Accessories
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
                    CPU = n.CPU,
                    ProcessingSpeed = n.ProcessingSpeed,
                    Size = n.Size,
                    Socket = n.Socket,
                    Memory = n.Memory,
                    Chipset = n.Chipset,
                    Version = n.Version,
                    Bus = n.Bus,
                    BIT = n.BIT,
                    Power = n.Power,
                    Cores = n.Cores,
                    Threads = n.Threads,
                    ProducerId = n.ProducerId,
                    CategoryId = n.CategoryId
                });
            if (producerId > 0)
                query = query.Where(x => x.ProducerId.Equals(producerId));

            if (!string.IsNullOrEmpty(categoryId))
                query = query.Where(x => x.CategoryId.Equals(categoryId));

            if (!string.IsNullOrEmpty(accessoryName))
                query = query.Where(x => x.Name.ToLower().Trim().Contains(accessoryName.ToLower()));

            return query
                .AsQueryable<AccessoryGettingDTO>()
                .ToList();
        }

        public void UpdateInventoryAccessory(string accessoryId, int quantity)
        {
            var accessory = GetAccessory(accessoryId);
            accessory.Inventory -= quantity;
            db.SaveChanges();
        }
        public double GetGuarantee()
        {
            var total = db.Accessories
                .Where(x => x.Status > 0)
                .Select(x => x.Status)
                .ToList();
            return total.Sum();
        }
    }
}
