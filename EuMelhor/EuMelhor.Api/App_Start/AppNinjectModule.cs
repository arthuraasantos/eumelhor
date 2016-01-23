using EuMelhor.Infrastructure.Data.Context;
using EuMelhor.Infrastructure.Data.Repositories;
using EuMelhor.Domain.Interfaces;
using Ninject.Modules;
using Ninject.Web.Common;

namespace EuMelhor.Api.AppStart
{
    public class AppNinjectModule: NinjectModule
    {
        public override void Load()
        {
            // Contexto
            Bind<MyContext>().ToSelf().InRequestScope();

            // Repositórios
            Bind<IUserRepository>().To<UserRepository>();
            Bind<ILogRepository>().To<LogRepository>();
        }
    }
}
