﻿using System;

public class Product
{
    private string name;
    private decimal cost;

    public Product(string name, decimal cost)
    {
        this.Name = name;
        this.Cost = cost;
    }

    public string Name
    {
        get
        { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Name cannot be empty");
            }
            this.name = value;
        }
    }
    public decimal Cost
    {
        get { return this.cost; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Money cannot be negative");
            }
            this.cost = value;
        }
    }
}
