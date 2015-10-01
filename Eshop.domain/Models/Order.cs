
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.domain.Models
{
    public class Order : Base
    {        
        public List<Product> products { get; set; }
        public User user { get; set; }
    }
}