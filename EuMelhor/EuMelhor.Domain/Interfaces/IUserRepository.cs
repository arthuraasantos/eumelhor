using EuMelhor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuMelhor.Domain.Interfaces
{
    public interface IUserRepository: IRepositoryBase<User,Guid>
    {
    }
}
