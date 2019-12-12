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
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        public UserService(UserManager<User> userManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

                

        public async Task<UserResponse> RemoveAsync(string id)
        {
            var removeUser = await _userManager.FindByIdAsync(id);

            if (removeUser == null)
                return new UserResponse("User not found.");

            try
            {
                await _userManager.DeleteAsync(removeUser);
                await _unitOfWork.CompleteAsync();

                return new UserResponse(removeUser);
            }
            catch (Exception ex)
            {
                return new UserResponse($"An error occurred when deleting the user: {ex.Message}");
            }
        }

        
    }
}
