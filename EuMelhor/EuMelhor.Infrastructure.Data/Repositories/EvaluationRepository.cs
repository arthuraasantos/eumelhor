using EuMelhor.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuMelhor.Domain.Entities;
using EuMelhor.Infrastructure.Utils.Const;

namespace EuMelhor.Infrastructure.Data.Repositories
{
    public class EvaluationRepository : RepositoryBase<Evaluation>, IEvaluationRepository
    {
        public IQueryable<Evaluation> GetEvaluations(Guid userKey)
        {
            try
            {
                var evaluations = _uow.Evaluations.Where(p => p.ValuedUser.Id == userKey).Take(100).OrderByDescending(p => p.CreateDate);
                return evaluations;
            }
            catch (Exception ex)
            {
                var log = new Log()
                {
                    OcurredDate = DateTime.Now,
                    Description = "Erro ao buscar avaliações de usuário(" + userKey.ToString() + ")",
                    Type = LogType.Error,
                    Message = ex.Message
                };
                _logRepository.Error(log);
            }

            return null;
        }

        public void PublishPendingEvaluations(Guid userKey)
        {
            throw new NotImplementedException();
        }
    }
}
