using EuMelhor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuMelhor.Infrastructure.Data.Mapping
{
    public class EvaluationMapping: EntityTypeConfiguration<Evaluation>
    {
        public EvaluationMapping()
        {
            //HasKey(p => p.Id);
            HasRequired(p => p.ValuedUser).WithRequiredPrincipal().WillCascadeOnDelete(false);
            HasRequired(p => p.ValuerUser).WithRequiredPrincipal().WillCascadeOnDelete(false);
            
        }
    }
}
