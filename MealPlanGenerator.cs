using System;
using System.Collections.Generic;
public interface IMealPlan
{
    string MealName { get; }
    void DisplayInfo();
}
public class VegetarianMeal : IMealPlan
{
    public string MealName { get; private set; }
    public string Ingredients { get; private set; }

    public VegetarianMeal(string mealName, string ingredients)
    {
        MealName = mealName;
        Ingredients = ingredients;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Vegetarian Meal - Name: " + MealName + ", Ingredients: " + Ingredients);
    }
}
public class VeganMeal : IMealPlan
{
    public string MealName { get; private set; }
    public string Ingredients { get; private set; }

    public VeganMeal(string mealName, string ingredients)
    {
        MealName = mealName;
        Ingredients = ingredients;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Vegan Meal - Name: " + MealName + ", Ingredients: " + Ingredients);
    }
}
public class KetoMeal : IMealPlan
{
    public string MealName { get; private set; }
    public string Ingredients { get; private set; }

    public KetoMeal(string mealName, string ingredients)
    {
        MealName = mealName;
        Ingredients = ingredients;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Keto Meal - Name: " + MealName + ", Ingredients: " + Ingredients);
    }
}
public class HighProteinMeal : IMealPlan
{
    public string MealName { get; private set; }
    public string Ingredients { get; private set; }

    public HighProteinMeal(string mealName, string ingredients)
    {
        MealName = mealName;
        Ingredients = ingredients;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("High-Protein Meal - Name: " + MealName + ", Ingredients: " + Ingredients);
    }
}
public class Meal<T> where T : IMealPlan
{
    private List<T> mealPlans = new List<T>();
    public void AddMealPlan(T mealPlan)
    {
        mealPlans.Add(mealPlan);
        Console.WriteLine(mealPlan.MealName + " added to meal plans.");
    }
    public void DisplayAllMealPlans()
    {
        Console.WriteLine("Available Meal Plans:");
        foreach (T mealPlan in mealPlans)
        {
            mealPlan.DisplayInfo();
        }
    }
}
public class MealPlanGenerator
{
    public static void GenerateMealPlan<T>(T mealPlan) where T : IMealPlan
    {
        Console.WriteLine("Generating meal plan for: " + mealPlan.MealName);
        mealPlan.DisplayInfo();
    }
}

class Program
{
    static void Main(string[] args)
    {
        VegetarianMeal vegetarianMeal = new VegetarianMeal("Shahi Paneer", "Paneer, Carrots, Tomato");
        VeganMeal veganMeal = new VeganMeal("Veg Paradise", "Olive, Peas, Spinach");
        KetoMeal ketoMeal = new KetoMeal("Keto Feast", "Bacon, Avocado, Cheese");
        HighProteinMeal highProteinMeal = new HighProteinMeal("Protein Power", "Chicken, Eggs, Lentils");
        Meal<IMealPlan> mealCatalog = new Meal<IMealPlan>();
        mealCatalog.AddMealPlan(vegetarianMeal);
        mealCatalog.AddMealPlan(veganMeal);
        mealCatalog.AddMealPlan(ketoMeal);
        mealCatalog.AddMealPlan(highProteinMeal);
        mealCatalog.DisplayAllMealPlans();
        MealPlanGenerator.GenerateMealPlan(vegetarianMeal);
        MealPlanGenerator.GenerateMealPlan(veganMeal);
    }
}
