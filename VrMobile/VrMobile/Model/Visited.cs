using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VrMobile.Models
{
    public class Visited
    {
        [Key]
        public int IdVisited { get; set; }
        public int IdVendorVisit { get; set; }
        public int IdSalesOrder { get; set; }
        public int IdPaymentRef { get; set; }
        public string Signature { get; set; }
        public int IdConfirmerSuperVisor { get; set; }
        public DateTime ConfirmDate { get; set; }
    }
}
