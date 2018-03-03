using System;

public class Program
{
    public static void Main()
    {
        var driversName = Console.ReadLine();
        var ferrari = new Ferrari(driversName);

        Console.WriteLine(ferrari);
    }
}
