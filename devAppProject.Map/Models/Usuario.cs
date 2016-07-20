using System;
using System.Collections.Generic;

namespace devAppProject.Map.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            this.PerfilUsuarios = new List<PerfilUsuario>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Senha { get; set; }
        public decimal Rg { get; set; }
        public decimal Cpf { get; set; }
        public string Email { get; set; }
        public decimal? Telefone { get; set; }
        public decimal? Celular { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public bool Status { get; set; }
        public DateTime Cadastro { get; set; }
        public virtual ICollection<PerfilUsuario> PerfilUsuarios { get; set; }
    }
}
