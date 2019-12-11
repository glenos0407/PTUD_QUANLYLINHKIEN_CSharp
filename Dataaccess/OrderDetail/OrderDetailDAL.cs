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
        public List<OrderDetailStatisticDTO> GetListOrderDetailForStaticByDay(int day, int month, int year)
        {
            using (SqlConnection con = new SqlConnection(
                            "Data Source=.;Initial Catalog=Nhom17.13A.QuanLyLinhKienDB;Integrated Security=true"))
            {
                DataTable dt = new DataTable();
                List<OrderDetailStatisticDTO> list = new List<OrderDetailStatisticDTO>();
                SqlCommand cmd = null;
                if (day > 0 && month > 0 && year > 0)
                {
                    cmd = new SqlCommand("GetStatisticByDay", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Year", SqlDbType.Int).Value = year;
                    cmd.Parameters.Add("@Month", SqlDbType.Int).Value = month;
                    cmd.Parameters.Add("@Day", SqlDbType.Int).Value = day;
                }
                else if (day <= 0 && month > 0 && year > 0)
                {
                    cmd = new SqlCommand("GetStatisticByMonth", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Year", SqlDbType.Int).Value = year;
                    cmd.Parameters.Add("@Month", SqlDbType.Int).Value = month;
                }
                else if (day <= 0 && month <= 0 && year > 0)
                {
                    cmd = new SqlCommand("GetStatisticByYear", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Year", SqlDbType.Int).Value = year;
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    OrderDetailStatisticDTO obj = new OrderDetailStatisticDTO();

                    obj.Guarantee = Convert.ToInt32(dr["Guarantee"].ToString());
                    obj.Name = dr["Name"].ToString();
                    obj.Inventory = Convert.ToInt32(dr["Inventory"].ToString());
                    obj.SoldOut = Convert.ToInt32(dr["SoldOut"].ToString());

                    list.Add(obj);
                }
                return list;
            }
        }
    }
}
