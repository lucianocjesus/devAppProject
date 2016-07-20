﻿using System.Collections.Generic;

namespace devAppProject.Domain.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public virtual ICollection<Estado> Estados { get; set; }

    }
}
