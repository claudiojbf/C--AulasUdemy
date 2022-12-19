using System.Collections.Generic;
using System.Globalization;

namespace Aula78
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.Write("Quantos funcionarios você ira adicionar?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionario "+ (i+1));
                Console.Write("Id: ");
                int id_ = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios.Add(new Funcionario(id_, nome, salario));
            }

            Console.Write("Digite o id do funcionario que deseja dar um aumento: ");
            int id = int.Parse(Console.ReadLine());

            foreach (Funcionario funcionario in funcionarios)
            {
                int r = 0;
                if(funcionario.Id == id)
                {
                    Console.Write("Entre com a porcentagem: ");
                    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    funcionario.AumentoSalarial(porcentagem);
                    r -= 1;
                }
                else 
                {
                    r += 1;
                }

                if (r == funcionarios.Count)
                {
                    Console.WriteLine("Id do Funcionario não encontrado.");
                }
            }

            Console.WriteLine("Atualização da Lista de Funcionarios: ");
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }


        }
    }
}