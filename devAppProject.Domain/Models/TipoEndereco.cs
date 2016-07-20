using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devAppProject.Domain.Models
{
    public class TipoEndereco
    {
        public TipoEndereco()
        {
            Enderecos = new List<Endereco>();
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public IList<Endereco> Enderecos { get; set; }
    }
}
