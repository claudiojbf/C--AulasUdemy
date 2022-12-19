using System.Globalization;
using System.Runtime.CompilerServices;

namespace Aula51
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, quantidade)
        {
            Quantidade = quantidade;
        }
           
        public string Nome
        {
            get 
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        /*
        public double Preco 
        { 
            get { return _preco; }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
        }
        */

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
