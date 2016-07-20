using System;
using System.Collections.Generic;

namespace devAppProject.Banco.Models
{
    public partial class Pai
    {
        public Pai()
        {
            this.Estadoes = new List<Estado>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public virtual ICollection<Estado> Estadoes { get; set; }
    }
}
