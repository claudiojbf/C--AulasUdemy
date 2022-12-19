using System.Globalization;

namespace Aula237.Entities
{
    internal class Products
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Products(int id, string name, double price, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Category.Name
                +", "
                + Category.Tier;
        }
    }
}
