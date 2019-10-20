﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StaffGettingDto
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string IdentifyNumber { get; set; }
        public string NumberPhone { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
