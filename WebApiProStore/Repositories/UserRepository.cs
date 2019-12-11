using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;

namespace WebApiProStore.Repositories
{
    public class UserRepository : Repository<User> , IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {

        }
        public async Task AddAsync(User entity)
        {
            await _context.AddAsync(entity);
        }

        public override async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();

        }

        public override async Task<User> GetAsync(string id)
        {
            return await (from p in _context.Users
                          where p.Id == id
                          select p).FirstAsync();
        }

        public void Remove(User entity)
        {
            _context.Remove(entity);
        }
        
        public void Update(User entity)
        {
            _context.Update(entity);
        }
    }
}
