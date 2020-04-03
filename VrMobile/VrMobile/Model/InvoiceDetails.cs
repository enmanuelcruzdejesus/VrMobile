
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VrMobile.Models
{
    public class InvoiceDetails
    {
       
        [PrimaryKey]
        [AutoIncrement]
  
        public int Id { get; set; }

      
        public int IdInvoice { get; set; }
        public int IdItem { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
