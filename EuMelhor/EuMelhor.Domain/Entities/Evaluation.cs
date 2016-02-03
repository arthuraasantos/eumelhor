using EuMelhor.Infrastructure.Utils.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuMelhor.Domain.Entities
{
    public class Evaluation :  EntityBase
    {
        public User ValuedUser { get; set; }
        public User ValuerUser { get; set; }
        public EvaluationType Type { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
    }
}
