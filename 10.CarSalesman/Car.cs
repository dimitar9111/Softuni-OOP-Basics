using System;

public class Car
{
    private string model;
    private Engine engine;
    private int weight;
    private string color;

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        this.Weight = -1;
        this.Color = "n/a";
    }

    public int Weight { get { return this.weight; } set { this.weight = value; } }
    public string Color { get { return this.color; } set { this.color = value; } }

    public void PrintCar()
    {
        Console.WriteLine($"{this.model}:");
        Console.WriteLine($"  {this.engine.Model}:");
        Console.WriteLine($"    Power: {this.engine.Power}");

        if (this.engine.Displacement > 0)
        {
            Console.WriteLine($"    Displacement: {this.engine.Displacement}");
        }
        else
        {
            Console.WriteLine($"    Displacement: n/a");
        }
        Console.WriteLine($"    Efficiency: {this.engine.Efficiency}");

        if (this.weight > 0)
        {
            Console.WriteLine($"  Weight: {this.weight}");
        }
        else
        {
            Console.WriteLine($"  Weight: n/a");
        }
        Console.WriteLine($"  Color: {this.color}");
    }
}

