using System;
using System.Collections.Generic;
public abstract class WarehouseItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    protected WarehouseItem(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayInfo();
}
public class Electronics : WarehouseItem
{
    public string Brand { get; set; }

    public Electronics(string name, decimal price, string brand) : base(name, price)
    {
        Brand = brand;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Electronics - Name: " + Name + ", Price: " + Price + ", Brand: " + Brand);
    }
}
public class Groceries : WarehouseItem
{
    public DateTime ExpiryDate { get; set; }

    public Groceries(string name, decimal price, DateTime expiryDate) : base(name, price)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Groceries - Name: " + Name + ", Price: " + Price + ", Expiry Date: " + ExpiryDate);
    }
}
public class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(string name, decimal price, string material) : base(name, price)
    {
        Material = material;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Furniture - Name: " + Name + ", Price: " + Price + ", Material: " + Material);
    }
}
public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();
    public void AddItem(T item)
    {
        items.Add(item);
        Console.WriteLine(item.Name + " added to storage.");
    }
    public void DisplayAllItems()
    {
        Console.WriteLine("Items in storage:");
        foreach (T item in items)
        {
            item.DisplayInfo();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Electronics laptop = new Electronics("Laptop", 100000.00m, "Dell");
        Groceries apple = new Groceries("Apple", 150m, DateTime.Now.AddDays(10));
        Furniture chair = new Furniture("Chair", 500m, "Wood");
        Storage<WarehouseItem> warehouse = new Storage<WarehouseItem>();
        warehouse.AddItem(laptop);
        warehouse.AddItem(apple);
        warehouse.AddItem(chair);
        warehouse.DisplayAllItems();
    }
}
