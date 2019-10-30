using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Accessory")]
    public class Accessory
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        public string Name { get; set; }
        public string Avatar { get; set; }
        public DateTime GoodsReceiptDate { get; set; }
        public int Inventory { get; set; }
        public double Price { get; set; }
        public string WarrantyTime { get; set; }
        public string CalculationUnit { get; set; }
        public string Description { get; set; }
        public string CPU { get; set; }
        public string Cores { get; set; }
        public string Threads { get; set; }
        public string Generation { get; set; }
        public string ProcessingSpeed { get; set; }
        public string Size { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }
        public string Memory { get; set; }
        public string Version { get; set; }
        public string Bus { get; set; }
        public string BIT { get; set; }
        public string Power { get; set; }


        public int ProducerId { get; set; }
        [ForeignKey(nameof(ProducerId))]
        public Producer Producer { get; set; }

        public string CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
