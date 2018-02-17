using System;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumption;
    private int kilometersTravelled;

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumption = fuelConsumption;
        this.kilometersTravelled = 0;
    }

    public void Drive(int distance)
    {
        var fuelNeeded = distance * this.fuelConsumption;
        if (fuelNeeded > fuelAmount)
        {
            throw new Exception("Insufficient fuel for the drive");
        }

        this.fuelAmount -= fuelNeeded;
        this.kilometersTravelled += distance;
    }

    public override string ToString()
    {
        return $"{this.model} {this.fuelAmount:f2} {this.kilometersTravelled}";
    }
}
