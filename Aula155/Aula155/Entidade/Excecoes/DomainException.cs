using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula155.Entidade.Excecoes
{
    internal class DomainException : ApplicationException 
    {
        public DomainException(string mensagem) : base(mensagem)
        { 
        }
    }
}
