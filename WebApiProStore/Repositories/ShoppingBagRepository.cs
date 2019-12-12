using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;

namespace WebApiProStore.Repositories
{
    public class ShoppingBagRepository : Repository<ShoppingBag> , IShoppingBagRepository
    {
        public ShoppingBagRepository(DataContext context) : base(context)
        {

        }
        public async Task AddAsync(ShoppingBag entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<ShoppingBag> entities)
        {
            await _context.AddRangeAsync(entities);
        }

        public override async Task<IEnumerable<ShoppingBag>> GetAllAsync()
        {
            return await _context.ShoppingBags.ToListAsync();

        }

        public override async Task<ShoppingBag> GetAsync(string id)
        {
            return await (from p in _context.ShoppingBags
                          where p.UserId == id
                          select p).FirstAsync();

        }

        public void Remove(ShoppingBag entity)
        {
            _context.Remove(entity);
        }

        public void RemoveRange(IEnumerable<ShoppingBag> entities)
        {
            _context.RemoveRange(entities);
        }

        public void Update(ShoppingBag entity)
        {
            _context.Update(entity);
        }
    }
}
