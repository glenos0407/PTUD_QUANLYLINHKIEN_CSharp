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
        public List<OrderRevenueYearDto> GetRevenueForMonthAndYear(int year)
        {
            return dal.GetRevenueForMonthAndYear(year);
        }
        public double GetRevenueForMonth(int year, int month, int startDay, int endDay)
        {
            return dal.GetRevenueForMonth(year,month,startDay,endDay);
        }
        public double GetRevenueForDay()
        {
            return dal.GetRevenueForDay();
        }
        public string CompareRevenueForYesterday()
        {
            return dal.CompareRevenueForYesterday();
        }
        public string CompareRevenueForLastMonth()
        {
            return dal.CompareRevenueForLastMonth();
        }
    }
}
