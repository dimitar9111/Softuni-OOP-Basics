using System;
using System.Collections.Generic;

public class AnimalFactory
{
    public static Animal CreateAnimal(List<string> tokens)
    {
        var type = tokens[0];
        var name = tokens[1];
        var age = int.Parse(tokens[2]);
        var gender = tokens[3];

        switch (type)
        {
            case "Dog":
                return new Dog(name, age, gender);
            case "Cat":
                return new Cat(name, age, gender);
            case "Frog":
                return new Frog(name, age, gender);
            case "Kitten":
                return new Kitten(name, age, gender);
            case "Tomcat":
                return new Tomcat(name, age, gender);
            default:
                throw new ArgumentException("Invalid input!");
        }
    }
}
