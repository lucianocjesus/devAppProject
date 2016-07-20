using System.Data.Entity.ModelConfiguration;
using devAppProject.Domain.Models;

namespace devAppProject.DataEF.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Codigo).IsRequired().HasMaxLength(50);
            this.Property(t => t.Nome).IsRequired().HasMaxLength(50);
            this.Property(t => t.Sobrenome).HasMaxLength(50);
            this.Property(t => t.Senha).IsRequired().HasMaxLength(50);
            this.Property(t => t.Rg);
            this.Property(t => t.Cpf);
            this.Property(t => t.Email).IsRequired().HasMaxLength(150);
            this.Property(t => t.Telefone);
            this.Property(t => t.Celular);
            this.Property(t => t.Facebook).HasMaxLength(200);
            this.Property(t => t.Twitter).HasMaxLength(50);
            this.Property(t => t.LinkedIn).HasMaxLength(200);
            this.Property(t => t.Status);
            this.Property(t => t.Data);


            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdPerfil).HasColumnName("IdPerfil");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Sobrenome).HasColumnName("Sobrenome");
            this.Property(t => t.Senha).HasColumnName("Senha");
            this.Property(t => t.Rg).HasColumnName("Rg");
            this.Property(t => t.Cpf).HasColumnName("Cpf");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Telefone).HasColumnName("Telefone");
            this.Property(t => t.Celular).HasColumnName("Celular");
            this.Property(t => t.Facebook).HasColumnName("Facebook");
            this.Property(t => t.Twitter).HasColumnName("Twitter");
            this.Property(t => t.LinkedIn).HasColumnName("LinkedIn");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Data).HasColumnName("Data");

            // Relationships
            this.HasRequired(t => t.PerfilUsuarios)
                .WithMany(t => t.Usuarios)
                .HasForeignKey(d => d.IdPerfil);

        }
    }
}
