using System;

namespace SuccessKid.Domain
{
    public class LifeValue : Entity
    {
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
