using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;
using WebApiProStore.Services.Response;

namespace WebApiProStore.Services
{
    public interface IShoppingBagService
    {
        Task<IEnumerable<ShoppingBag>> GetAllAsync();
        Task<ShoppingBagResponse> AddAsync(ShoppingBag product);
        Task<ShoppingBagResponse> RemoveAsync(string id);
    }
}
