using EuMelhor.Domain.Interfaces;
using System;
using EuMelhor.Domain.Entities;
using EuMelhor.Infrastructure.Data.Context;
using System.Data.Entity;

namespace EuMelhor.Infrastructure.Data.Repositories
{
    public class LogRepository : ILogRepository
    {
        private MyContext Uow;

        public LogRepository(MyContext uow)
        {
            Uow = uow;
        }
        public void Add(Log log)
        {
            using (DbContextTransaction transaction = Uow.Database.BeginTransaction())
            {
                try
                {
                    log.OcurredDate = DateTime.Now;
                    log.Message = "Adicionado com sucesso";
                    Uow.Logs.Add(log);
                    Uow.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }
        public void Delete(Log log)
        {
            using (DbContextTransaction transaction = Uow.Database.BeginTransaction())
            {
                try
                {
                    log.OcurredDate = DateTime.Now;
                    log.Message = "Deletado com sucesso";
                    Uow.Logs.Add(log);
                    Uow.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }
        public void Error(Log log)
        {
            using (DbContextTransaction transaction = Uow.Database.BeginTransaction())
            {
                try
                {
                    log.OcurredDate = DateTime.Now;
                    log.Message = "Erro ao executar operação";
                    Uow.Logs.Add(log);
                    Uow.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }
        public void Update(Log log)
        {
            using (DbContextTransaction transaction = Uow.Database.BeginTransaction())
            {
                try
                {
                    log.OcurredDate = DateTime.Now;
                    log.Message = "Atualizado com sucesso";
                    Uow.Logs.Add(log);
                    Uow.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }
    }
}
