using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using PTComptes.Model.Models.Mapping;

namespace PTComptes.Model.Models
{
    public partial class mainContext : DbContext
    {
        static mainContext()
        {
            Database.SetInitializer<mainContext>(null);
        }

        public mainContext()
            : base("Name=mainContext")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Recipient> Recipients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new OperationMap());
            modelBuilder.Configurations.Add(new RecipientMap());
        }
    }
}
