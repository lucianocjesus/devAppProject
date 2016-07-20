using System;
using System.Collections.Generic;
using devAppProject.Domain.Models;

namespace devAppProject.Domain.Contracts.Services
{
    public interface IUsuarioService : IDisposable
    {
        Usuario GetId(int id);
        Usuario GetCodigo(string codigo);
        Usuario GetNome(string nome);
        Usuario GetEmail(string email);
        List<Usuario> Get();
        void Create(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
        Usuario Authenticate(string email, string senha);
        void ChangePassword(string email, string senha, string novaSenha, string confirmaNovaSenha);
    }
}
