using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Staff")]
    public class Staff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Sai định dạng tên")]
        public string Name { get; set; }
        public string Avatar { get; set; }

        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
            ErrorMessage = "Sai định dạng email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        //[RegularExpression(@"(\+[0-9]{2}|\+[0-9]{2}\(0\)|\(\+[0-9]{2}\)\(0\)|00[0-9]{2}|0)([0-9]{9}|[0-9\-\s]{9,18})",
        //    ErrorMessage = "Sai định dạng số điện thoại")]
        public string NumberPhone { get; set; }

        [Required(ErrorMessage = "Số CMND không được để trống")]
        public string IdentifyNumber { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        public string Password { get; set; }
        public bool IsActived { get; set; }
        public int Role { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
