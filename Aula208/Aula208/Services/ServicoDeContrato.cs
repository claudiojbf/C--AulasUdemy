using Aula208.Entities;

namespace Aula208.Services
{
    internal class ServicoDeContrato
    {
        public void ProcessarContrato(Contrato contrato, int meses, IServicoDePagamento servico)
        {
            double valorInicial = contrato.ValorDoContrato / meses;
            Console.WriteLine(valorInicial);
            for (int i = 1; i <= meses; i++)
            {
                Parcela p = new Parcela(contrato.DataDoContrato.AddMonths(i), servico.ValorParcela(valorInicial, i));
                Console.WriteLine(servico.ValorParcela(valorInicial, i));
                contrato.Parcelas.Add(p);
            }
        }
    }
}
