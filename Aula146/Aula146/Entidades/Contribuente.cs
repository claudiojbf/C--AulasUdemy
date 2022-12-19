
namespace Aula146.Entidades
{
    internal abstract class Contribuente
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Contribuente()
        {
        }

        public Contribuente(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
    }
}
