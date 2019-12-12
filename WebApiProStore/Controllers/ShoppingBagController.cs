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
using WebApiProStore.Services.Response;

namespace WebApiProStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingBagController : ControllerBase
    {
        private readonly IShoppingBagService _bagService;
        private readonly IMapper _mapper;

        public ShoppingBagController(IShoppingBagService bagService, IMapper mapper)
        {
            _bagService = bagService;
            _mapper = mapper;
        }

        [HttpGet("get/{id}", Name = "GetBuyItem")]
        public async Task<ShoppingBagDto> Get(string id)
        {

            var product = await _bagService.GetAsync(id);
            var dto = _mapper.Map<ShoppingBag, ShoppingBagDto>(product);

            return dto;
        }
        [HttpPost("post", Name = "AddProductInShoppingBag")]
        public async Task<IActionResult> Post([FromBody] ShoppingBagDto shoppingBag)
        {
            var pt = _mapper.Map<ShoppingBagDto, ShoppingBag>(shoppingBag);
            pt.UserId = HttpContext.GetUserI d();
            var result = await _bagService.AddAsync(pt);

            if (!result.Success)
            {
                return BadRequest();
            }

            
            return Ok("Thats Ok");
        }

    }
}