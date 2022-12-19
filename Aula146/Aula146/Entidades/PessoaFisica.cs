
namespace Aula146.Entidades
{
    internal class PessoaFisica : Contribuente
    {
        public double GastosComSaude;

        public PessoaFisica()
        { 
        }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double Imposto()
        {
            if (RendaAnual < 20000.00)
            {
                return (RendaAnual * 0.15) - (GastosComSaude * 0.50);
            }
            else 
            {
                return (RendaAnual * 0.25) - (GastosComSaude * 0.50);
            }
        }
    }
}
