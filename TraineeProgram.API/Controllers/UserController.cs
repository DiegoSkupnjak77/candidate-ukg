using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Services.Interfaces;
using static TraineeProgram.Domain.Exceptions.UserExceptions;

namespace TraineeProgram.API.Controllers
{
    [EnableCors("_myAllowSpecificOrigins")]
    [Authorize]
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserReadDto>>> GetUsersAsync()
        {
            var result = await _userService.GetAllAsync();
            List<UserReadDto> usersDto = new List<UserReadDto>();
            foreach (var user in result)
            {
                var userResult = _mapper.Map<UserReadDto>(user);
                usersDto.Add(userResult);
            }
            return Ok(usersDto);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<UserReadDto>> GetUserById([FromRoute] int id)
        {
            var result = await _userService.GetByIdAsync(id);
            var resultDto = _mapper.Map<UserReadDto>(result);
            return resultDto !=null ? Ok(resultDto) : NotFound();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult<UserReadDto>> CreateUser([FromForm] UserDto newUser)
        {
            try
            {
                var userFile = newUser.Photo;
                byte[] transformedFile;

                using (var memorystream = new MemoryStream())
                {
                    userFile.CopyTo(memorystream);
                    var fileBytes = memorystream.ToArray();
                    transformedFile = fileBytes;
                }

                var transformedUser = new User
                {
                    FirstName = newUser.FirstName,
                    LastName = newUser.LastName,
                    Email = newUser.Email,
                    IsActive = newUser.IsActive,
                    UserRole = newUser.UserRole,
                    Password = newUser.Password,
                    Photo = transformedFile
                };

                var result = await _userService.CreateAsync(transformedUser);
                var userReadDto = _mapper.Map<UserReadDto>(result);
                return Ok(userReadDto);
            }
            catch (FieldRequiredException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (DuplicateUserException ex)
            {
                return Conflict(ex.Message);
            }
            catch (RolUserException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}