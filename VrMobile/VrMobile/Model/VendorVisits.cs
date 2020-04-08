

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VrMobile.Models
{
    public class VendorVisits
    {

        [Key]
        public int IdVendorVisit { get; set; }
        public int IdCustomer { get; set; }
        public int IdVendor { get; set; }
        public int IdSupervisor { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdate { get; set; }

        [ForeignKey("IdCustomer")]
        public virtual Customers Customer { get; set; }
    }
}
