using System;
using System.Collections.Generic;
using System.Text;

public class Commando : Private, ICommando, ISpecialisedSoldier
{
    public Commando(string id, string firstName, string lastName, double salary, string corps) 
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
        this.Missions = new Dictionary<string, string>();
    }

    public Dictionary<string, string> Missions { get; private set; }

    public string Corps { get; private set; }

    public void CompleteMission()
    {
        Console.WriteLine("Mission completed!");
    }

    public void AddMissions(string[] missions)
    {
        for (int i = 0; i < missions.Length; i += 2)
        {
            if (missions[i + 1] == "inProgress" || missions[i + 1] == "Finished")
            {
                this.Missions.Add(missions[i], missions[i + 1]);
            }
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Corps: {this.Corps}");
        sb.AppendLine("Missions:");
        foreach (var mission in this.Missions)
        {
            sb.AppendLine($"  Code Name: {mission.Key} State: {mission.Value}");
        }
        return base.ToString() + Environment.NewLine + sb.ToString().Trim();
    }
}
