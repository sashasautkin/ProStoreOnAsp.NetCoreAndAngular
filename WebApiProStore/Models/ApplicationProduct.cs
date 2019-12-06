using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApiProStore.Models
{
    public class ApplicationProduct 
    {
       
        public string Id { get; set; }
        
        [Column(TypeName = "nvarchar(150)")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string ProductName { get; set; }

        
        public int Price { get; set; }


    }
}
