﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VrMobile.Models
{
    public class Payments
    {
        [Key]
       
        public int IdPayment { get; set; }
        public string IdPaymentRef { get; set; }
        public int IdCustomer { get; set; }
        public DateTime PaymentDate { get; set; }

      
        public int IdInvoice { get; set; }
        public int PaymentMethodRef { get; set; }
        public decimal TotalAmt { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdate { get; set; }


  
        public Invoices Invoice { get; set; }
    }
}
