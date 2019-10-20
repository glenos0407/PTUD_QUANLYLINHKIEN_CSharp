using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Họ tên")]
        [Required(ErrorMessage = "Tên không được để trống")]
        //[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Sai định dạng tên")]
        public string Name { get; set; }
        public string Avatar { get; set; }

        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z",
            ErrorMessage = "Sai định dạng email")]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string NumberPhone { get; set; }

        [Display(Name = "Số CMND")]
        [Required(ErrorMessage = "Số CMND không được để trống")]
        public string IdentifyNumber { get; set; }

        [Display(Name = "Ngày sinh")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        public bool IsActived { get; set; }
        public int Role { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
