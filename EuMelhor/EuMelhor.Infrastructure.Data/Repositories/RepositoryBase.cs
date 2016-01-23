using EuMelhor.Domain.Entities;
using EuMelhor.Domain.Interfaces;
using EuMelhor.Infrastructure.Data.Context;
using EuMelhor.Infrastructure.Utils.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuMelhor.Infrastructure.Data.Repositories
{
    public class RepositoryBase<T, Key> : IRepositoryBase<T, Key>
        where T : EntityBase
        where Key : struct
    {
        private MyContext Uow;
        private ILogRepository LogRepository;
        public RepositoryBase(MyContext uow, ILogRepository log)
        {
            Uow = uow;
            LogRepository = log;
        }

        public void Delete(T entity)
        {
            try
            {
                Uow.Set<T>().Remove(entity);
                var log = new Log(){
                    OcurredDate = DateTime.Now,
                    Description = "Key: '" + entity.Id + "'deletada da tabela " + entity.GetType().Name,
                    Type = LogType.Audit,
                    Message = "Deletado com sucesso" };

                LogRepository.Add(log);
            }
            catch (Exception ex)
            {
                var log = new Log()
                {
                    OcurredDate = DateTime.Now,
                    Description = string.Empty,
                    Type = LogType.Error,
                    Message = "Erro ao criar registro na tabela"+entity.GetType().Name
                };
                LogRepository.Error(log);
                throw;
            }
        }

        public IQueryable<T> GetAll()
        {
            try
            {
                return Uow.Set<T>().AsQueryable();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public T GetById(Key key)
        {
            throw new NotImplementedException();
        }

        public Guid GetId(Key key)
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
