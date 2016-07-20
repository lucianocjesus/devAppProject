using System;
using System.Collections.Generic;

namespace devAppProject.Map.Models
{
    public partial class PerfilUsuario
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public int Tipo { get; set; }
        public string Descricao { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
