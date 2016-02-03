﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuMelhor.Domain.Entities
{
    public class User: EntityBase
    {
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string LastName { get; set; }
        public string Link { get; set; }
        public string Locale { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }

    }
}
