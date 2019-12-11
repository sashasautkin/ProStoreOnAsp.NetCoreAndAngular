using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;

namespace WebApiProStore.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetAsync(string id);
        Task<IEnumerable<Product>> GetAllAsync();

        Task AddAsync(Product entity);
        Task AddRangeAsync(IEnumerable<Product> entities);

        void Update(Product entity);

        void Remove(Product entity);
        void RemoveRange(IEnumerable<Product> entities);

    }
}
