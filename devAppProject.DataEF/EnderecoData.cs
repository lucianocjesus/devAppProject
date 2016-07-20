using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using devAppProject.DataEF.DataContext;
using devAppProject.Domain.Contracts.Repositories;
using devAppProject.Domain.Models;

namespace devAppProject.DataEF
{
    public class EnderecoData : IEnderecoRepository
    {
        private readonly AppDataContext _context;
        public EnderecoData()
        {
            _context = new AppDataContext();
        }

        public Endereco Get(int id)
        {
            try
            {
                return _context.Enderecos.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " - " + ex.StackTrace);
            }
            
        }

        public Endereco GetTipo(int id, int idUsuario, int tipo)
        {
            return _context.Enderecos.FirstOrDefault(x => x.Id == id && x.IdUsuario == idUsuario && x.IdTipo == tipo);
        }

        public Endereco GetIdUsuario(int idUsuario)
        {
            try
            {
                return _context.Enderecos.FirstOrDefault(x => x.IdUsuario == idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " - " + ex.StackTrace);
            }
            
        }

        public List<Endereco> Get()
        {
            try
            {
                return _context.Enderecos.OrderBy(x => x.Id).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " - " + ex.StackTrace);
            }
        }

        public void Create(Endereco endereco)
        {
            try
            {
                _context.Enderecos.Add(endereco);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " - " + ex.StackTrace);
            }
            
        }

        public void Update(Endereco endereco)
        {
            try
            {
                _context.Entry(endereco).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " - " + ex.StackTrace);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _context.Enderecos.Remove(Get(id));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " - " + ex.StackTrace);
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
