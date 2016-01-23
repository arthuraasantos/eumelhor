using System.Data.Entity.Migrations;
using EuMelhor.Domain.Entities;
using System;
using EuMelhor.Infrastructure.Utils.Const;

namespace EuMelhor.Infrastructure.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EuMelhor.Infrastructure.Data.Context.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EuMelhor.Infrastructure.Data.Context.MyContext context)
        {
            #region Cria��o de Logs

            
            var Log = new Log()
            {
                Id = Guid.NewGuid(),
                Type = LogType.Audit,
                Description = "Log do m�todo Seed",
                OcurredDate = DateTime.Now,
                Message = "Log feito com sucesso!"
            };

            context.Logs.Add(Log);
            #endregion

            #region Cria��o de Usu�rios
            User user = new User()
            {
                Id = Guid.NewGuid(),
                Name = "Nome Facebook",
                FirstName = "PrimeiroNomeFacebook",
                Lastname = "UltimoNomeFacebook",
                Gender = "GeneroFacebook",
                Link = "LinkPerfilFacebook",
                Locale = "LocalizacaoFacebook",
                UserName = "NomeDeUsuarioFacebook",
                CreateDate = DateTime.Now
            };

            context.Users.Add(user);
            #endregion

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
