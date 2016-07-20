using System.Data.Entity;
using System.Linq;
using devAppProject.DataEF.DataContext;
using devAppProject.Domain.Contracts.Repositories;
using devAppProject.Domain.Models;

namespace devAppProject.DataEF
{
    public class PerfilUsuarioData : IPerfilUsuarioRepository
    {
        private readonly AppDataContext _context;
        public PerfilUsuarioData()
        {
            _context = new AppDataContext();
        }
        public PerfilUsuario Get(int id)
        {
            return _context.PerfilUsuarios.FirstOrDefault(x => x.Id == id);
        }

        public PerfilUsuario GetDescription(string descricao)
        {
            return _context.PerfilUsuarios.FirstOrDefault(x => x.Descricao == descricao);
        }

        public void Create(PerfilUsuario perfilUsuario)
        {
            _context.PerfilUsuarios.Add(perfilUsuario);
            _context.SaveChanges();
        }

        public void Update(PerfilUsuario perfilUsuario)
        {
            _context.Entry(perfilUsuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.PerfilUsuarios.Remove(Get(id));
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
