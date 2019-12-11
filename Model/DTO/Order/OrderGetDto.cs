using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderGetDto
    {
        public int OrderId { get; set; }
        public DateTime CreationTime { get; set; }
        public double TotalPrice { get; set; }
        public string StaffName { get; set; }
        public string CustomerName { get; set; }
    }
}
