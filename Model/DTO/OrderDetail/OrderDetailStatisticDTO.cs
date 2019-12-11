using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class OrderDetailStatisticDTO
    {
        public string Name { get; set; }
        public int SoldOut { get; set; }
        public int Inventory { get; set; }
        public int Guarantee { get; set; }
    }
}
