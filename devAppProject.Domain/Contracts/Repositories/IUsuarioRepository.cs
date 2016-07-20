using System;
using System.Collections.Generic;
using devAppProject.Domain.Models;

namespace devAppProject.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository : IDisposable
    {
        Usuario Get(int id);
        Usuario GetCodigo(string codigo);
        Usuario GetNome(string nome);
        Usuario GetEmail(string email);
        List<Usuario> Get();
        void Create(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
    }
}
