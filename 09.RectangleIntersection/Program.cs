using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var rectangles = new Dictionary<string, Rectangle>();

        for (int i = 0; i < n[0]; i++)
        {
            var input = Console.ReadLine().Split();
            var id = input[0];
            var width = int.Parse(input[1]);
            var height = int.Parse(input[2]);
            var x = double.Parse(input[3]);
            var y = double.Parse(input[4]);

            var rectangle = new Rectangle(id, width, height, x, y);
            rectangles.Add(id, rectangle);
        }

        for (int i = 0; i < n[1]; i++)
        {
            var input = Console.ReadLine().Split();
            var firstID = input[0];
            var secondID = input[1];
            rectangles[firstID].Intersect(rectangles[secondID]);
        }
    }
}
