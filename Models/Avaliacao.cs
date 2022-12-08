using System;
using System.Collections.Generic;

namespace ProjetoIntegradorFinal.Models
{
    public partial class Avaliacao
    {
        public string CNomeDisci { get; set; } = null!;
        public string? CMsg { get; set; }
        public int? INota { get; set; }
    }
}
