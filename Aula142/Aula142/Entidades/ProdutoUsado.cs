using System.Globalization;

namespace Aula142.Entidades
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataDeFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao) : base(nome, preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public override string Etiqueta()
        {
            return Nome + " (Usado) $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + "  (Data de Fabricacao: " + DataDeFabricacao.ToString("dd/MM/yyyy") + " )";
        }
    }
}
