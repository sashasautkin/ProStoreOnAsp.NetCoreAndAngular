using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApiProStore.Models
{
    public class Product 
    {
       
        public string Id { get; set; }
        public string UserId { get; set; }
        
        [Column(TypeName = "nvarchar(150)")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string ProductName { get; set; }

        public double Price { get; set; }
        public virtual User users { get; set; }
        public virtual ICollection<ShoppingBag> shoppingBags { get; set; }
        
    }
}
