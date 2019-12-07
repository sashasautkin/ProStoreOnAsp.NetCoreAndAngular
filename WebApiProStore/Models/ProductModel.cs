using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProStore.Models
{
    public class ProductModel
    {
        public string UserId { get; set; }
        public string ProductId { get; set; }
        public string UserName { get; set; }
        public string ProductName { get; set; }        
        public double Price { get; set; }
    }
}
