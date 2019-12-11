using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class OrderDAL : IOrderDAL
    {
        QuanLyLinhKienDBContext db;
        PDFCreateExtention pdfExtention;
        public OrderDAL()
        {
            db = new QuanLyLinhKienDBContext();
        }
        public int CreateOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order.Id;
        }
        public void PrintOrder(OrderPDFCreatingDTO orderPDF)
        {
            pdfExtention = new PDFCreateExtention(orderPDF);
            pdfExtention.CreateBillPDF();
        }
        public List<OrderRevenueYearDto> GetRevenueForMonthAndYear(int year)
        {
            using (SqlConnection con = new SqlConnection(
                "Data Source=.;Initial Catalog=Nhom17.13A.QuanLyLinhKienDB;Integrated Security=true"))
            {
                DataTable dt = new DataTable();
                List<OrderRevenueYearDto> list = new List<OrderRevenueYearDto>();

                SqlCommand cmd = new SqlCommand("GetRevenueForMonthAndYear", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Year", SqlDbType.Int).Value = year;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    OrderRevenueYearDto obj = new OrderRevenueYearDto();

                    obj.Revenue = Convert.ToDouble(dr["TotalRevenue"].ToString());
                    obj.Month = Convert.ToInt32(dr["Month"].ToString());
                    obj.Year = Convert.ToInt32(dr["Year"].ToString());

                    list.Add(obj);
                }
                return list;
            }
        }
        public double GetRevenueForMonth(int year, int month, int startDay, int endDay)
        {
            using (SqlConnection con = new SqlConnection(
                "Data Source=.;Initial Catalog=Nhom17.13A.QuanLyLinhKienDB;Integrated Security=true"))
            {
                DataTable dt = new DataTable();
                List<OrderRevenueYearDto> list = new List<OrderRevenueYearDto>();

                SqlCommand cmd = new SqlCommand("GetRevenueForMonth", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Year", SqlDbType.Int).Value = year;
                cmd.Parameters.Add("@Month", SqlDbType.Int).Value = month;
                cmd.Parameters.Add("@StartDay", SqlDbType.Int).Value = startDay;
                cmd.Parameters.Add("@Endday", SqlDbType.Int).Value = endDay;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    OrderRevenueYearDto obj = new OrderRevenueYearDto();

                    obj.Revenue = Convert.ToDouble(dr["TotalRevenue"].ToString());

                    list.Add(obj);
                }

                var value = Convert.ToDouble(list[0].Revenue);
                return value;
            }
        }
        public double GetRevenueForDay()
        {
            var total = db.Orders
                .Where(x => x.CreationTime == DateTime.Now)
                .Select(s => s.TotalPrice)
                .ToList();
            return total.Count == 0 ? 0 : total.Sum();
        }
        private double GetRevenueForYesterday()
        {
            var yesterday = DateTime.Now.AddDays(-1);
            var total = db.Orders
                .Where(x => x.CreationTime == yesterday)
                .Select(s => s.TotalPrice)
                .ToList();
            return total.Count == 0 ? 0 : total.Sum();
        }
        private double GetRevenueForLastMonth()
        {
            var yesterday = DateTime.Now.AddMonths(-1);
            var total = db.Orders
                .Where(x => x.CreationTime == yesterday)
                .Select(s => s.TotalPrice)
                .ToList();
            return total.Count == 0 ? 0 : total.Sum();
        }
        public string CompareRevenueForYesterday()
        {
            var today = GetRevenueForDay();
            var yesterday = GetRevenueForYesterday();
            var str = "";

            if (today >= yesterday)
                str = "+";
            else
                str = "-";

            if (yesterday > 0 && today > 0)
                str += ((today / yesterday) * 100).ToString() + "%";
            else if (yesterday > 0 && today <= 0)
                str += "100%";
            else if (yesterday <= 0 && today > 0)
                str += "100%";
            else
                str += "0%";
            return str;
        }
        
        public string CompareRevenueForLastMonth()
        {
            var today = GetRevenueForDay();
            var yesterday = GetRevenueForLastMonth();

            var str = "";

            if (today >= yesterday)
                str = "+";
            else
                str = "-";

            if (yesterday > 0 && today > 0)
                str += ((today / yesterday) * 100).ToString() + "%";
            else if (yesterday > 0 && today <= 0)
                str += "100%";
            else if (yesterday <= 0 && today > 0)
                str += "100%";
            else
                str += "0%";
            return str;
        }

    }
}
