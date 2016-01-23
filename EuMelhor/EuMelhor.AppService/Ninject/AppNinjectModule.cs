using EuMelhor.Infrastructure.Data.Context;
using EuMelhor.Infrastructure.Data.Repositories;
using EuMelhor.Domain.Interfaces;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuMelhor.AppService.Ninject
{
    public class AppNinjectModule: NinjectModule
    {
        public override void Load()
        {
            // Contexto
            Bind<MyContext>().ToSelf().InRequestScope();

            // Repositórios
            Bind<IUserRepository>().To<UserRepository>();

        }
    }
}
