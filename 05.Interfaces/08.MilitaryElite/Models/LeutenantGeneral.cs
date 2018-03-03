using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(string id, string firstName, string lastName, double salary) 
        : base(id, firstName, lastName, salary)
    {
        this.Privates = new List<Private>();
    }

    public List<Private> Privates { get; private set; }

    public void AddSoldiers(string[] soldiers, List<Private> privates)
    {
        for (int i = 0; i < soldiers.Length; i++)
        {
            this.Privates.Add(privates.Where(p => p.Id == soldiers[i]).First());
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Privates:");
        if (this.Privates.Count > 0)
        {
            foreach (var privateSoldier in this.Privates)
            {
                sb.AppendLine("  " + privateSoldier.ToString());
            }
        }
        return base.ToString() + Environment.NewLine + sb.ToString().Trim();
    }
}
