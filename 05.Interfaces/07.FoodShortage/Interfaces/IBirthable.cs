using System;

public interface IBirthable
{
    DateTime Birthdate { get; }
    bool CheckBirthYear(string line);
}
