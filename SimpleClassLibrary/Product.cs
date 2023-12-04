using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary
{
    internal class Product
    {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public Currency Cost { get; set; }
            public int Quantity { get; set; }
            public string Producer { get; set; }
            public decimal Weight { get; set; }

            private int expirationDays;

            public int ExpirationDays
            {
                get { return expirationDays; }
                set { expirationDays = value; }
            }

            public int ExpirationMonths
            {
                get { return expirationDays / 30; }
            }

            public int ExpirationYears
            {
                get { return expirationDays / 365; }
            }

            public void SetExpiration()
            {
                Console.WriteLine("Enter the expiration term:");

                Console.Write("Value: ");
                int value = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose the unit of measurement:");
                Console.WriteLine("1. Days");
                Console.WriteLine("2. Months");
                Console.WriteLine("3. Years");

                Console.Write("Enter the number of your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        expirationDays = value;
                        break;
                    case 2:
                        expirationDays = value * 30; // 1 month = 30 days
                        break;
                    case 3:
                        expirationDays = value * 365; // 1 year = 365 days
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Expiration term not set.");
                        break;
                }
            }

            public Product() { }

            public Product(string name, decimal price, Currency cost, int quantity, string producer, decimal weight)
            {
                Name = name;
                Price = price;
                Cost = cost;
                Quantity = quantity;
                Producer = producer;
                Weight = weight;
            }

            public Product(Product other)
            {
                Name = other.Name;
                Price = other.Price;
                Cost = new Currency(other.Cost);
                Quantity = other.Quantity;
                Producer = other.Producer;
                Weight = other.Weight;
                ExpirationDays = other.ExpirationDays;
            }

            public override string ToString()
            {
                return $"{Name} - {Price} {Cost.Name}/{Price * Cost.ExRate} UAN, Quantity: {Quantity}, Producer: {Producer}, Weight: {Weight} kg";
            }
        }
}
