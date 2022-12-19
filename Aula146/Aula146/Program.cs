using System.Globalization;
using System.Collections.Generic;

using Aula146.Entidades;

namespace Aula146
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero de contribuentes: ");
            int n = int.Parse(Console.ReadLine());

            List<Contribuente> contribuentes = new List<Contribuente>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Contribuente #{i} dados: ");
                Console.Write("Pessoa Fisica ou Juridica (f/j): ");
                string ch = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == "j")
                {
                    Console.Write("Numero de Funcionarios: ");
                    int numeroDeFuncionarios = int.Parse(Console.ReadLine());
                    contribuentes.Add(new PessoaJuridica(nome, rendaAnual, numeroDeFuncionarios));
                }
                else if (ch == "f")
                {
                    Console.Write("Gastos com saude: ");
                    double gastosComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contribuentes.Add(new PessoaFisica(nome, rendaAnual, gastosComSaude));
                }
            }
            double total = 0;

            Console.WriteLine("Contribuentes: ");
            foreach (Contribuente c in contribuentes)
            {
                Console.WriteLine(c.Nome + ": $ " + c.Imposto().ToString("F2", CultureInfo.InvariantCulture));
                total += c.Imposto();
            }
            Console.WriteLine("Total Arecadado: $ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}