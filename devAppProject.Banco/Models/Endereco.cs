using System;
using System.Collections.Generic;

namespace devAppProject.Banco.Models
{
    public partial class Endereco
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdCidade { get; set; }
        public int IdEstado { get; set; }
        public int IdTipo { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public virtual TipoEndereco TipoEndereco { get; set; }
    }
}
