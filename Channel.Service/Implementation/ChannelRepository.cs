using Channel.Domain.Context;
using Channel.Domain.Entities;
using Channel.Model.DTO;
using Channel.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Channel.Repository.Implementation
{
    public class ChannelRepository : IChannelRepository
    {
        private readonly ChannelContext _context;

        public ChannelRepository(ChannelContext context)
        {
            _context = context;
        }

        public async Task<List<ChannelEntity>> GetAll()
        {
            return await _context.Channels.ToListAsync();
        }


        public async Task<ChannelEntity> GetByIdAsync(Guid id)
        {
            return await _context.Channels.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ChannelEntity> CreateChannelAsync(ChannelDTO channelDTO)
        {
            var newChannel = new ChannelEntity(channelDTO.Name, channelDTO.Avatar, channelDTO.CreatedBy);
            await _context.Channels.AddAsync(newChannel);
            await _context.SaveChangesAsync();
            return newChannel;
        }

        public async Task<ChannelEntity> UpdateChannelAsync(ChannelEntity channel)
        {
            _context.Update(channel);
            await _context.SaveChangesAsync();
            return channel;
        }

        public Task<ChannelEntity> DeleteChannelAsync(ChannelEntity channelEntity)
        {
            throw new NotImplementedException();
        }
    }
}