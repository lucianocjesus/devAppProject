using System;
using System.Collections.Generic;
using devAppProject.DataEF;
using devAppProject.Domain.Contracts.Repositories;
using devAppProject.Domain.Contracts.Services;
using devAppProject.Domain.Models;

namespace devAppProject.Business
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService()
        {
            _repository = new UsuarioData();
        }
        
        public Usuario GetId(int id)
        {
            var usuario = _repository.Get(id);
            return usuario;
        }

        public Usuario GetCodigo(string codigo)
        {
            var usuario = _repository.GetCodigo(codigo);
            return usuario;
        }

        public Usuario GetNome(string nome)
        {
            var usuario = _repository.GetNome(nome);
            return usuario;
        }

        public Usuario GetEmail(string email)
        {
            var usuario = _repository.GetEmail(email);
            return usuario;
        }

        public List<Usuario> Get()
        {
            return _repository.Get();
        }

        public void Create(Usuario usuario)
        {
            var hasUser = _repository.GetEmail(usuario.Email);
            if (hasUser != null)
                throw new Exception("Já existe um cadastro realizado com este mesmo email.");

            var user = new Usuario(usuario.Codigo, usuario.Email);
            user.SetSenha(usuario.Senha);
            //user.Valida();
            _repository.Create(usuario);
        }

        public void Update(Usuario usuario)
        {
            var user = new Usuario(usuario.Codigo, usuario.Email);
            //user.SetSenha(usuario.Senha);
            //user.Valida();
            _repository.Update(usuario);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Usuario Authenticate(string email, string senha)
        {
            var usuario = _repository.GetEmail(email);
            if (usuario.Senha != senha)
                throw new Exception("Usuario ou senha invalida.");

            return usuario;
        }

        public void ChangePassword(string email, string senha, string novaSenha, string confirmaNovaSenha)
        {
            var usuario = Authenticate(email, senha);
            usuario.SetSenha(senha);
            usuario.Valida();

            _repository.Update(usuario);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
