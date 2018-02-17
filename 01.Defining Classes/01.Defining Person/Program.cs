using System;

class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var family = new Family();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var person = new Person(input[0], int.Parse(input[1]));
            family.AddMember(person);
        }

        Console.WriteLine(family.GetOldestMember());
    }
}
