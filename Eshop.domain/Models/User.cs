using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshop.domain.Models
{
    public class User : Base
    {
        public string Role { get; set; }        
        public string Address { get; set; }
        public string Phone { get; set; }
        
    }
}