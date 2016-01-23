using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuMelhor.Domain.Interfaces
{
    public interface IRepositoryBase<T,Key>
        where T : class
        where Key: struct

    {
        IQueryable<T> GetAll();
        Guid GetId(Key key);
        T GetById(Key key);
        void Save(T entity);
        void Delete(T entity);
    }
}
