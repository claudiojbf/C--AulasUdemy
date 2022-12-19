using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula221.Entities
{
    internal class Curso
    {
        public HashSet<Aluno> Alunos = new HashSet<Aluno>();

        public Curso()
        {
        }
    }
}
