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
            #region Criação de Logs

            
            var Log = new Log()
            {
                Id = Guid.NewGuid(),
                Type = LogType.Audit,
                Description = "Log do método Seed",
                OcurredDate = DateTime.Now,
                Message = "Log feito com sucesso!"
            };

            context.Logs.Add(Log);
            #endregion

            #region Criação de Usuários
            User user = new User()
            {
                Id = Guid.NewGuid(),
                Name = "Nome Facebook",
                FirstName = "PrimeiroNomeFacebook",
                LastName = "UltimoNomeFacebook",
                Gender = "GeneroFacebook",
                Link = "LinkPerfilFacebook",
                Locale = "LocalizacaoFacebook",
                UserName = "NomeDeUsuarioFacebook",
                CreateDate = DateTime.Now
            };

            context.Users.Add(user);
            #endregion

            #region Criação de Avaliações
            var evaluation = new Evaluation()
            {
                Id = Guid.NewGuid(),
                Active = true,
                CreateDate = DateTime.Now,
                DeleteDate = null,
                Description = "Primeria avaliação profissional",
                Type = EvaluationType.Professional,
                ValuedUser = user,
                ValuerUser = user,
                UpdateDate = null
            };

            context.Evaluations.AddOrUpdate(evaluation);
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
