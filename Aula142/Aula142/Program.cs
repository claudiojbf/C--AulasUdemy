using System.Globalization;
using System.Collections.Generic;

using Aula142.Entidades;

namespace Aula142
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero de produtos: ");
            int n = int.Parse(Console.ReadLine());
            List<Produto> produtos = new List<Produto>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Produto #{i} dados:");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                string ch = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == "c")
                {
                    produtos.Add(new Produto(nome, preco));
                }
                else if (ch == "u")
                {
                    Console.Write("Data de Fabricacão (DD/MM/YYYY): ");
                    DateTime dataDeFrabricacao = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoUsado(nome, preco, dataDeFrabricacao));
                }
                else if (ch == "i")
                {
                    Console.Write("Valor de importção: ");
                    double custoDeImportacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    produtos.Add(new ProdutoImportado(nome, preco, custoDeImportacao));
                }
            }
            Console.WriteLine("Etiquetas de Preço");
            foreach(Produto p in produtos)
            {
                Console.WriteLine(p.Etiqueta());
            }
        }
    }
}