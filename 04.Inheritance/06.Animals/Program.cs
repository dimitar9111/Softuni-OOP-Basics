using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string inputType;

        while ((inputType=Console.ReadLine())!= "Beast!")
        {
            var parameters = Console.ReadLine().Split().ToList();
            parameters.Insert(0, inputType);

            try
            {
                var animal = AnimalFactory.CreateAnimal(parameters);
                Console.WriteLine(animal);
                Console.WriteLine(animal.ProduceSound());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
