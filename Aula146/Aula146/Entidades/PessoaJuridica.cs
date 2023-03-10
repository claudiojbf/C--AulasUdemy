
namespace Aula146.Entidades
{
    internal class PessoaJuridica : Contribuente
    {

        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios) : base(nome, rendaAnual)
        {
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public override double Imposto()
        {
            if (NumeroDeFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
