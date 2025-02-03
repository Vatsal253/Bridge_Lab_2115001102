using System;
namespace ProductInventory
{
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public static int TotalProducts { get; private set; }
        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
            TotalProducts++;
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine("Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
        }
        public static void DisplayTotalProducts()
        {
            Console.WriteLine("Total Products: " + TotalProducts);
        }
    }
    class Program
    {
        static void Main()
        {
            Product product1 = new Product("Laptop", 40,000);
            Product product2 = new Product("Smartphone", 60,000);
            product1.DisplayProductDetails();
            product2.DisplayProductDetails();
            Product.DisplayTotalProducts();
        }
    }
}
