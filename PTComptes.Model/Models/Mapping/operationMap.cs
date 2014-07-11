using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PTComptes.Model.Models.Mapping
{
    public class OperationMap : EntityTypeConfiguration<Operation>
    {
        public OperationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Libelle)
                .IsFixedLength()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Operations");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Montant).HasColumnName("Montant");
            this.Property(t => t.Libelle).HasColumnName("Libelle");
            this.Property(t => t.CategorieId).HasColumnName("CategorieId");
            this.Property(t => t.TiersId).HasColumnName("TiersId");

            // Relationships
            this.HasRequired(t => t.Category)
                .WithMany(t => t.Operations)
                .HasForeignKey(d => d.CategorieId);
            this.HasRequired(t => t.Recipient)
                .WithMany(t => t.Operations)
                .HasForeignKey(d => d.TiersId);

        }
    }
}
