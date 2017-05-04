using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SuccessKid.Domain;

namespace SuccessKid.DataModel
{
    public class SuccessKidContext : DbContext
    {
        public SuccessKidContext()
        {
            //варианты:
            //CreateDatabaseIfNotExists (default) -Checks if the database exists and creates it if it can’t find one. If the database exists but has an incompatible schema then it throws an exception.
            //DropCreateDatabaseIfModelChanges - Creates the database if it doesn’t exist. If the database exists but has an incompatible schema then it drops the existing database and creates a new one.
            //DropCreateDatabaseAlways - Every time you run the application it drops an existing database and recreates it.
            //Custom initializer - Custom initializer class you write to work out just the behavior you wish to have that none of the other options offer

            Database.SetInitializer(new DropCreateDatabaseAlways<SuccessKidContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<LifeValue> LifeValues { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
