using System;

public class Program
{
    public static void Main()
    {
        var wizard = new Wizard();
        var tokens = Console.ReadLine().Split();

        foreach (var item in tokens)
        {
            Food food = FoodFactory.CreateFood(item);
            wizard.Eat(food);
        }

        Console.WriteLine(wizard);
    }
}
