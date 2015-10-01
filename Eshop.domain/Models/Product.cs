using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.domain.Models
{
    public class Product : Base 
    {
        public decimal Price { get; set; }
        public int EanCode { get; set; }
        public int Stock { get; set; }
    }
}