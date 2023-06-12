﻿using Channel.Model.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IUserService
    {
        Task<User> GetByIdAsync(Guid id);
    }
}
