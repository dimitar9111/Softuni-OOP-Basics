using System;

public class Truck : Vehicle
{
    private const double AirConditionerFuelConsumptionIncreasing = 1.6;
    private const double FuelLossIndex = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
        : base(fuelQuantity, fuelConsumption + AirConditionerFuelConsumptionIncreasing, tankCapacity)
    {
    }

    public override void Refuel(double fuel, double consumtionIndex)
    {
        base.Refuel(fuel, FuelLossIndex);
    }
}