namespace Aula232.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Product(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return Name + " : $ " + Value;
        }
    }
}
