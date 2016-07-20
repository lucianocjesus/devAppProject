using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using devAppProject.Map.Models.Mapping;

namespace devAppProject.Map.Models
{
    public partial class devWebDBContext : DbContext
    {
        static devWebDBContext()
        {
            Database.SetInitializer<devWebDBContext>(null);
        }

        public devWebDBContext()
            : base("Name=devWebDBContext")
        {
        }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Endereço> Endereço { get; set; }
        public DbSet<Estado> Estadoes { get; set; }
        public DbSet<Pai> Pais { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuarios { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CidadeMap());
            modelBuilder.Configurations.Add(new EndereçoMap());
            modelBuilder.Configurations.Add(new EstadoMap());
            modelBuilder.Configurations.Add(new PaiMap());
            modelBuilder.Configurations.Add(new PerfilUsuarioMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}
