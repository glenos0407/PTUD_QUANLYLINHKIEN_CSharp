using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public string AccessoryId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int OrderId { get; set; }

        public int Quantity { get; set; }
        public string AccessoryName { get; set; }
        public string AccessoryCalculationUnit { get; set; }
        public double AccessoryPrice { get; set; }

        [ForeignKey(nameof(AccessoryId))]
        public Accessory Accessory { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }
    }
}
