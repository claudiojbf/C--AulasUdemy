using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula220.Entities
{
    internal class LogService
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }

        public LogService(string nome, DateTime data)
        {
            Nome = nome;
            Data = data;
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogService))
            {
                return false;
            }
            LogService other = obj as LogService;
            return Nome.Equals(other.Nome);
        }
    }
}
