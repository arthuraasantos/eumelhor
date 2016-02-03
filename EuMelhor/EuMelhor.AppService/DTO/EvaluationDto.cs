using EuMelhor.Infrastructure.Utils.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuMelhor.AppService.DTO
{
    public class EvaluationDto : EntityBaseDto
    {
        public UserDto ValuedUser { get; set; }
        public UserDto ValuerUser { get; set; }
        public EvaluationType Type { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
    }
}
