using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using User.Model.DTO;
using User.Model.Responses;
using User.Repository.Interface;

namespace User.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<UserDTO>(user));
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync(RegisterUserDTO registerDto)
        {
            try
            {
                var user = await _userRepository.CreateAsync(registerDto);
                if (user == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(user);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
