using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiProStore.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository  
    {
        public ProductRepository(DataContext context) : base(context)
        {

        }
        public  async Task AddAsync(Product entity)
        {
            await _context.AddAsync(entity);
        }

        public  async Task AddRangeAsync(IEnumerable<Product> entities)
        {
            await _context.AddRangeAsync(entities);
        }

        public override  async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();

        }

        public override  async Task<Product> GetAsync(string id)
        {
            return await(from p in _context.Products
                         where p.Id == id
                         select p).FirstAsync();

        }

        public void Remove(Product entity)
        {
            _context.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Product> entities)
        {
            _context.RemoveRange(entities);
        }

        public void Update(Product entity)
        {
            _context.Update(entity);
        }
    }
}
