using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WebApiProStore.Dto;
using WebApiProStore.Models;
using WebApiProStore.Services;

namespace WebApiProStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserManager<User>  _userManager;
        private SignInManager<User> _singInManager;
        private readonly IUserService _userService;
        private readonly ApplicationSettings _appSettings;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper, UserManager<User> userManager, SignInManager<User> singInManager,IOptions<ApplicationSettings> appSettings)
        {
            _userService = userService;
            _mapper = mapper;
            _userManager = userManager;
            _singInManager = singInManager;
            _appSettings = appSettings.Value;
        }
        [HttpPost]
        [Route("Register")]
        //POST : /api/Users/Register
        public async Task<Object> PostUsers(UserDto model)
        {
            var User = new User() {             
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.FullName
            };

            try
            {
                var result =await _userManager.CreateAsync(User,model.Password);
                return Ok(result);

            }
            catch (Exception ex)
            {
                throw;
            }

        }
        [HttpPost]
        [Route("Login")]
        //POST : /api/Users/Login
        public async Task<IActionResult> Login(LoginDto model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var tokenDescription = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserID",user.Id.ToString())

                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)

                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescription);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token });
            }
            else
            {
                return BadRequest(new { message = "UserName or Password is incorect" });
            }

        }
        [HttpGet]
        [Route("GetUsers")]
        [ProducesResponseType(typeof(IEnumerable<UserDto>), 200)]
        public async Task<IEnumerable<UserDto>> Get()
        {
            var users = await _userService.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<User>, IEnumerable<UserDto>>(users);

            return dto;
        }

        [HttpGet("Get/{id}", Name = "GetUser")]
        public async Task<UserDto> Get(string id)
        {

            var user = await _userService.GetAsync(id);
            var dto = _mapper.Map<User, UserDto>(user);

            return dto;
        }

        [HttpDelete("Delete/{id}", Name = "DeleteUser")]

        public async Task<IActionResult> Delete(string id)
        {
            var result = await _userService.RemoveAsync(id);

            if (!result.Success)
            {
                return BadRequest();
            }


            return Ok("User was Delete");
        }
    }

}