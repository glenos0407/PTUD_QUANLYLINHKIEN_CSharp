using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Order")]
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public double TotalPrice { get; set; }
        public int StaffId { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey(nameof(StaffId))]
        public Staff Staff { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
