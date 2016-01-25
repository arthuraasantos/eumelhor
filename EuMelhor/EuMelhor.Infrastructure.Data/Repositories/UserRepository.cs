using EuMelhor.Domain.Entities;
using EuMelhor.Domain.Interfaces;
using EuMelhor.Infrastructure.Data.Context;
using System;

namespace EuMelhor.Infrastructure.Data.Repositories
{
    public class UserRepository : RepositoryBase<User,Guid>, IUserRepository
    {
        private MyContext _uow = new MyContext();
        private LogRepository _logRepository = new LogRepository();
        public UserRepository()
        {

        }
    }
}
