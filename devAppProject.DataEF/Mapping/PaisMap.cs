using System.Data.Entity.ModelConfiguration;
using devAppProject.Domain.Models;

namespace devAppProject.DataEF.Mapping
{
    public class PaisMap : EntityTypeConfiguration<Pais>
    {
        public PaisMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome).IsRequired().HasMaxLength(50);
            this.Property(t => t.Sigla).IsRequired().HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Pais");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Sigla).HasColumnName("Sigla");
        }
    }
}
