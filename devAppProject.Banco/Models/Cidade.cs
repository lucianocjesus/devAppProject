using System;
using System.Collections.Generic;

namespace devAppProject.Banco.Models
{
    public partial class Cidade
    {
        public int Id { get; set; }
        public int IdEstado { get; set; }
        public string Nome { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
