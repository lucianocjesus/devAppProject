using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace devAppProject.Map.Models.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Codigo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sobrenome)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Senha)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Facebook)
                .HasMaxLength(200);

            this.Property(t => t.Twitter)
                .HasMaxLength(50);

            this.Property(t => t.LinkedIn)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Sobrenome).HasColumnName("Sobrenome");
            this.Property(t => t.Senha).HasColumnName("Senha");
            this.Property(t => t.Rg).HasColumnName("RG");
            this.Property(t => t.Cpf).HasColumnName("CPF");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Telefone).HasColumnName("Telefone");
            this.Property(t => t.Celular).HasColumnName("Celular");
            this.Property(t => t.Facebook).HasColumnName("Facebook");
            this.Property(t => t.Twitter).HasColumnName("Twitter");
            this.Property(t => t.LinkedIn).HasColumnName("LinkedIn");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Cadastro).HasColumnName("Cadastro");
        }
    }
}
