using System;
using System.Collections.Generic;

namespace devAppProject.Banco.Models
{
    public partial class TipoEndereco
    {
        public TipoEndereco()
        {
            this.Enderecoes = new List<Endereco>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Endereco> Enderecoes { get; set; }
    }
}
