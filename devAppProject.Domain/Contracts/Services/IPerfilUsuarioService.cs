using System;
using devAppProject.Domain.Models;

namespace devAppProject.Domain.Contracts.Services
{
    public interface IPerfilUsuarioService : IDisposable
    {
        PerfilUsuario Get(int id);
        void Create(PerfilUsuario perfilUsuario);
    }
}
