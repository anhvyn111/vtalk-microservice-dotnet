using Channel.Model.DTO;
using Channel.Repository.Interface;
using Infrastructure.ApiRoutes;
using Microsoft.AspNetCore.Mvc;

namespace Channel.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChannelController : Controller
    {
        private readonly IChannelRepository _channelRepository;

        public ChannelController(IChannelRepository channelRepository)
        {
            _channelRepository = channelRepository;
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
            var newChannelResult = await _channelRepository.CreateChannelAsync(channelDTO);
            
            if (newChannelResult != null)
            {
                return Ok(newChannelResult);
            }

            return BadRequest();
        }

        [HttpPut(ApiRoutes.Channel.UPDATE)]
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
