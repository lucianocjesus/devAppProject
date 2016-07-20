using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using devAppProject.Domain.Models;

namespace devAppProject.Domain.Contracts.Services
{
    public interface IEnderecoService : IDisposable
    {
        Endereco Get(int id);
        Endereco GetIdUsuario(int idUsuario);
        void Create(Endereco endereco);
        void Update(Endereco endereco);
        void Delete(int id);
    }
}
