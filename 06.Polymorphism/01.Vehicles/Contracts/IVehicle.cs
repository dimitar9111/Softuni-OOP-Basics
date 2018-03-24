public interface IVehicle
{
    double FuelQuantity { get; }
    double FuelConsumption { get; }
    double DrivenDistance { get; }
    double TankCapacity {get; }

    string Drive(double distance);
    void Refuel(double fuel, double consumtionIndex);
}
