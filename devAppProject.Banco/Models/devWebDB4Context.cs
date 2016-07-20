using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using devAppProject.Banco.Models.Mapping;

namespace devAppProject.Banco.Models
{
    public partial class devWebDB4Context : DbContext
    {
        static devWebDB4Context()
        {
            Database.SetInitializer<devWebDB4Context>(null);
        }

        public devWebDB4Context()
            : base("Name=devWebDB4Context")
        {
        }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Endereco> Enderecoes { get; set; }
        public DbSet<Estado> Estadoes { get; set; }
        public DbSet<Pai> Pais { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuarios { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TipoEndereco> TipoEnderecoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CidadeMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new EstadoMap());
            modelBuilder.Configurations.Add(new PaiMap());
            modelBuilder.Configurations.Add(new PerfilUsuarioMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TipoEnderecoMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}
