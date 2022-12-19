using System.Globalization;
using Aula132.Entities;
using Aula132.Entities.Enuns;

namespace Aula132
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client Data: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(nome, email, date);
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order o = new Order(status, client);
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Nome: ");
                string p_nome = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                int quantity = int.Parse(Console.ReadLine());
                Product p = new Product(p_nome, price);
                OrderItem order = new OrderItem(quantity, p);
                o.AddOrderItem(order);
            }

            Console.WriteLine(o);
        }
    }
}