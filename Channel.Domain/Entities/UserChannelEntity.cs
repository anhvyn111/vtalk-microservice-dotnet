using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Channel.Domain.Entities
{
    public class UserChannelEntity : IBaseEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid ChannelId {get; set;}
        public Guid UserId {get; set;}
        public DateTime CreatedAt { get; set; }
    }
}