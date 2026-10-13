using Microsoft.AspNetCore.Http.HttpResults;

namespace Assignment_1.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PricePerDay { get; set; }
        public Car(int i, string n, decimal p )
        {
            Id = i;
            Name = n;
            PricePerDay = p;
        }
    }
}
