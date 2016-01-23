using EuMelhor.Domain.Entities;

namespace EuMelhor.Domain.Interfaces
{
    public interface ILogRepository
    {
        void Add(Log log);
        void Update(Log log);
        void Delete(Log log);
        void Error(Log log);
    }
}
