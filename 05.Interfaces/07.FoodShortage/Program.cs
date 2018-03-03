using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Program
{

    public static void Main()
    {
        var buyers = new List<IBuyer>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split();
            IBuyer buyer;
            if (tokens.Length == 3)
            {
                buyer = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
            }
            else
            {
                buyer = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2],
                    DateTime.ParseExact(tokens[3], "dd/MM/yyyy", CultureInfo.InvariantCulture));
            }

            buyers.Add(buyer);
        }

        string name;
        while ((name=Console.ReadLine())!="End")
        {
            var buyer = buyers.FirstOrDefault(b => b.Name==name);
            if (buyer != null)
            {
                buyer.BuyFood();
            }
        }

        var totalFood = buyers.Sum(b => b.Food);
        Console.WriteLine(totalFood);
    }
}
