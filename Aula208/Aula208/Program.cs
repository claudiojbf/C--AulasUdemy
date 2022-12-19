using System.Globalization;

using Aula208.Entities;
using Aula208.Services;

namespace Aula208
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime dataDeInicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do Contrato: ");
            double valorDoContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contrato contrato = new Contrato(numero,dataDeInicio,valorDoContrato);
            Console.Write("Entre com o numero de parcelas");
            int parcelas = int.Parse(Console.ReadLine());

            ServicoDeContrato servico = new ServicoDeContrato();
            
            servico.ProcessarContrato(contrato,parcelas, new Paypal());

      

            Console.WriteLine("Parcelas: ");
            foreach (Parcela p in contrato.Parcelas)
            {
                Console.WriteLine(p);
            }
        }
    }
}