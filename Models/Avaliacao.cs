using System;
using System.Collections.Generic;

namespace ProjetoIntegradorFinal.Models
{
    public partial class Avaliacao
    {
        public int IdAvaliacao { get; set; }
        public int? NCodDisci { get; set; }
        public int? NNotaAvalia { get; set; }
        public string? CComentario { get; set; }

        public virtual Disciplina? NCodDisciNavigation { get; set; }
    }
}
