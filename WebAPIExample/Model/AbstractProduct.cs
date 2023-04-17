using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIExample.Model
{
    public abstract class AbstractProduct
    {
        public int id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
