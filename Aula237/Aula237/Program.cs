using Aula237.Entities;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace Aula237
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T c in collection) 
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            List<Products> products = new List<Products>()
            {
                new Products(1, "Computer", 1100.00, c2),
                new Products(2, "Hammer", 90.0, c1),
                new Products(3, "TV", 1700.0, c3),
                new Products(4, "Notebook", 1300.0, c2),
                new Products(5, "Saw", 80.0, c1),
                new Products(6, "Tablet", 700.0, c2),
                new Products(7, "Camera", 700.0, c3),
                new Products(8, "Printer", 350.0, c3),
                new Products(9, "MacBook", 1800.0, c2),
                new Products(10, "Sound Bar", 700.0, c3),
                new Products(11, "Level", 70.0, c1)
            };

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.00
                select p;
            Print("TIER 1 AND PRICE < 900:", r1);
            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAME OF PRODUCTS FROM TOOLS", r2);
            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name});
            var r3 = from p in products
                     where p.Name[0] == 'C'
                     select new {p.Name, p.Price, CategoryName = p.Category.Name};
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);
            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);
            //var r5 = r4.Skip(2).Take(4);
            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 AND TAKE 4", r5);
            var r6 = products.First();
            Console.WriteLine(r6);
            var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
            Console.WriteLine(r7);
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine(r8);
            var r9 = products.Max(p => p.Price);
            Console.WriteLine(r9);
            var r10 = products.Min(p => p.Price);
            Console.WriteLine(r10);
            var r11 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine(r11);
            var r12 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine(r12);
            var r13 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty().Average();
            Console.WriteLine(r13);
            var r14 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine(r14);
            //var r15 = products.GroupBy(p => p.Category);

            var r15 =
                from p in products
                group p by p.Category;
            foreach (IGrouping<Category, Products> group in r15)
            {
                Console.WriteLine(group.Key.Name);
                foreach (Products p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}