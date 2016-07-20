using System;
using System.Collections.Generic;

namespace devAppProject.Map.Models
{
    public partial class Endereço
    {
        public int Id { get; set; }
        public Nullable<int> Id_Usuario { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public Nullable<int> Id_Cidade { get; set; }
        public Nullable<int> Id_Estado { get; set; }
    }
}
