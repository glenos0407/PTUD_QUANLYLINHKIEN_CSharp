using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class CategoryDAL : ICategoryDAL
    {
        QuanLyLinhKienDBContext db;
        public CategoryDAL()
        {
            db = new QuanLyLinhKienDBContext();
        }

        public List<Category> GetAllCategory()
        {
            return db.Categories.ToList();
        }

        public Category GetCategoryByName(string name)
        {
            return db.Categories.FirstOrDefault(x => x.Name.Equals(name));
        }


    }
}
