using System;

public class Pet : IBirthable
{
    public Pet(string name, DateTime birthdate)
    {
        this.Name = name;
        this.Birthdate = birthdate;
    }

    public string Name { get; private set; }

    public DateTime Birthdate { get; private set; }

    public bool CheckBirthYear(string input)
    {
        var year = int.Parse(input);
        if (this.Birthdate.Year == year)
        {
            return true;
        }
        return false;
    }
}
