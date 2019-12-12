using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProStore.Dto;
using WebApiProStore.GetRepository;
using WebApiProStore.Models;
using WebApiProStore.Services;

namespace WebApiProStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet("get/{id}", Name = "GetOneItem")]
        public async Task<ProductDto> Get(string id)
        {

            var product = await _productService.GetAsync(id);
            var dto = _mapper.Map<Product, ProductDto>(product);

            return dto;
        }
        [HttpGet]
        [Route("GetAllItem")]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), 200)]
        public async Task<IEnumerable<ProductDto>> Get()
        {
            var products = await _productService.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(products);

            return dto;
        }
        [HttpDelete("Delete/{id}", Name = "DeleteProductFromProductTable")]

        public async Task<IActionResult> Delete(string id)
        {
            var result = await _productService.RemoveAsync(id);

            if (!result.Success)
            {
                return BadRequest();
            }


            return Ok("Product was Delete");
        }
        [HttpPost("post", Name = "AddProductInProductTable")]
        public async Task<IActionResult> Post([FromBody] ProductDto product)
        {
            var pt = _mapper.Map<ProductDto, Product>(product);
            
            var result = await _productService.AddAsync(pt);

            if (!result.Success)
            {
                return BadRequest();
            }


            return Ok("Product Was created in product table");
        }

    }
}