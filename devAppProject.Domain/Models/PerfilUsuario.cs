using System.Collections.Generic;

namespace devAppProject.Domain.Models
{
    public class PerfilUsuario
    {
        public PerfilUsuario()
        {
            Usuarios = new List<Usuario>();
        }
        public int Id { get; set; }
        public int Tipo { get; set; }
        public string Descricao { get; set; }
        public List<Usuario> Usuarios { get; set; }
        
    }
}
