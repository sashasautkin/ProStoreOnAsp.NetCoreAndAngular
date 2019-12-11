using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;

namespace WebApiProStore.Repositories
{
    public interface IShoppingBagRepository : IRepository<ShoppingBag>
    {
        Task<ShoppingBag> GetAsync(string id);
        Task<IEnumerable<ShoppingBag>> GetAllAsync();

        Task AddAsync(ShoppingBag entity);
        Task AddRangeAsync(IEnumerable<ShoppingBag> entities);

        void Update(ShoppingBag entity);

        void Remove(ShoppingBag entity);
        void RemoveRange(IEnumerable<ShoppingBag> entities);
    }
}
