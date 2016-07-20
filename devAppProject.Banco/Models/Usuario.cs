using System;
using System.Collections.Generic;

namespace devAppProject.Banco.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public int IdPerfil { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Senha { get; set; }
        public long Rg { get; set; }
        public long Cpf { get; set; }
        public string Email { get; set; }
        public long Telefone { get; set; }
        public long Celular { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public int Status { get; set; }
        public System.DateTime Data { get; set; }
        public virtual PerfilUsuario PerfilUsuario { get; set; }
    }
}
