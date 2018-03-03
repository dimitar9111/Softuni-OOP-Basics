public class Ferrari : IDrivable
{
    public const string CarsModel = "488-Spider";

    public Ferrari(string driver)
    {
        this.Driver = driver;
        this.Model = CarsModel;      
    }

    public string Driver { get; private set; }

    public string Model { get; private set; }

    public string Brakes()
    {
        return "Brakes!";
    }

    public string GasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{Brakes()}/{GasPedal()}/{this.Driver}";
    }
}
