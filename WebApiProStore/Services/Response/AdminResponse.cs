using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;

namespace WebApiProStore.Services.Response
{
    public class AdminResponse : BaseResponse<User>
    {
        public AdminResponse(User user) : base(user)
        {

        }
        public AdminResponse(string message) : base(message)
        {

        }
    }
}
