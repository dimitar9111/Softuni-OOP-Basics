public class Car : Vehicle
{
    private const double AirConditionerFuelConsumptionIncreasing = 0.9;

    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
        : base(fuelQuantity, fuelConsumption + AirConditionerFuelConsumptionIncreasing, tankCapacity)
    {
    }
}
