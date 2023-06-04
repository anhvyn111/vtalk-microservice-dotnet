using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Channel.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Channel.Domain.Context
{
    public class ChannelContext : DbContext
    {
        public virtual DbSet<ChannelEntity> Channels { get; set; }
        public virtual DbSet<UserChannelEntity> UserChannels { get; set; }

        public ChannelContext(DbContextOptions options) : base(options) { }
    }
}
