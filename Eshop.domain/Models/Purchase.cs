using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.domain.Models
{
    public class Purchase
    {
        public string PaymentType { get; set; }
        public decimal TotalPrice { get; set; }
        public bool PaymentSuccessfull { get; set; }        
    }
}