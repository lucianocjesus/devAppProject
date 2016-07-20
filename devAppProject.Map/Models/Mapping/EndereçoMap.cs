using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace devAppProject.Map.Models.Mapping
{
    public class EndereçoMap : EntityTypeConfiguration<Endereço>
    {
        public EndereçoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Logradouro)
                .HasMaxLength(60);

            this.Property(t => t.Bairro)
                .HasMaxLength(50);

            this.Property(t => t.Cep)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Endereço");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Id_Usuario).HasColumnName("Id_Usuario");
            this.Property(t => t.Logradouro).HasColumnName("Logradouro");
            this.Property(t => t.Bairro).HasColumnName("Bairro");
            this.Property(t => t.Cep).HasColumnName("Cep");
            this.Property(t => t.Id_Cidade).HasColumnName("Id_Cidade");
            this.Property(t => t.Id_Estado).HasColumnName("Id_Estado");
        }
    }
}
