using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using devAppProject.DataEF.Mapping;
using devAppProject.Domain.Models;

namespace devAppProject.DataEF.DataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            : base("AppCnnStr")
        {
            //Database.SetInitializer(new AppDataContextInitializer());

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuarios { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<TipoEndereco> TipoEnderecos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new PerfilUsuarioMap());
            modelBuilder.Configurations.Add(new PaisMap());
            modelBuilder.Configurations.Add(new EstadoMap());
            modelBuilder.Configurations.Add(new CidadeMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new TipoEnderecoMap());
        }

    }

    public class AppDataContextInitializer : DropCreateDatabaseAlways<AppDataContext>
    {
        protected override void Seed(AppDataContext context)
        {
            //#region "Tabela de Usuario"
            //var usuario = new Usuario("luciano", "lucianocjesus@gmail.com")
            //{
            //    Id = 1,
            //    Nome = "Luciano Carlos",
            //    Sobrenome = "Jesus",
            //    Rg = 321907760,
            //    Cpf = 28156649842,
            //    Status = 1,
            //    Data = DateTime.Now
            //};
            //usuario.SetSenha("290178");
            //#endregion
            //context.Usuarios.Add(usuario);

            //#region "Tabela de PerfilUsuario"
            //var perfilUsuario = new PerfilUsuario
            //{
            //    Id = 1,
            //    Tipo = 1,
            //    Descricao = "Administrador",
            //    IdUsuario = { Id = usuario.Id }
            //};
            //#endregion
            //context.PerfilUsuarios.Add(perfilUsuario);

            //var pais = new Pais { Id = 1, Nome = "Brasil", Sigla = "BR" };
            //context.Paises.Add(pais);

            //var estados = new Estado { Id = 26, Nome = "São Paulo", Uf = "SP", IdPais = { Id = pais.Id } };
            //context.Paises.Add(pais);

            //var cidades = new Cidade { Id = 4925, Nome = "Hortolândia", IdEstado = { Id = estados.Id } };
            //context.Cidades.Add(cidades);

            //#region "Tabela de Endereço"
            //var enderecos = new Endereco
            //{
            //    Id = 1,
            //    IdUsuario = { Id = usuario.Id },
            //    Logradouro = "Rua Jequitibas, Numero 267",
            //    Bairro = "Parque dos Pinheiros",
            //    Cep = "13184564",
            //    IdCidade = { Id = cidades.Id },
            //    IdEstado = { Id = estados.Id }
            //};
            //#endregion
            //context.Enderecos.Add(enderecos);
            
            base.Seed(context);
        }
    }
}
