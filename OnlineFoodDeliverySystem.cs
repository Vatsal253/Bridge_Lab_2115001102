using System;
using System.Collections.Generic;
namespace OnlineFoodDeliverySystem
{
    interface IDiscountable
    {
        double ApplyDiscount();
        string GetDiscountDetails();
    }

    abstract class FoodItem
    {
        private string itemName;
        private double price;
        private int quantity;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        protected FoodItem(string itemName, double price, int quantity)
        {
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
        }

        public abstract double CalculateTotalPrice();

        public virtual void GetItemDetails()
        {
            Console.WriteLine("Item Name: " + itemName);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quantity: " + quantity);
        }
    }

    class VegItem : FoodItem, IDiscountable
    {
        public VegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            return Price * Quantity;
        }

        public double ApplyDiscount()
        {
            return Price * 0.90; // 10% discount for veg items
        }

        public string GetDiscountDetails()
        {
            return "Discount: 10%";
        }

        public override void GetItemDetails()
        {
            base.GetItemDetails();
            Console.WriteLine("Category: Veg");
        }
    }

    class NonVegItem : FoodItem, IDiscountable
    {
        public NonVegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + 5.00; 
        }

        public double ApplyDiscount()
        {
            return (Price * 0.95) + 5.00; 
        }

        public string GetDiscountDetails()
        {
            return "Discount: 5%";
        }

        public override void GetItemDetails()
        {
            base.GetItemDetails();
            Console.WriteLine("Category: Non-Veg");
        }
    }

    class Program
    {
        static void Main()
        {
            List<FoodItem> foodItems = new List<FoodItem>
            {
                new VegItem("Veg Burger", 10.0, 2),
                new NonVegItem("Chicken Burger", 15.0, 1)
            };

            foreach (FoodItem item in foodItems)
            {
                item.GetItemDetails();
                double discount = 0;
                if (item is IDiscountable discountableItem)
                {
                    discount = discountableItem.ApplyDiscount();
                    Console.WriteLine(discountableItem.GetDiscountDetails());
                }

                double totalPrice = item.CalculateTotalPrice();
                double finalPrice = totalPrice - discount;
                Console.WriteLine("Total Price: " + totalPrice);
                Console.WriteLine("Final Price after Discount: " + finalPrice);
                Console.WriteLine();
            }
        }
    }
}
