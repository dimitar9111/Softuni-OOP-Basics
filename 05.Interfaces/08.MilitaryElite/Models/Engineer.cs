using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : Private, IEngineer, ISpecialisedSoldier
{
    public Engineer(string id, string firstName, string lastName, double salary, string corps) 
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
        this.Repairs = new Dictionary<string, int>();
    }

    public Dictionary<string, int> Repairs { get; private set; }

    public string Corps { get; private set; }

    public void AddRepairs(string[] repairs)
    {
        for (int i = 0; i < repairs.Length; i += 2)
        {
            this.Repairs.Add(repairs[i], int.Parse(repairs[i + 1]));
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Corps: {this.Corps}");
        sb.AppendLine("Repairs:");
        foreach (var repair in this.Repairs)
        {
            sb.AppendLine($"  Part Name: {repair.Key} Hours Worked: {repair.Value}");
        }
        return base.ToString() + Environment.NewLine + sb.ToString().Trim();
    }
}
