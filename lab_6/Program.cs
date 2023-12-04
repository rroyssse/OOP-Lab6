using System;
using SimpleClassLibrary;

class Program
{
    static void Main()
    {
        Product[] products = null;

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Enter products");
            Console.WriteLine("2. Display a product by number");
            Console.WriteLine("3. Display all products");
            Console.WriteLine("4. Exit");

            Console.Write("Enter the number of your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the number of products:");
                    int n = int.Parse(Console.ReadLine());
                    products = CreateProductArray(n);
                    break;

                case 2:
                    if (products != null && products.Length > 0)
                    {
                        Console.Write("Enter the index of the product to display:");
                        int indexToShow = int.Parse(Console.ReadLine());
                        if (indexToShow >= 0 && indexToShow < products.Length)
                        {
                            DisplaySingleProduct(products[indexToShow]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No products entered yet.");
                    }
                    break;

                case 3:
                    if (products != null && products.Length > 0)
                    {
                        DisplayAllProducts(products);
                    }
                    else
                    {
                        Console.WriteLine("No products entered yet.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid number.");
                    break;
            }
        }
    }

    static Product[] CreateProductArray(int n)
    {
        Product[] products = new Product[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter details for product #{i + 1}:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Currency Name: ");
            string currencyName = Console.ReadLine();

            Console.Write("Exchange Rate: ");
            decimal exchangeRate = decimal.Parse(Console.ReadLine());

            Currency cost = new Currency(currencyName, exchangeRate);

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Producer: ");
            string producer = Console.ReadLine();

            Console.Write("Weight (kg): ");
            decimal weight = decimal.Parse(Console.ReadLine());

            products[i] = new Product(name, price, cost, quantity, producer, weight);

            Console.WriteLine($"Enter expiration term for product #{i + 1}:");
            products[i].SetExpiration();
        }
        return products;
    }

    static void DisplaySingleProduct(Product product)
    {
        Console.WriteLine("Product details:");
        Console.WriteLine(product);
    }

    static void DisplayAllProducts(Product[] products)
    {
        Console.WriteLine("\nAll Products:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}
