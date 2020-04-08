using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VrMobile.Models
{
    public class Roles
    {
        [Key]
        public int IdRole { get; set; }
        public string RoleName { get; set; }
    }
}
