using System.Globalization;
namespace Aula78
{
    internal class Funcionario
    {
        public int Id {get; private set;}
        public string Nome {get;set;}
        public double Salario { get; private set;}

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalarial(double porcentagem)
        {
            double valaor_aumento = Salario * (porcentagem / 100);
            Salario += valaor_aumento;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
