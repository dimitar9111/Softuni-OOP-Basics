public class Cargo
{
    private int weight;
    private string type;

    public Cargo(int weight, string type)
    {
        this.weight = weight;
        this.Type = type;
    }

    public string Type { get { return this.type; } private set { this.type = value; } }
}