using System;

public class Bus : Vehicle
{
    private const double AirConditionerFuelConsumptionIncreasing = 1.4;


    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
        : base(fuelQuantity, fuelConsumption + AirConditionerFuelConsumptionIncreasing, tankCapacity)
    {
    }

    public string DriveEmpty(double distance)
    {
        var fuelConsumption = distance * (this.FuelConsumption - AirConditionerFuelConsumptionIncreasing);
        if (fuelConsumption <= this.FuelQuantity)
        {
            this.FuelQuantity -= fuelConsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        return $"{this.GetType().Name} needs refueling";
    }
}