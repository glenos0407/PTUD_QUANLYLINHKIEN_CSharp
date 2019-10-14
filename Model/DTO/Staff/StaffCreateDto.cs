using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StaffCreateDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string NumberPhone { get; set; }
        public string IdentifyNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public int Role { get; set; }
        public string Password { get; set; }
    }
}
