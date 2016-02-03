using EuMelhor.AppService.Interfaces;
using System;
using System.Linq;
using EuMelhor.AppService.DTO;
using EuMelhor.Infrastructure.Data.Repositories;
using EuMelhor.Domain.Entities;
using EuMelhor.AppService.Convert;
using System.Collections.Generic;

namespace EuMelhor.AppService.Entities
{
    public class EvaluationAppService : IEvaluationAppService
    {
        private EvaluationRepository _evaluationRepository;
        private EvaluationConvert _evaluationConvert;

        public EvaluationAppService()
        {
            _evaluationRepository = new EvaluationRepository();
            _evaluationConvert = new EvaluationConvert();
        }
        public void Delete(EvaluationDto evaluation)
        {
            var domainEvaluation = new Evaluation();
            _evaluationConvert.ToDomainEntity(evaluation, domainEvaluation);

            _evaluationRepository.Delete(domainEvaluation);
        }

        public List<EvaluationDto> GetAll()
        {
            var listDtoEvaluations = new List<EvaluationDto>();
            var evaluations = _evaluationRepository.GetAll();

            foreach (var item in evaluations)
            {
                var evaluation = new Evaluation();
                var dtoEvaluation = new EvaluationDto();
                _evaluationConvert.ToDtoEntity(evaluation, dtoEvaluation);
                listDtoEvaluations.Add(dtoEvaluation);
            }

            return listDtoEvaluations;
        }

        public EvaluationDto GetById(Guid key)
        {
            var evaluationDto = new EvaluationDto();
            var evaluation = _evaluationRepository.GetById(key);
            _evaluationConvert.ToDtoEntity(evaluation, evaluationDto);

            return evaluationDto;
        }

        public List<EvaluationDto> GetEvaluations(Guid userKey)
        {
            var listDtoEvaluations = new List<EvaluationDto>();
            var evaluations = _evaluationRepository.GetEvaluations(userKey);

            foreach (var item in evaluations)
            {
                var evaluation = new Evaluation();
                var dtoEvaluation = new EvaluationDto();
                _evaluationConvert.ToDtoEntity(evaluation, dtoEvaluation);
                listDtoEvaluations.Add(dtoEvaluation);
            }

            return listDtoEvaluations;
        }

        public void PublishPendingEvaluations(Guid userKey)
        {
            throw new NotImplementedException();
        }

        public void Save(EvaluationDto evaluation)
        {
            var domainEvaluation = new Evaluation();
            _evaluationConvert.ToDomainEntity(evaluation, domainEvaluation);
            _evaluationRepository.Save(domainEvaluation);
        }




    }
}
