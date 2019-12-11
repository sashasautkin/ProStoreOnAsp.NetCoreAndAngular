using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;
using WebApiProStore.Repositories;
using WebApiProStore.Services.Response;

namespace WebApiProStore.Services
{
    public class ShoppingBagService : IShoppingBagService
    {

        private readonly IShoppingBagRepository _bagRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ShoppingBagService(IShoppingBagRepository bagRepository, IUnitOfWork unitOfWork)
        {
            _bagRepository = bagRepository;
            _unitOfWork = unitOfWork;
        }


        public async Task<ShoppingBagResponse> AddAsync(ShoppingBag product)
        {
            try
            {
                await _bagRepository.AddAsync(product);
                await _unitOfWork.CompleteAsync();

                return new ShoppingBagResponse(product);
            }
            catch (Exception ex)
            {
                return new ShoppingBagResponse($"An error occurred when saving the coment: {ex.Message}");
            }
        }

        public async Task<IEnumerable<ShoppingBag>> GetAllAsync()
        {
            return await _bagRepository.GetAllAsync();
        }

        public async Task<ShoppingBagResponse> RemoveAsync(string id)
        {
            var existingbag = await _bagRepository.GetAsync(id);

            if (existingbag == null)
                return new ShoppingBagResponse("Product not found.");

            try
            {
                _bagRepository.Remove(existingbag);
                await _unitOfWork.CompleteAsync();

                return new ShoppingBagResponse(existingbag);
            }
            catch (Exception ex)
            {
                return new ShoppingBagResponse($"An error occurred when deleting the coment: {ex.Message}");
            }

        }
    }
}
