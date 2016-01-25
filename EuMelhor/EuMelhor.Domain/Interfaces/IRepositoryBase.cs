using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuMelhor.Domain.Interfaces
{
    public interface IRepositoryBase<T>
        where T : class
    {
        IQueryable<T> GetAll();
        Guid GetId(Guid key);
        T GetById(Guid key);
        void Save(T entity);
        void Delete(T entity);
    }
}
