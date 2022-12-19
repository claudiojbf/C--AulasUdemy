namespace Aula81
{
    class Progam
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] num = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(num[j]);
                }
            }

            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (numero == matriz[i, j])
                    {
                        Console.WriteLine("Position: " + i + " " + j);
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (j + 1 < n)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i + 1 < m)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}