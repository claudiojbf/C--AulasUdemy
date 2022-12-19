using System.Globalization;
namespace Aula208.Entities
{
    internal class Parcela
    {
        public DateTime DataDePagamento { get; set; }
        public double Valor { get; set; }

        public Parcela(DateTime dataDePagamento, double valor)
        {
            DataDePagamento = dataDePagamento;
            Valor = valor;
        }

        public override string ToString()
        {
            return DataDePagamento.ToString("dd/MM/yyyy") + " : $ " + Valor.ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
