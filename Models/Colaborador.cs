using System;
using System.Collections.Generic;

namespace ProjetoIntegradorFinal.Models
{
    public partial class Colaborador
    {
        public int NIdColab { get; set; }
        public string? CCpfColb { get; set; }
        public string? CNomeColab { get; set; }
        public bool? CCargoTutor { get; set; }
        public bool? CCargoProfessor { get; set; }
    }
}
