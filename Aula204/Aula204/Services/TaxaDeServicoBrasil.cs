namespace Aula204.Services
{
    internal class TaxaDeServicoBrasil : ITaxaDeServico
    {
        public double Taxa(double valor)
        {
            if (valor <= 100.00)
            {
                return valor * 0.2;
            }
            else 
            {
                return valor * 0.15;
            }
        }
    }
}
