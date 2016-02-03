using EuMelhor.AppService.DTO;
using EuMelhor.Domain.Entities;

namespace EuMelhor.AppService.Convert
{
    public class EvaluationConvert : IConvertBase<Evaluation, EvaluationDto>
    {
        private UserConvert _userConvert;

        public EvaluationConvert()
        {
            _userConvert = new UserConvert();
        }
        public EvaluationDto ToDtoEntity(Evaluation origin, EvaluationDto destiny)
        {
            var valuedUser = new User();
            var valuerUser = new User();

            destiny.Id = origin.Id;
            destiny.Description = origin.Description;
            destiny.CreateDate = origin.CreateDate;
            destiny.DeleteDate = origin.DeleteDate;
            destiny.Type = origin.Type;
            destiny.UpdateDate = origin.UpdateDate;

            _userConvert.ToDtoEntity(origin.ValuedUser, destiny.ValuedUser); 
            _userConvert.ToDtoEntity(origin.ValuerUser, destiny.ValuerUser);
            
            return destiny;
        }

        public Evaluation ToDomainEntity(EvaluationDto origin, Evaluation destiny)
        {
            var valuedUser = new User();
            var valuerUser = new User();

            destiny.Id = origin.Id;
            destiny.Description = origin.Description;
            destiny.CreateDate = origin.CreateDate;
            destiny.DeleteDate = origin.DeleteDate;
            destiny.Type = origin.Type;
            destiny.UpdateDate = origin.UpdateDate;

            _userConvert.ToDomainEntity(origin.ValuedUser, destiny.ValuedUser);
            _userConvert.ToDomainEntity(origin.ValuerUser, destiny.ValuerUser);

            return destiny;
        }
       
    }
}
