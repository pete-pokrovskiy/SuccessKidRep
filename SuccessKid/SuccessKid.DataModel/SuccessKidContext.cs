using System.Data.Entity;
using SuccessKid.Domain;

namespace SuccessKid.DataModel
{
    public class SuccessKidContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<LifeValue> LifeValues { get; set; }
    }
}
