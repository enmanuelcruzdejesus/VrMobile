

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace VrMobile.Models
{
    [DataContract]
    public class SalesOrdersDetail
    {
        [DataMember]
        [Key]
        public int Id { get; set; }



        [DataMember]
        public int IdOrder { get; set; }



        [DataMember]
        public int IdItem { get; set; }
        [DataMember]
        public int LineNum { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public decimal UnitPrice { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public DateTime LastUpdate { get; set; }


        [ForeignKey("IdOrder")]
        public virtual SalesOrders Order { get; set; }


    }
}