using EuMelhor.Domain.Entities;
using EuMelhor.Domain.Interfaces;
using EuMelhor.Infrastructure.Data.Context;
using System;

namespace EuMelhor.Infrastructure.Data.Repositories
{
    public class UserRepository : RepositoryBase<User,Guid>, IUserRepository
    {
        private readonly MyContext Uow;
        private readonly ILogRepository LogRepository;

        public UserRepository(MyContext uow, ILogRepository logRepository)
            :base(uow,logRepository)
        {
            Uow = uow;
            LogRepository = logRepository;
        }
    }
}
