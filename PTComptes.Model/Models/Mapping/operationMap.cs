using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PTComptes.Model.Models.Mapping
{
    public class operationMap : EntityTypeConfiguration<operation>
    {
        public operationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Libelle)
                .IsFixedLength()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("operations");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Montant).HasColumnName("Montant");
            this.Property(t => t.Libelle).HasColumnName("Libelle");
            this.Property(t => t.CategorieId).HasColumnName("CategorieId");
            this.Property(t => t.TiersId).HasColumnName("TiersId");

            // Relationships
            this.HasRequired(t => t.category)
                .WithMany(t => t.operations)
                .HasForeignKey(d => d.CategorieId);
            this.HasRequired(t => t.tier)
                .WithMany(t => t.operations)
                .HasForeignKey(d => d.TiersId);

        }
    }
}
