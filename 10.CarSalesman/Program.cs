using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var cars = new List<Car>();
        var engines = new Dictionary<string, Engine>();

        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Trim().Split();

            var engine = new Engine(input[0], int.Parse(input[1]));
            if (input.Length > 2)
            {
                if (int.TryParse(input[2], out var displacement))
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = input[2];
                }
            }
            if (input.Length > 3)
            {
                engine.Efficiency = input[3];
            }

            engines.Add(input[0], engine);
        }

        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Trim().Split();
            var car = new Car(input[0], engines[input[1]]);

            if (input.Length > 2)
            {
                if (int.TryParse(input[2], out var weight))
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = input[2];
                }
            }
            if (input.Length > 3)
            {
                car.Color = input[3];

            }

            cars.Add(car);
        }

        foreach (var car in cars)
        {
            car.PrintCar();
        }
    }
}
