using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;
using WebApiProStore.Services.Response;

namespace WebApiProStore.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetAsync(string id);
        
        Task<ProductResponse> AddAsync(Product product);
        Task<ProductResponse> UpdateAsync(string id, Product product);
        Task<ProductResponse> RemoveAsync(string id);
        
    }
}
