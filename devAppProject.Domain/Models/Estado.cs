using System.Collections.Generic;

namespace devAppProject.Domain.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public int IdPais { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public Pais Pais { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
