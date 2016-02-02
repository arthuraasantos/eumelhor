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
    public class RepositoryBase<T> : IRepositoryBase<T>
        where T : EntityBase
    {
        private MyContext _uow;
        private LogRepository _logRepository;

        public RepositoryBase()
        {
            _uow = new MyContext();
            _logRepository = new LogRepository();
        }

        public void Delete(T entity)
        {
            try
            {
                _uow.Set<T>().Remove(entity);
                var log = new Log()
                {
                    OcurredDate = DateTime.Now,
                    Description = "Key: '" + entity.Id + "'deletada da tabela " + entity.GetType().Name,
                    Type = LogType.Audit,
                    Message = "Deletado com sucesso"
                };
                _uow.SaveChanges();
                
                _logRepository.Add(log);
            }
            catch (Exception ex)
            {
                var log = new Log()
                {
                    OcurredDate = DateTime.Now,
                    Description = "Erro ao criar registro na tabela" + entity.GetType().Name,
                    Type = LogType.Error,
                    Message = ex.Message
                };
                _logRepository.Error(log);
                throw;
            }
        }

        public IQueryable<T> GetAll()
        {
            return _uow.Set<T>().AsQueryable();
        }

        public T GetById(Guid key)
        {
            return _uow.Set<T>().FirstOrDefault(u => u.Id == key);

        }

        public Guid GetId(Guid key)
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            try
            {
                entity.Id = Guid.NewGuid();
                entity.CreateDate = DateTime.Now; 
                _uow.Set<T>().Add(entity);
                _uow.SaveChanges();

                var log = new Log()
                {
                    OcurredDate = DateTime.Now,
                    Description = "Key: '" + entity.Id + "'atualizada na tabela " + entity.GetType().Name,
                    Type = LogType.Audit,
                    Message = "Atualizado com sucesso"
                };
                _logRepository.Add(log);
            }
            catch (Exception ex)
            {
                var log = new Log()
                {
                    OcurredDate = DateTime.Now,
                    Description = "Erro ao atualizar registro na tabela" + entity.GetType().Name,
                    Type = LogType.Error,
                    Message = ex.Message
                };
                _logRepository.Error(log);
            }
        }

    }
}
