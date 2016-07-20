using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace devAppProject.Banco.Models.Mapping
{
    public class PerfilUsuarioMap : EntityTypeConfiguration<PerfilUsuario>
    {
        public PerfilUsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PerfilUsuario");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Tipo).HasColumnName("Tipo");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
    }
}
