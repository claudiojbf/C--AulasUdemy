using System;
using System.IO;
using Aula220.Entities;
using System.Collections.Generic;
namespace Aula220
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogService> logs = new HashSet<LogService>();
            Console.WriteLine("Entre com o caminho do arquivo: ");
            string path = Console.ReadLine();
            try 
            {
                using (StreamReader sr = File.OpenText(path)) 
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        logs.Add(new LogService(line[0], DateTime.Parse(line[1])));
                    }
                }
                Console.WriteLine("Quantidade de usuarios " + logs.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}