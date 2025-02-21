using System;
using System.Collections.Generic;
class ShoppingCart
{
    private Dictionary<string, double> productPrices = new Dictionary<string, double>();
    private LinkedList<string> orderList = new LinkedList<string>();
    private SortedDictionary<double, List<string>> sortedByPrice = new SortedDictionary<double, List<string>>();
    public void AddProduct(string productName, double price)
    {
        if (!productPrices.ContainsKey(productName))
        {
            productPrices[productName] = price;
            orderList.AddLast(productName);

            if (!sortedByPrice.ContainsKey(price))
            {
                sortedByPrice[price] = new List<string>();
            }
            sortedByPrice[price].Add(productName);
        }
        else
        {
            Console.WriteLine("Product already exists in the cart.");
        }
    }
    public void DisplayUniqueProducts()
    {
        Console.WriteLine("Unique Products in the Cart:");
        foreach (var kvp in productPrices)
        {
            Console.WriteLine(kvp.Key + ": $" + kvp.Value);
        }
    }
    public void DisplayOrderOfProducts()
    {
        Console.WriteLine("Order of Products Added:");
        foreach (var product in orderList)
        {
            Console.WriteLine(product);
        }
    }
    public void DisplayProductsSortedByPrice()
    {
        Console.WriteLine("Products Sorted by Price:");
        foreach (var kvp in sortedByPrice)
        {
            foreach (var product in kvp.Value)
            {
                Console.WriteLine(product + ": $" + kvp.Key);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();
        cart.AddProduct("Apple", 1.20);
        cart.AddProduct("Banana", 0.80);
        cart.AddProduct("Cherry", 2.50);
        cart.AddProduct("Date", 3.00);
        cart.AddProduct("Elderberry", 1.50);
        cart.DisplayUniqueProducts();
        cart.DisplayOrderOfProducts();
        cart.DisplayProductsSortedByPrice();
    }
}
