using System;
using System.Collections.Generic;

namespace devAppProject.Map.Models
{
    public partial class Estado
    {
        public Estado()
        {
            this.Cidades = new List<Cidade>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public int Id_Pais { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
        public virtual Pai Pai { get; set; }
    }
}
