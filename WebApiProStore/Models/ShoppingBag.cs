using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProStore.Models
{
    public class ShoppingBag
    {
        
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string UserName { get; set; }
        public string NameProduct { get; set;  }
        public double Price { get; set; }
        


    }
}
