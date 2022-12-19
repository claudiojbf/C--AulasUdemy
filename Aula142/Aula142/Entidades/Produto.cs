﻿using System.Globalization;
namespace Aula142.Entidades
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        { 
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string Etiqueta() 
        {
            return Nome + " $ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
