using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProStore.Dto;
using WebApiProStore.Models;
using WebApiProStore.Services;

namespace WebApiProStore.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        private readonly IMapper _mapper;

        public AdminController(IAdminService adminService ,  IMapper mapper)
        {
            _adminService = adminService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetUsersForAdmin")]
        [ProducesResponseType(typeof(IEnumerable<AdminDto>), 200)]
        public async Task<IEnumerable<AdminDto>> Get()
        {
            var users = await _adminService.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<User>, IEnumerable<AdminDto>>(users);

            return dto;
        }

        [HttpGet("get/{id}", Name = "GetUserForAdmin")]
        public async Task<AdminDto> Get(string id)
        {
            
            var user = await _adminService.GetAsync(id);
            var dto = _mapper.Map<User, AdminDto>(user);

            return dto;
        }

        [HttpDelete("delete/{id}", Name = "DeleteUserForAdmin")]
        
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _adminService.RemoveAsync(id);

            if (!result.Success)
            {
                return BadRequest();
            }

            
            return Ok("Delete");
        }



    }
}