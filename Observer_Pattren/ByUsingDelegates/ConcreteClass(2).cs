using system;

public class mobileViewApp
{
    public void onPriceChanged(object? sender, decimal newPrice)
    {
        if(sender is cryptoMarket market)
        {
            Console.WriteLine($"Price of {market.symbool} has changed to {newPrice}");
        }
    }
}