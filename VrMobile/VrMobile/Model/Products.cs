using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VrMobile.Models
{
    public class Products
    {
        public int IdProduct { get; set; }
        public int IdProductRef { get; set; }
        public string ProductName { get; set; }
        public int IdCategory { get; set; }
        public string UnitPrice { get; set; }
        public decimal QtyOnHand { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
