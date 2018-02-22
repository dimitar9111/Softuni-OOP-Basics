using System;

public class Program
{
    public static void Main()
    {
        try
        {
            var pizzaInput = Console.ReadLine().Split();
            var pizza = new Pizza(pizzaInput[1]);
            var doughInput = Console.ReadLine().Split();
            var dough = new Dough(doughInput[1], doughInput[2], double.Parse(doughInput[3]));
            pizza.Dough = dough;
            MakePizza(pizza);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
    }

    public static void MakePizza(Pizza pizza)
    {
        string input;
        var toppingCounter = 0;
        while ((input = Console.ReadLine()) != "END")
        {
            if (toppingCounter > 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
            var topInfo = input.Split();
            var topping = new Topping(topInfo[1], double.Parse(topInfo[2]));
            pizza.AddTopping(topping);
            toppingCounter++;
        }

        Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");
    }
}
