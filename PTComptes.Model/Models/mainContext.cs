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

        public DbSet<category> categories { get; set; }
        public DbSet<operation> operations { get; set; }
        public DbSet<tier> tiers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new categoryMap());
            modelBuilder.Configurations.Add(new operationMap());
            modelBuilder.Configurations.Add(new tierMap());
        }
    }
}
