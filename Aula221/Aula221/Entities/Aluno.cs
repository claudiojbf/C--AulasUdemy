namespace Aula221.Entities
{
    internal class Aluno
    {
        public int NumeroAluno { get; set; }

        public Aluno(int numero)
        {
            NumeroAluno = numero;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Aluno))
            {
                return false;
            }
            Aluno other = obj as Aluno;
            return NumeroAluno.Equals(other.NumeroAluno);
        }

        public override int GetHashCode()
        {
            return NumeroAluno.GetHashCode();
        }
    }
}
