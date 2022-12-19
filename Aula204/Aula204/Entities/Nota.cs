using System.Globalization;
namespace Aula204.Entities
{
    internal class Nota
    {
        public double PagamentoBase { get; set; }
        public double Taxa { get; set; }

        public Nota(double pagamentoBase, double taxa)
        {
            PagamentoBase = pagamentoBase;
            Taxa = taxa;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBase + Taxa; }
        }

        public override string ToString()
        {
            return "Pagamento base: " + PagamentoBase.ToString("F2", CultureInfo.InvariantCulture)
                +"\nTaxa: " + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                +"\nPagamento Total: " + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
