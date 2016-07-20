using System;
using System.Collections.Generic;
using devAppProject.Domain.Models;

namespace devAppProject.Domain.Contracts.Repositories
{
    public interface IEnderecoRepository : IDisposable
    {
        Endereco Get(int id);
        Endereco GetIdUsuario(int idUsuario);
        Endereco GetTipo(int id, int idUsuario, int tipo);
        List<Endereco> Get();
        void Create(Endereco endereco);
        void Update(Endereco endereco);
        void Delete(int id);
    }
}
