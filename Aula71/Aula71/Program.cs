using System.Globalization;

namespace Aula71
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] vect = new Quarto[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int num = int.Parse(Console.ReadLine());
                vect[num] = new Quarto(nome, email);
            }

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + " : " + vect[i].Nome + ", " + vect[i].Email);
                }
            }

        }
    }
}