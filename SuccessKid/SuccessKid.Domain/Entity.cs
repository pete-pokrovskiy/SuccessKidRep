using System;

namespace SuccessKid.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set;}
    }
}
