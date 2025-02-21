using System;
using System.Collections.Generic;
public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    protected Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayInfo();
}
public class BookCategory : Product
{
    public string Author { get; set; }

    public BookCategory(string name, decimal price, string author) : base(name, price)
    {
        Author = author;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Book - Name: " + Name + ", Price: " + Price + ", Author: " + Author);
    }
}
public class ClothingCategory : Product
{
    public string Size { get; set; }

    public ClothingCategory(string name, decimal price, string size) : base(name, price)
    {
        Size = size;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Clothing - Name: " + Name + ", Price: " + Price + ", Size: " + Size);
    }
}
public class Product<T> where T : Product
{
    public T Item { get; set; }

    public Product(T item)
    {
        Item = item;
    }

    public void DisplayProductInfo()
    {
        Item.DisplayInfo();
    }
}
public class Discount
{
    public static void ApplyDiscount<T>(T product, double percentage) where T : Product
    {
        
        product.Price -= product.Price * (decimal)(percentage / 100);
    }
}
public class ProductCatalog
{
    private List<Product> products = new List<Product>();
    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine(product.Name + " added to catalog.");
    }
    public void DisplayAllProducts()
    {
        Console.WriteLine("Products in catalog:");
        foreach (Product product in products)
        {
            product.DisplayInfo();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BookCategory book = new BookCategory("C# Programming", 30.00m, "Author Name");
        ClothingCategory shirt = new ClothingCategory("T-Shirt", 20.00m, "L");
        Product<BookCategory> product1 = new Product<BookCategory>(book);
        Product<ClothingCategory> product2 = new Product<ClothingCategory>(shirt);
        ProductCatalog catalog = new ProductCatalog();
        catalog.AddProduct(book);
        catalog.AddProduct(shirt);
        catalog.DisplayAllProducts();
        Discount.ApplyDiscount(book, 10);
        Console.WriteLine("After applying discount:");
        catalog.DisplayAllProducts();
    }
}
