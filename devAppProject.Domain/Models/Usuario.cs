using System;
using System.Collections.Generic;
using devAppProject.Common.Validation;

namespace devAppProject.Domain.Models
{
    public class Usuario
    {
        protected Usuario() { }
        public Usuario(string codigo, string email)
        {
            Codigo = codigo;
            Email = email;
            
        }
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
        public DateTime Data { get; set; }
        public PerfilUsuario PerfilUsuarios { get; set; }
        
        public void SetSenha(string senha)
        {
            AssertionConcern.AssertArgumentNotNull(senha,"Senha Invalida.");
            AssertionConcern.AssertArgumentLength(senha, 6, 20, "Senha Invalida.");
            Senha = Senha;
        }

        public void Valida()
        {
            AssertionConcern.AssertArgumentLength(this.Nome, 3, 250, "Usuario Invalido.");
            EmailAssertionConcern.AssertIsValid(this.Email);
            PasswordAssertionConcern.AssertIsValid(this.Senha);
        }
    }
}
