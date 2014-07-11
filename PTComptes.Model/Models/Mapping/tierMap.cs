using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PTComptes.Model.Models.Mapping
{
    public class tierMap : EntityTypeConfiguration<tier>
    {
        public tierMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Libelle)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tiers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Libelle).HasColumnName("Libelle");
        }
    }
}
