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
    public class ProductService : IProductService
    {
        private readonly DbSet<Product> _entities;
        protected readonly DataContext _context;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork, DataContext context)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _context = context;
            _entities = _context.Set<Product>();
        }

        public async Task<ProductResponse> AddAsync(Product product)
        {
            try
            {
                await _productRepository.AddAsync(product);
                await _unitOfWork.CompleteAsync();

                return new ProductResponse(product);
            }
            catch (Exception ex)
            {
                return new ProductResponse($"An error , when saving the Product: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }

       

        public async Task<IEnumerable<Product>> GetAsync(string id)
        {
            return await (from p in _context.Products
                          where p.UserId == id
                          select p).ToListAsync();
        }

        public async Task<ProductResponse> RemoveAsync(string id)
        {
            var existingProduct = await _productRepository.GetAsync(id);

            if (existingProduct == null)
                return new ProductResponse("Product not found.");

            try
            {
                _productRepository.Remove(existingProduct);
                await _unitOfWork.CompleteAsync();

                return new ProductResponse(existingProduct);
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
