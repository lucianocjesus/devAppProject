using System;
using System.Collections.Generic;

namespace devAppProject.Banco.Models
{
    public partial class Estado
    {
        public Estado()
        {
            this.Cidades = new List<Cidade>();
        }

        public int Id { get; set; }
        public int IdPais { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
        public virtual Pai Pai { get; set; }
    }
}
