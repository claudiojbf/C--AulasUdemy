using System.Globalization;

namespace Aula142.Entidades
{
    internal class ProdutoImportado : Produto
    {
        public double CustoDeImportacao { get; set; }

        public ProdutoImportado()
        { 
        }

        public ProdutoImportado(string nome, double preco, double custoDeImportacao) : base(nome, preco)
        {
            CustoDeImportacao = custoDeImportacao;
        }

        public double PrecoTotal()
        {
            return Preco + CustoDeImportacao;
        }

        public override string Etiqueta()
        {
            return Nome + " $ " + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture) 
                + " ( Custo de Importação: $ " 
                + CustoDeImportacao.ToString("F2", CultureInfo.InvariantCulture) + " )";
        }
    }
}
