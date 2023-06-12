using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Context;
using User.Domain.Entities;
using User.Model.DTO;
using User.Model.Responses;
using User.Repository.Interface;

namespace User.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public async Task<UserEntity> GetByIdAsync(Guid userId)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            
        }

        public async Task<UserEntity> CreateAsync(RegisterUserDTO registerDto)
        {
            var user = new UserEntity(registerDto);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
