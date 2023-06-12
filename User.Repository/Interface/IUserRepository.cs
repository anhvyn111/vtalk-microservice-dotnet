using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Entities;
using User.Model.DTO;
using User.Model.Responses;

namespace User.Repository.Interface
{
    public interface IUserRepository
    {
        Task<UserEntity> GetByIdAsync(Guid userId);
        Task<UserEntity> CreateAsync(RegisterUserDTO registerDto);
    }
}
