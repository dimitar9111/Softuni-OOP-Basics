public class GoldenEditionBook : Book
{
    private const decimal GoldenBookPriceMultiplier = 1.3m;

    public GoldenEditionBook(string title, string author, decimal price) 
        : base(title, author, price*GoldenBookPriceMultiplier)
    {    
    }
}