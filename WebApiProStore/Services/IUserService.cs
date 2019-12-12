using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;
using WebApiProStore.Services.Response;

namespace WebApiProStore.Services
{
    public interface IUserService
    {
                
         Task<UserResponse> RemoveAsync(string id);
       
    }
}
