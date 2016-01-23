using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuMelhor.Infrastructure.Utils.Const;


namespace EuMelhor.Domain.Entities
{
    public class Log
    {
        public Guid Id { get; set; }
        public DateTime OcurredDate { get; set; }
        public string Description { get; set; }
        public LogType Type { get; set; }
        public string Message { get; set; } 
    }
}
