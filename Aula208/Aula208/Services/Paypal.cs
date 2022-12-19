using Aula208.Entities;

namespace Aula208.Services
{
    internal class Paypal : IServicoDePagamento
    {
        public double TaxaDePagamento(double valor) 
        {
            return valor * 0.02;
        }

        public double ValorParcela(double valor, int mes)
        {
            double juros = (valor * 0.01) * mes;
            double montante = valor + juros;
            return montante + TaxaDePagamento(montante);
        }
        //public void valorDaParcela(Contrato contrato, int numeroDeMeses)
        //{
        //    double valor_inicial = contrato.ValorDoContrato / numeroDeMeses;
        //    for (int i = 1; i <= numeroDeMeses; i++)
        //    {
        //        double juros = (valor_inicial + (valor_inicial * 0.01)) * numeroDeMeses;
        //        double valor_final = (valor_inicial + (juros * 0.02));
        //        contrato.Parcelas.Add(new Parcela(contrato.DataDoContrato.AddMonths(i), valor_final));
        //    }
        //}
    }
}
