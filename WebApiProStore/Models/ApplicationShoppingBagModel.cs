﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProStore.Models
{
    public class ApplicationShoppingBagModel
    {
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string UserName { get; set; }
        public int Price { get; set; }
        public string NameProduct { get; set; }
    }
}
