
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VrMobile.Models
{

    public class SalesOrdersDetail
    {
        
        [Key]
        public int Id { get; set; }


        //[Alias("IdOrder")]
        //public int SalesOrdersDetailId { get; set; }

        public int IdOrder { get; set; }


       

        public int IdItem { get; set; }
        public int LineNum { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdate { get; set; }


    }
}