using System.Data.Entity.ModelConfiguration;
using devAppProject.Domain.Models;

namespace devAppProject.DataEF.Mapping
{
    public class TipoEnderecoMap : EntityTypeConfiguration<TipoEndereco>
    {
        public TipoEnderecoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao).IsRequired().HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TipoEndereco");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
        
    }
}
