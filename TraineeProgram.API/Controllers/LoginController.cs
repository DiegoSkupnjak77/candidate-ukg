using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Exceptions;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Services.Interfaces;

namespace TraineeProgram.API.Controllers
{
    [EnableCors("_myAllowSpecificOrigins")]
    [ApiController]
    [Route("api/login")]
    public class LoginController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService, IMapper mapper)
        {
            _loginService = loginService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<UserReadDto>> LoginUser(LoginDto userLogged)
        {
            try
            {
                var result = await _loginService.LoginUser(_mapper.Map<Login>(userLogged));
                var resultReadDto = _mapper.Map<UserReadDto>(result);
                var claims = new List<Claim>
                    {
                    new Claim(ClaimTypes.Name, result.Email),
                    new Claim(ClaimTypes.Role, $"{result.UserRole}"),
                    };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(claimsIdentity),authProperties);
                return resultReadDto != null ? Ok(resultReadDto) : NotFound();
            }
            catch (WrongCredentialsException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (FieldRequiredException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete]
        public async Task LogoutUser()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}