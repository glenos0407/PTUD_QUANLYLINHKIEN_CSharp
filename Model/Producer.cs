using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Producer")]
    public class Producer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên nhà sản xuất không được để trống")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Địa chỉ nhà sản xuất không được để trống")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"(\+[0-9]{2}|\+[0-9]{2}\(0\)|\(\+[0-9]{2}\)\(0\)|00[0-9]{2}|0)([0-9]{9}|[0-9\-\s]{9,18})",
            ErrorMessage = "Sai định dạng số điện thoại")]
        public string NumberPhone { get; set; }

        public ICollection<Accessory> Accessories { get; set; }
    }
}
