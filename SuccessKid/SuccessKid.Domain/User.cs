using System;
using System.Collections.Generic;

namespace SuccessKid.Domain
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LasName { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public ICollection<Goal> Goals { get; set; }
        public ICollection<LifeValue> LifeValues { get; set; } 
    }
}
