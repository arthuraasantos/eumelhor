using EuMelhor.Domain.Interfaces;
using System;
using EuMelhor.Domain.Entities;
using EuMelhor.Infrastructure.Data.Context;
using System.Data.Entity;

namespace EuMelhor.Infrastructure.Data.Repositories
{
    public class LogRepository : ILogRepository
    {
        private MyContext _uow;

        public LogRepository()
        {
            _uow = new MyContext();
        }
        public void Add(Log log)
        {
            using (DbContextTransaction transaction = _uow.Database.BeginTransaction())
            {
                try
                {
                    log.OcurredDate = DateTime.Now;
                    log.Message = "Adicionado com sucesso";
                    _uow.Logs.Add(log);
                    _uow.SaveChanges();
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
            using (DbContextTransaction transaction = _uow.Database.BeginTransaction())
            {
                try
                {
                    log.OcurredDate = DateTime.Now;
                    log.Message = "Deletado com sucesso";
                    _uow.Logs.Add(log);
                    _uow.SaveChanges();
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
            using (DbContextTransaction transaction = _uow.Database.BeginTransaction())
            {
                try
                {
                    log.OcurredDate = DateTime.Now;
                    log.Message = "Erro ao executar operação";
                    _uow.Logs.Add(log);
                    _uow.SaveChanges();
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
            using (DbContextTransaction transaction = _uow.Database.BeginTransaction())
            {
                try
                {
                    log.OcurredDate = DateTime.Now;
                    log.Message = "Atualizado com sucesso";
                    _uow.Logs.Add(log);
                    _uow.SaveChanges();
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
