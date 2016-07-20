using System;
using devAppProject.DataEF;
using devAppProject.Domain.Contracts.Repositories;
using devAppProject.Domain.Contracts.Services;
using devAppProject.Domain.Models;

namespace devAppProject.Business
{
    public class PerfilUsuarioService : IPerfilUsuarioService
    {
        private readonly IPerfilUsuarioRepository _repository;
        public PerfilUsuarioService()
        {
            _repository = new PerfilUsuarioData();
        }

        public PerfilUsuario Get(int id)
        {
            var perfilUsuario = _repository.Get(id);
            return perfilUsuario;
        }

        public void Create(PerfilUsuario perfilUsuario)
        {
            var hasProfile = _repository.GetDescription(perfilUsuario.Descricao);
            if (hasProfile!=null)
                throw new Exception("Já existe um cadastro realizado com este Perfil.");

            _repository.Create(perfilUsuario);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
