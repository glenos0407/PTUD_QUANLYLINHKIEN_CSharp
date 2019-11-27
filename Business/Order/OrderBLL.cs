using Dataaccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class OrderBLL
    {
        OrderDAL dal;
        public OrderBLL()
        {
            dal = new OrderDAL();
        }
        public int CreateOrder(Order order)
        {
            return dal.CreateOrder(order);
        }
        public void PrintOrder(OrderPDFCreatingDTO orderPDF)
        {
            dal.PrintOrder(orderPDF);
        }
    }
}
