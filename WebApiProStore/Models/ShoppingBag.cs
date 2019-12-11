using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProStore.Models
{
    public class ShoppingBag
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ProductId { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string UserName { get; set; }
        public double Price { get; set; }
        
        public virtual User users { get; set; }
        public virtual Product products { get; set; }

    }
}
