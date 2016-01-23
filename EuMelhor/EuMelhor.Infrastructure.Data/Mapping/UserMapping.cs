using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EuMelhor.Domain.Entities;

namespace EuMelhor.Infrastructure.Data.Mapping
{
    public class UserMapping: EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(p => p.Id);
        }
    }
}
