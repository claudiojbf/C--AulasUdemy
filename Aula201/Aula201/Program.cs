using Aula201.Entities;
using System.IO;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Aula201
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o caminho do arquivo");
            string pathFile = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(pathFile);
                string sourceFolderPath = Path.GetDirectoryName(pathFile);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\sumario.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Produto produto = new Produto(name, price, quantity);

                        sw.WriteLine(produto.Nome + "," + produto.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro:");
                Console.WriteLine(e.Message);
            }
        }
    }
}