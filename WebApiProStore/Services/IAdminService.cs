using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;
using WebApiProStore.Services.Response;

namespace WebApiProStore.Services
{
    public interface IAdminService
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<AdminResponse> UpdatePasswordAsync(string id, string currentPassword, string newPassword);
        Task<AdminResponse> RemoveAsync(string id);
    }
}
