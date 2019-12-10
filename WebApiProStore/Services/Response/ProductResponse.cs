using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;

namespace WebApiProStore.Services.Response
{
    public class ProductResponse : BaseResponse<Product>
    {
        public ProductResponse(Product post) : base(post)
        {

        }
        public ProductResponse(string message) : base(message)
        {

        }
    }
}
