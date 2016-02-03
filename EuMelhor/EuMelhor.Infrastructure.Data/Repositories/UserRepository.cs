using EuMelhor.Domain.Entities;
using EuMelhor.Domain.Interfaces;
using EuMelhor.Infrastructure.Data.Context;
using System;

namespace EuMelhor.Infrastructure.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {

    }
}
