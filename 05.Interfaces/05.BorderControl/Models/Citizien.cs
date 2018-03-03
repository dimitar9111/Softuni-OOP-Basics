using System;

public class Citizen : IIdentable, IBirthable
{
    public Citizen(string name, int age, string id, DateTime birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public string Id { get; private set; }

    public DateTime Birthdate { get; private set; }

    public bool CheckBirthYear(string input)
    {
        var year = int.Parse(input);
        if (this.Birthdate.Year==year)
        {
            return true;
        }
        return false;
    }

    public bool IDIsFake(string lastNumbers)
    {
        if (this.Id.EndsWith(lastNumbers))
        {
            return true;
        }
        return false;
    }
}
