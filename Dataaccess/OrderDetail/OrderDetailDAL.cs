using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class OrderDetailDAL : IOrderDetailDAL
    {
        QuanLyLinhKienDBContext db;
        public OrderDetailDAL()
        {
            db = new QuanLyLinhKienDBContext();
        }
        public bool CreateOrderDetail(OrderDetail orderDetail)
        {
            db.OrderDetails.Add(orderDetail);
            db.SaveChanges();

            return true;
        }
    }
}
