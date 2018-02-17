using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var cars = new Dictionary<string, Car>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var model = input[0];
            var fuelAmount = double.Parse(input[1]);
            var fuelConsumption = double.Parse(input[2]);

            var car = new Car(model, fuelAmount, fuelConsumption);
            cars.Add(model, car);
        }

        string command;
        while ((command=Console.ReadLine())!="End")
        {
            var commandTokens = command.Split();
            var model = commandTokens[1];
            var distance = int.Parse(commandTokens[2]);
            try
            {
                cars[model].Drive(distance);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.Value);
        }
    }
}
