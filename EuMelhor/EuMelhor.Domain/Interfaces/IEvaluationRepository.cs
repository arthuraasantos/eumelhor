
using EuMelhor.Domain.Entities;
using System;
using System.Linq;

namespace EuMelhor.Domain.Interfaces
{
    public interface IEvaluationRepository: IRepositoryBase<Evaluation>
    {
        IQueryable<Evaluation> GetEvaluations(Guid userKey);
        void PublishPendingEvaluations(Guid userKey);
    }
}
