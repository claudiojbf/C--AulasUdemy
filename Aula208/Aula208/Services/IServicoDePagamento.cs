using Aula208.Entities;
namespace Aula208.Services
{
    interface IServicoDePagamento
    {
        public double TaxaDePagamento(double valor);
        public double ValorParcela(double valor, int mes);
    }
}
