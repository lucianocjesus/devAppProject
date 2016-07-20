using System.Data.Entity.ModelConfiguration;

namespace devAppProject.Banco.Models.Mapping
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
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
            this.ToTable("Endereco");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
            this.Property(t => t.IdCidade).HasColumnName("IdCidade");
            this.Property(t => t.IdEstado).HasColumnName("IdEstado");
            this.Property(t => t.IdTipo).HasColumnName("IdTipo");
            this.Property(t => t.Logradouro).HasColumnName("Logradouro");
            this.Property(t => t.Bairro).HasColumnName("Bairro");
            this.Property(t => t.Cep).HasColumnName("Cep");

            // Relationships
            this.HasRequired(t => t.TipoEndereco)
                .WithMany(t => t.Enderecoes)
                .HasForeignKey(d => d.IdTipo);

        }
    }
}
