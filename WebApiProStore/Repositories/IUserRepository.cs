using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;

namespace WebApiProStore.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetAsync(string id);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User entity);
        void Update(User entity);
        void Remove(User entity);
        
    }
}
