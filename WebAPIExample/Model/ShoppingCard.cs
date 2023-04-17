using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIExample.Model;

namespace WebSiteExample.Models
{
    public class ShoppingCard : AbstractProduct
    {
        //public int id { get; set; }
        //public string ProductName { get; set; }
        //public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }
        
        public decimal TotalPrice { get; set; }
    }
}