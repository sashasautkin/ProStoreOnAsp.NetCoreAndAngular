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
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetAsync(string id);
        Task<UserResponse> UpdatePasswordAsync(string id, string currentPassword, string newPassword);
        Task<UserResponse> RemoveAsync(string id);
        Task<bool> IsUserAdmin(string id);
    }
}
