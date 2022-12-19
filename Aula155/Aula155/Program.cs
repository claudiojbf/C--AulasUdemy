using System.Globalization;
using Aula155.Entidade.Excecoes;
using Aula155.Entidade;

namespace Aula155
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da conta:");
                Console.Write("Numero: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Valor Inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de Saque: ");
                double limiteDeSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ContaBancaria contaBancaria = new ContaBancaria(numero, nome, saldo, limiteDeSaque);
                Console.Write("Entre com o valor que deseja sacar: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria.Saque(valor);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro de saque: " + e.Message);
            }
        }
    }
}