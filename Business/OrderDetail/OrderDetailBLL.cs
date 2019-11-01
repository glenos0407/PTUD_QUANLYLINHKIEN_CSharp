using Dataaccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class OrderDetailBLL
    {
        OrderDetailDAL dal;

        public OrderDetailBLL()
        {
            dal = new OrderDetailDAL();
        }

        public bool CreateOrderDetail(OrderDetail orderDetail)
        {
            return dal.CreateOrderDetail(orderDetail);
        }
    }
}
