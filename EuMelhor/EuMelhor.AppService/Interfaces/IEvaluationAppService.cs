using EuMelhor.AppService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EuMelhor.AppService.Interfaces
{
    public interface IEvaluationAppService
    {
        List<EvaluationDto> GetAll();
        EvaluationDto GetById(Guid key);
        void Save(EvaluationDto evaluation);
        void Delete(EvaluationDto evaluation);
        List<EvaluationDto> GetEvaluations(Guid userKey);
        void PublishPendingEvaluations(Guid userKey);

    }
}
