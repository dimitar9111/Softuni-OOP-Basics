using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var cars = new List<Car>();

        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            var model = input[0];
            var engine = new Engine(int.Parse(input[1]),int.Parse(input[2]));
            var cargo = new Cargo(int.Parse(input[3]), input[4]);

            var tyreInfo = input.Skip(5).ToArray();
            var tyres = new List<Tyre>();
            for (int j = 0; j < 8; j+=2)
            {
                var tyre = new Tyre(double.Parse(tyreInfo[j]),int.Parse(tyreInfo[j+1]));
                tyres.Add(tyre);
            }

            var car = new Car(model, engine, cargo, tyres);
            cars.Add(car);
        }

        var cargoType = Console.ReadLine();
        var filteredCars = new List<Car>();

        if (cargoType=="flamable")
        {
            filteredCars = cars
                .Where(c => c.cargo.Type == cargoType && c.engine.Power > 250)
                .ToList();
        }
        else
        {
            filteredCars = cars
                .Where(c => c.cargo.Type == cargoType && c.tyres.Any(t => t.Pressure < 1))
                .ToList();
        }

        foreach (var car in filteredCars)
        {
            Console.WriteLine(car);
        }
    }
}
