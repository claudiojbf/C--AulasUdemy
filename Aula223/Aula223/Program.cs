using System.IO;
using System.Collections.Generic;
namespace Aula223
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho do arquivo: ");
            string path = Console.ReadLine();
            Dictionary<string, int> votos = new Dictionary<string, int>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidato = line[0];
                        int voto = int.Parse(line[1]);
                        if (votos.ContainsKey(candidato))
                        {
                            votos[candidato] += voto;
                        }
                        else
                        {
                            votos[candidato] = voto;
                        }
                    }
                    foreach (KeyValuePair<string, int> candidato in votos)
                    {
                        Console.WriteLine(candidato.Key + " : " + candidato.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro:");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}