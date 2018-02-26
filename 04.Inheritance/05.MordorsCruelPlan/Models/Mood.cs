public abstract class Mood
{
    public Mood(string name)
    {
        this.Name = name;
    }

    public string Name { get; private set; }
}
