using Aula155.Entidade.Excecoes;
using System.Globalization;

namespace Aula155.Entidade
{
    internal class ContaBancaria
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double LimiteDeSaque { get; set; }

        public ContaBancaria()
        { 
        }

        public ContaBancaria(int numero, string nome, double saldo, double limiteDeSaque)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if (valor > Saldo)
            {
                throw new DomainException("Valor  solicitado para saque maior do que saldo.");
            }
            else if (valor > LimiteDeSaque)
            {
                throw new DomainException("Valor solicitado para saque maior que o permitido.");
            }
            else 
            {
                Saldo -= valor;
                Console.WriteLine("Novo saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
