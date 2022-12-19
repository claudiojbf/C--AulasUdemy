namespace Aula204.Entities
{
    internal class AluguelDoCarro
    {
        public DateTime DataDeInicio { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Veiculo Veiculo { get; set; }
        public Nota Nota { get; set; }

        public AluguelDoCarro(DateTime dataDeInicio, DateTime dataDevolucao, Veiculo veiculo)
        {
            DataDeInicio = dataDeInicio;
            DataDevolucao = dataDevolucao;
            Veiculo = veiculo;
            Nota = null;
        }
    }
}
