using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;
using WebApiProStore.Repositories;
using WebApiProStore.Services.Response;

namespace WebApiProStore.Services
{
    public class AdminService : IAdminService
    {

        private readonly UserManager<User> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        public AdminService(UserManager<User> userManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<AdminResponse> RemoveAsync(string id)
        {
            var removeUser = await _userManager.FindByIdAsync(id);

            if (removeUser == null)
                return new AdminResponse("User not found.");

            try
            {
                await _userManager.DeleteAsync(removeUser);
                await _unitOfWork.CompleteAsync();

                return new AdminResponse(removeUser);
            }
            catch (Exception ex)
            {
                return new AdminResponse($"An error occurred when deleting the user: {ex.Message}");
            }
        }

        public async Task<AdminResponse> UpdatePasswordAsync(string id, string currentPassword, string newPassword)
        {
            var user = await _userManager.FindByIdAsync(id);
            try
            {
                await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
                await _unitOfWork.CompleteAsync();

                return new AdminResponse(user);
            }
            catch (Exception ex)
            {
                return new AdminResponse($"An error occurred when changing password: {ex.Message}");
            }
        }

        
    }
}
