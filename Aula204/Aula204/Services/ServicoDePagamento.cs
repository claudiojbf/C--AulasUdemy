using Aula204.Entities;

namespace Aula204.Services
{
    internal class ServicoDePagamento
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private ITaxaDeServico _taxaDeServico;

        public ServicoDePagamento(double precoPorHora, double precoPorDia, ITaxaDeServico taxa)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaDeServico = taxa;
        }

        public void ProcessandoNota(AluguelDoCarro aluguel)
        {
            TimeSpan duracao = aluguel.DataDevolucao.Subtract(aluguel.DataDeInicio);
            double PagamentoBase = 0.0;
            if (duracao.TotalHours <= 12.0)
            {
                PagamentoBase = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                PagamentoBase = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _taxaDeServico.Taxa(PagamentoBase);

            aluguel.Nota = new Nota(PagamentoBase, taxa);
        }
    }
}
