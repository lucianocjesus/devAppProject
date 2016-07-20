using System;
using System.Collections.Generic;

namespace devAppProject.Banco.Models
{
    public partial class PerfilUsuario
    {
        public PerfilUsuario()
        {
            this.Usuarios = new List<Usuario>();
        }

        public int Id { get; set; }
        public int Tipo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
