
using EuMelhor.AppService.DTO;
using EuMelhor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EuMelhor.AppService.Interfaces
{
    public interface IUserAppService
    {
        UserDto GetUser(Guid key);
        List<UserDto> GetAll();
    }
}
