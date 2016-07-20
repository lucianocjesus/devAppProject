using System.Data.Entity.ModelConfiguration;
using devAppProject.Domain.Models;

namespace devAppProject.DataEF.Mapping
{
    public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome).IsRequired().HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("Cidade");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdEstado).HasColumnName("IdEstado");
            this.Property(t => t.Nome).HasColumnName("Nome");

            // Relationships
            this.HasRequired(t => t.Estado)
                .WithMany(t => t.Cidades)
                .HasForeignKey(d => d.IdEstado);
            
        }
    }
}
