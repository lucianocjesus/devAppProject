using System.Data.Entity.ModelConfiguration;
using devAppProject.Domain.Models;

namespace devAppProject.DataEF.Mapping
{
    public class EstadoMap : EntityTypeConfiguration<Estado>
    {
        public EstadoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome).IsRequired().HasMaxLength(80);
            this.Property(t => t.Uf).IsRequired().HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("Estado");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdPais).HasColumnName("IdPais");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Uf).HasColumnName("Uf");

            // Relationships
            HasRequired(t => t.Pais).WithMany(t => t.Estados).HasForeignKey(t => t.IdPais);
        }
    }
}
