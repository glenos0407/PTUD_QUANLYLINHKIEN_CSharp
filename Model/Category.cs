using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Category")]
    public class Category
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Tên loại không được để trống")]
        public string Name { get; set; }

        public ICollection<Accessory> Accessories { get; set; }
    }
}
