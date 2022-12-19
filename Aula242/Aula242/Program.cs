using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Aula242.Entities;
using System.Runtime.InteropServices;

namespace Aula242
{
    class Prograns
    {
        static void Main(string[] args) 
        {
            List<Funcionarios> funcinarios = new List<Funcionarios>();
            Console.WriteLine("Digite o caminho do arquivo: ");
            string path = Console.ReadLine();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    string email = line[1];
                    double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
                    Console.WriteLine(name+","+email+","+salary);
                    funcinarios.Add(new Funcionarios(name, email, salary));
                }
            }
            Console.WriteLine("Valor fornecido: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var r1 = funcinarios.Where(p => p.Salary > value).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine("Emails");
            foreach (string e in r1)
            {
                Console.WriteLine(e);
            }
            var sum = funcinarios.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Soama dos salarios com letra 'M' : " + sum.ToString("f2", CultureInfo.InvariantCulture));
        }
        
    }
}