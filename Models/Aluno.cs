using System;
using System.Collections.Generic;

namespace ProjetoIntegradorFinal.Models
{
    public partial class Aluno
    {
        public int NMatricula { get; set; }
        public string? CCpfAluno { get; set; }
        public string? CNomeAluno { get; set; }
        public DateOnly? DDataNasc { get; set; }
        public string? CFoneAluno { get; set; }
    }
}
