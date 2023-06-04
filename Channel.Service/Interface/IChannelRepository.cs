using Channel.Domain.Entities;
using Channel.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel.Repository.Interface
{
    public interface IChannelRepository
    {
        Task<List<ChannelEntity>> GetAll();
        Task<ChannelEntity> GetByIdAsync(Guid id);
        Task<ChannelEntity> CreateChannelAsync(ChannelDTO channelDTO);
        Task<ChannelEntity> UpdateChannelAsync(ChannelEntity channelEntity);
        Task<ChannelEntity> DeleteChannelAsync(ChannelEntity channelEntity);
    }
}
