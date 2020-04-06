
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VrMobile.Models
{
    public class DeliveryOrders
    {
        [Key]
        public int IdDeliveryOrder { get; set; }
        public int IdDelivery { get; set; }
        public int IdInvoice { get; set; }
        public int IdSupervisor { get; set; }
        public string Signature { get; set; }
        public bool Delivered { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdate { get; set; }

      
        Invoices Invoice { get;set; }


    }
}

