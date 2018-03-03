using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        var units = new List<IBirthable>();

        string input;
        while ((input=Console.ReadLine())!="End")
        {
            var tokens = input.Split();
            IBirthable unit = null;
            if (tokens[0]=="Citizen")
            {
                unit = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], 
                    DateTime.ParseExact(tokens[4],"dd/MM/yyyy",CultureInfo.InvariantCulture));
            }
            else if(tokens[0]=="Pet")
            {
                unit = new Pet(tokens[1],
                    DateTime.ParseExact(tokens[2], "dd/MM/yyyy", CultureInfo.InvariantCulture));
            }

            if (unit != null)
            {
                units.Add(unit);
            }
        }

        var yearOfBirth = Console.ReadLine();
        foreach (var unit in units.Where(u=>u.CheckBirthYear(yearOfBirth)))
        {
            Console.WriteLine(unit.Birthdate.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture));
        }
    }
}

