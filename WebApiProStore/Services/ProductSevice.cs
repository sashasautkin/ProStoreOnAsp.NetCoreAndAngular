using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProStore.Models;
using WebApiProStore.Repositories;
using WebApiProStore.Services.Response;

namespace WebApiProStore.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _comentRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IProductRepository comentRepository, IUnitOfWork unitOfWork)
        {
            _comentRepository = comentRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ProductResponse> AddAsync(Product product)
        {
            try
            {
                await _comentRepository.AddAsync(product);
                await _unitOfWork.CompleteAsync();

                return new ProductResponse(product);
            }
            catch (Exception ex)
            {
                return new ProductResponse($"An error occurred when saving the coment: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _comentRepository.GetAllAsync();
        }

       

        public async Task<Product> GetAsync(string id)
        {
            return await _comentRepository.GetAsync(id);
        }

        public async Task<ProductResponse> RemoveAsync(string id)
        {
            var existingComent = await _comentRepository.GetAsync(id);

            if (existingComent == null)
                return new ProductResponse("Product not found.");

            try
            {
                _comentRepository.Remove(existingComent);
                await _unitOfWork.CompleteAsync();

                return new ProductResponse(existingComent);
            }
            catch (Exception ex)
            {
                return new ProductResponse($"An error occurred when deleting the coment: {ex.Message}");
            }
        }

        public Task<ProductResponse> UpdateAsync(string id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
