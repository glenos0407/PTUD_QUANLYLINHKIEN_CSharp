using Dataaccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CategoryBLL
    {
        CategoryDAL dal;
        public CategoryBLL()
        {
            dal = new CategoryDAL();
        }

        public List<Category> GetAllCategory()
        {
            return dal.GetAllCategory();
        }
    }
}
