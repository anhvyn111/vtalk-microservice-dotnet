using Channel.Model.DTO;
using Channel.Repository.Interface;
using Infrastructure.ApiRoutes;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Channel.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChannelController : Controller
    {
        private readonly IChannelRepository _channelRepository;
        private readonly IUserService _userService;
        public ChannelController(IChannelRepository channelRepository, IUserService userService)
        {
            _channelRepository = channelRepository;
            _userService = userService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAsync()
        {
            var channels = await _channelRepository.GetAll();
            return Ok(channels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var channel = await _channelRepository.GetByIdAsync(id);

            if (channel != null)
            {
                return Ok(channel);
            }

            return NotFound();
        }

        [HttpPost(ApiRoutes.Channel.CREATE)]
        public async Task<IActionResult> CreateAsync(ChannelDTO channelDTO)
        {
            var user = await _userService.GetByIdAsync(channelDTO.CreatedBy);
            if (user == null) 
            {
                return NotFound("User not found");
            }
            var newChannelResult = await _channelRepository.CreateChannelAsync(channelDTO);
            
            if (newChannelResult != null)
            {
                return Ok(newChannelResult);
            }

            return BadRequest();
        }

        [HttpPost(ApiRoutes.Channel.UPDATE)]
        public async Task<IActionResult> UpdateAsync(ChannelDTO channelDTO)
        {
            var channel = await _channelRepository.GetByIdAsync(channelDTO.Id);

            if (channel == null)
            {
                return NotFound();
            }

            channel.Update(channelDTO);
            await _channelRepository.UpdateChannelAsync(channel);

            return Ok(channel);
        }
    }
}
