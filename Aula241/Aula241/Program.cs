using Aula241.entities;
using System.Globalization;
namespace Aula241
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho do arquivo: ");
            string path = Console.ReadLine();
            List<Products> list = new List<Products>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(",");
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Products(name, price));
                }
            }
            var r1 = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Avarega: " + r1.ToString("f2", CultureInfo.InvariantCulture));
            var r2 = list.Where(p => p.Price < r1).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string p in r2)
            {
                Console.WriteLine(p);
            }

        }
    }
}