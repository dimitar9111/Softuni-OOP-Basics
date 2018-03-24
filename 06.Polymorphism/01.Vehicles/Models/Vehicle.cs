using System;

public abstract class Vehicle : IVehicle
{
    private double fuelQuantity;
    private double fuelConsumption;
    private double drivenDistance;
    private double tankCapacity;

    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
        this.DrivenDistance = 0;
    }

    public double FuelQuantity
    {
        get
        {
            return this.fuelQuantity;
        }
        protected set
        {
            if (value <= this.TankCapacity)
            {
                this.fuelQuantity = value;
            }
            else
            {
                this.fuelQuantity = 0;
            }
        }
    }

    public double FuelConsumption { get { return this.fuelConsumption; } private set { this.fuelConsumption = value; } }

    public double DrivenDistance { get { return this.drivenDistance; } private set { this.drivenDistance = value; } }

    public double TankCapacity { get { return this.tankCapacity; } private set { this.tankCapacity = value; } }

    public string Drive(double distance)
    {
        var fuelNeeded = distance * this.FuelConsumption;
        if (fuelNeeded > this.FuelQuantity)
        {
            throw new ArgumentException($"{this.GetType().Name} needs refueling");
        }
        this.FuelQuantity -= fuelNeeded;
        this.DrivenDistance += distance;

        return $"{this.GetType().Name} travelled {distance} km";
    }

    public virtual void Refuel(double fuel, double consumtionIndex)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        else if (fuel > this.TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
        }
        this.FuelQuantity += fuel*consumtionIndex;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }

}
