using System;

public class Program
{
    private const double FuelConsumptionIndex = 1;

    public static void Main()
    {
        var vehicleInput = Console.ReadLine().Split();
        Vehicle car = new Car(double.Parse(vehicleInput[1]), double.Parse(vehicleInput[2]), double.Parse(vehicleInput[3]));

        vehicleInput = Console.ReadLine().Split();
        Vehicle truck = new Truck(double.Parse(vehicleInput[1]), double.Parse(vehicleInput[2]), double.Parse(vehicleInput[3]));

        vehicleInput = Console.ReadLine().Split();
        var bus = new Bus(double.Parse(vehicleInput[1]), double.Parse(vehicleInput[2]), double.Parse(vehicleInput[3]));

        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var commandTokens = Console.ReadLine().Split();
            var parameter = double.Parse(commandTokens[2]);
            var command = commandTokens[0];

            try
            {
                switch (command)
                {
                    case "Drive":
                        if (commandTokens[1] == "Car")
                        {
                            Console.WriteLine(car.Drive(parameter));
                        }
                        else if (commandTokens[1] == "Bus")
                        {
                            Console.WriteLine(bus.Drive(parameter));
                        }
                        else
                        {
                            Console.WriteLine(truck.Drive(parameter));
                        }
                        break;
                    case "Refuel":
                        if (commandTokens[1] == "Car")
                        {
                            car.Refuel(parameter, FuelConsumptionIndex);
                        }
                        else if (commandTokens[1] == "Bus")
                        {
                            bus.Refuel(parameter, FuelConsumptionIndex);
                        }
                        else
                        {
                            truck.Refuel(parameter,FuelConsumptionIndex);
                        }
                        break;
                    case "DriveEmpty":
                        {
                            Console.WriteLine(bus.DriveEmpty(parameter));
                        }
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine(car.ToString());
        Console.WriteLine(truck.ToString());
        Console.WriteLine(bus.ToString());
    }
}




