using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.Products = new List<Product>();
    }

    public string Name
    {
        get
        { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }

    public decimal Money {
        get
        { return this.money; }
        private set
        {
            if (value<0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }

    public List<Product> Products { get { return new List<Product> (this.products); } private set { this.products = value; } }

    public string BuyProduct(Product product)
    {
        if (product.Cost>this.Money)
        {
            throw new Exception($"{this.Name} can't afford {product.Name}");
        }
        this.Money -= product.Cost;
        this.products.Add(product);

        string result = $"{this.Name} bought {product.Name}";
        return result;
    }
}
