using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = string.Empty;
        var privates = new List<Private>();

        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();
            var soldierType = tokens[0];

            switch (soldierType)
            {
                case "Private":
                    var privateSoldier = new Private(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]));
                    privates.Add(privateSoldier);
                    Console.WriteLine(privateSoldier.ToString());
                    break;
                case "LeutenantGeneral":
                    var soldiers = tokens.Skip(5).ToArray();
                    var leutenantGeneral = new LeutenantGeneral(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]));
                    leutenantGeneral.AddSoldiers(soldiers, privates);
                    Console.WriteLine(leutenantGeneral.ToString());
                    break;
                case "Engineer":
                    if (tokens[5] == "Airforces" || tokens[5] == "Marines")
                    {
                        var repairs = tokens.Skip(6).ToArray();
                        var engineer = new Engineer(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]), tokens[5]);
                        engineer.AddRepairs(repairs);
                        Console.WriteLine(engineer.ToString());
                    }
                    break;
                case "Commando":
                    if (tokens[5] == "Airforces" || tokens[5] == "Marines")
                    {
                        var missions = tokens.Skip(6).ToArray();
                        var commando = new Commando(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]), tokens[5]);
                        commando.AddMissions(missions);
                        Console.WriteLine(commando.ToString());
                    }
                    break;
                case "Spy":
                    var spy = new Spy(tokens[1], tokens[2], tokens[3], int.Parse(tokens[4]));
                    Console.WriteLine(spy.ToString());
                    break;
            }
        }
    }
}

