using System.Collections.Generic;

namespace Aula208.Entities
{
    internal class Contrato
    {
        public int NumeroDeContrato { get; private set; }
        public DateTime DataDoContrato { get; private set; }
        public double ValorDoContrato { get; private set; }

        public List<Parcela> Parcelas = new List<Parcela>();

        public Contrato(int numeroDeContrato, DateTime dataDoContrato, double valorDoContrato)
        {
            NumeroDeContrato = numeroDeContrato;
            DataDoContrato = dataDoContrato;
            ValorDoContrato = valorDoContrato;
        }
    }
}
