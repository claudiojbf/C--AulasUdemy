using System;
using System.Globalization;
using Aula204.Entities;
using Aula204.Services;
namespace Aula204
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do Aluguel: ");
            Console.Write("Modelo do Carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Pego (dd/MM/yyyy hh:mm): ");
            DateTime dataDeInicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Retorno (dd/MM/yyyy hh:mm): ");
            DateTime dataDeDevolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Preco por hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Preco por dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            AluguelDoCarro aluguel = new AluguelDoCarro(dataDeInicio, dataDeDevolucao, new Veiculo(modelo));

            ServicoDePagamento servicoDePagamento = new ServicoDePagamento(hora, dia, new TaxaDeServicoBrasil());

            servicoDePagamento.ProcessandoNota(aluguel);

            Console.WriteLine("Nota:");
            Console.WriteLine(aluguel.Nota);
        }
    }
}