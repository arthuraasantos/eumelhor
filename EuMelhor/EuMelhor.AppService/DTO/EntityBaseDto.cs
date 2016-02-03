using System;

namespace EuMelhor.AppService.DTO
{
    public class EntityBaseDto
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

    }
}
