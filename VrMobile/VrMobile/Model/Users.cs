﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VrMobile.Models
{
    public class Users
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IdRole { get; set; }
        public int IdEmployeeQB { get; set; }
        public DateTime Created { get; set; }
    }
}
