using Aula228.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula228
{
    class Program
    { 
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1100.00));
            products.Add(new Product("Tablet", 450.00));
            products.Sort(CompareProduct);
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
            
        }
        static int CompareProduct(Product p1, Product p2)
        {
            return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        }
    }
}