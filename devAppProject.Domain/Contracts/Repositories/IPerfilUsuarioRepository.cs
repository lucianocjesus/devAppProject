using System;
using devAppProject.Domain.Models;

namespace devAppProject.Domain.Contracts.Repositories
{
    public interface IPerfilUsuarioRepository : IDisposable
    {
        PerfilUsuario Get(int id);
        PerfilUsuario GetDescription(string descricao);
        void Create(PerfilUsuario perfilUsuario);
        void Update(PerfilUsuario perfilUsuario);
        void Delete(int id);
    }
}
