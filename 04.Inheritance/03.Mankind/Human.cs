using System;
using System.Linq;
using System.Text;

public class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    protected string FirstName
    {
        get
        {
            return this.firstName;
        }
        private set
        {
            if (!char.IsUpper(value.First()))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }
            else if (value.Length < 4)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            this.firstName = value;
        }
    }

    protected string LastName
    {
        get
        {
            return this.lastName;
        }
        private set
        {
            if (char.IsLower(value.First()))
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }
            else if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            this.lastName = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}");
        sb.AppendLine($"Last Name: {this.LastName}");

        return sb.ToString();
    }
}
