﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;

namespace WebApiProStore.Services.Response
{
    public class ShoppingBagResponse : BaseResponse<ShoppingBag>
    {
        public ShoppingBagResponse(ShoppingBag shoppingBag) : base(shoppingBag)
        {

        }
        public ShoppingBagResponse(string message) : base(message)
        {

        }
    }
}
