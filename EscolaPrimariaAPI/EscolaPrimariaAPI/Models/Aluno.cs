using System;
using System.Collections.Generic;

namespace EscolaPrimariaAPI.Models
{
    public partial class Aluno
    {
        public Aluno()
        {
            IdCursos = new HashSet<Curso>();
        }

        public int IdAluno { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public long? Cpf { get; set; }
        public string? Endereco { get; set; }
        public int? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<Curso> IdCursos { get; set; }
    }
}
