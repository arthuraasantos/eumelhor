using EuMelhor.AppService.DTO;
using EuMelhor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuMelhor.AppService.Convert
{
    public interface IConvertBase<TDomainEntity, TDtoEntity>
        where TDomainEntity : EntityBase
        where TDtoEntity : EntityBaseDto
    {
        TDtoEntity ToDtoEntity(TDomainEntity origin, TDtoEntity destiny);
        TDomainEntity ToDomainEntity(TDtoEntity origin, TDomainEntity destiny);
        
    }
}
