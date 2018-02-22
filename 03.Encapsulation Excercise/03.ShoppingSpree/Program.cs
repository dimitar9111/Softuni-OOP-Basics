using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
        var people = new List<Person>();

        for (int i = 0; i < input.Length; i += 2)
        {
            try
            {
                var person = new Person(input[i], decimal.Parse(input[i + 1]));
                people.Add(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }

        input = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
        var products = new List<Product>();

        for (int i = 0; i < input.Length; i += 2)
        {
            try
            {
                var product = new Product(input[i], decimal.Parse(input[i + 1]));
                products.Add(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        string line;
        while ((line=Console.ReadLine())!="END")
        {
            var tokens = line.Split();
            var personName = tokens[0];
            var productName = tokens[1];

            var product = products.FirstOrDefault(p => p.Name == productName);
            var buyer = people.FirstOrDefault(p => p.Name == personName);
            try
            {
                Console.WriteLine(buyer.BuyProduct(product));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach (var person in people)
        {
            if (person.Products.Count > 0)
            {
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(pr => pr.Name))}");
            }
            else
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
        }
    }
}
