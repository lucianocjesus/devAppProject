using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace devAppProject.Map.Models.Mapping
{
    public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("Cidade");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Id_Estado).HasColumnName("Id_Estado");

            // Relationships
            this.HasRequired(t => t.Estado)
                .WithMany(t => t.Cidades)
                .HasForeignKey(d => d.Id_Estado);

        }
    }
}
