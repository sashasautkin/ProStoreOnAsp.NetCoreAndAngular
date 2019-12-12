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
        [Route("GetUsers")]
        [ProducesResponseType(typeof(IEnumerable<AdminDto>), 200)]
        public async Task<IEnumerable<AdminDto>> Get()
        {
            var users = await _adminService.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<User>, IEnumerable<AdminDto>>(users);

            return dto;
        }
    }
}