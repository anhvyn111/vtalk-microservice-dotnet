using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Entities;

namespace User.Domain.Context
{
    public class UserContext : DbContext
    {
        public virtual DbSet<UserEntity> Users { get; set; }

        public UserContext(DbContextOptions options) : base(options) { }
    }
}
