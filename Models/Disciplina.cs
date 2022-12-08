using System;
using System.Collections.Generic;

namespace ProjetoIntegradorFinal.Models
{
    public partial class Disciplina
    {
        public Disciplina()
        {
            Avaliacaos = new HashSet<Avaliacao>();
        }

        public int NCodDisci { get; set; }
        public string? CNomeDisci { get; set; }
        public string? CHorasDisci { get; set; }

        public virtual ICollection<Avaliacao> Avaliacaos { get; set; }
    }
}
