using System;
using devAppProject.DataEF;
using devAppProject.Domain.Contracts.Repositories;
using devAppProject.Domain.Contracts.Services;
using devAppProject.Domain.Models;

namespace devAppProject.Business
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _repository;

        public EnderecoService()
        {
            _repository = new EnderecoData();
        }

        public Endereco Get(int id)
        {
            try
            {
                return _repository.Get(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " - " + ex.StackTrace);
            }
        }

        public Endereco GetIdUsuario(int idUsuario)
        {
            try
            {
                return _repository.GetIdUsuario(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " - " + ex.StackTrace);
            }
        }

        public void Create(Endereco endereco)
        {

            var hasAddress = Get(endereco.IdUsuario);
            if (hasAddress!=null)
                throw new Exception("Já existe endereço cadastrado para este usuario.");
        }

        public void Update(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
