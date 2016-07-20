using System;
using System.Collections.Generic;

namespace devAppProject.Map.Models
{
    public partial class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Id_Estado { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
