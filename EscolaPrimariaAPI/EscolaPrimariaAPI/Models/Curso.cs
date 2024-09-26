using System;
using System.Collections.Generic;

namespace EscolaPrimariaAPI.Models
{
    public partial class Curso
    {
        public Curso()
        {
            IdAlunos = new HashSet<Aluno>();
        }

        public int IdCurso { get; set; }
        public string Nome { get; set; } = null!;
        public int? IdProfessor { get; set; }

        public virtual Professor? IdProfessorNavigation { get; set; }

        public virtual ICollection<Aluno> IdAlunos { get; set; }
    }
}
