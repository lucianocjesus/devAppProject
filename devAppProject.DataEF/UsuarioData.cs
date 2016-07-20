using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using devAppProject.Common.Configuration;
using devAppProject.DataEF.DataContext;
using devAppProject.Domain.Contracts.Repositories;
using devAppProject.Domain.Models;

namespace devAppProject.DataEF
{
    public class UsuarioData : IUsuarioRepository
    {
        private readonly AppDataContext _context;
        public UsuarioData()
        {
            this._context = new AppDataContext();
        }

        public Usuario Get(int id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public Usuario GetCodigo(string codigo)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Codigo == codigo);
        }

        public Usuario GetNome(string nome)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Nome.Contains(nome));
        }

        public Usuario GetEmail(string email)
        {
            try
            {
                return _context.Usuarios.FirstOrDefault(i => i.Email == email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Usuario> Get()
        {
            try
            {
                return _context.Usuarios.OrderBy(p => p.Nome).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Create(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            try
            {
                _context.Entry(usuario).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            _context.Usuarios.Remove(Get(id));
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
