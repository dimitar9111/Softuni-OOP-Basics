using System.Collections.Generic;

public class Car
{
    public string model;
    public Engine engine;
    public Cargo cargo;
    public List<Tyre> tyres;

    public Car(string model, Engine engine, Cargo cargo, List<Tyre> tyres)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tyres = tyres;
    }
    public override string ToString()
    {
        return this.model;
    }
}
