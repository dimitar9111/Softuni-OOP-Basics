public interface IIdentable
{
    string Id { get; }
    bool IDIsFake(string lastNumbers);
}
