using System;

namespace Aula128.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        { 
        }

        public HourContract(DateTime date, double value, int hours)
        {
            Date = date;
            ValuePerHour = value;
            Hours = hours;
        }

        public double TotalValue() 
        {
            return ValuePerHour * Hours;
        }
    }
}
