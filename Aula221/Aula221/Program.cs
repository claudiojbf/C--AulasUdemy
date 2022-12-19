using Aula221.Entities;
namespace Aula221
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Curso A = new Curso();
            Curso B = new Curso();
            Curso C = new Curso();
            CadastroCurso(A);
            CadastroCurso(B);
            CadastroCurso(C);
            HashSet<Aluno> D = new HashSet<Aluno>(A.Alunos);
            D.UnionWith(B.Alunos);
            D.UnionWith(C.Alunos);

            Console.WriteLine("Numero de Alunos: " + D.Count);
        }

        public static void CadastroCurso(Curso c)
        {
            Console.WriteLine("Quantos estudastes tem no curso:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int cd = int.Parse(Console.ReadLine());
                c.Alunos.Add(new Aluno(cd));
            }
        }
    }
}