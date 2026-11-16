using system;

public class loggingService
{
    public void onPriceChanged(object? sender, decimal newPrice)
    {
        if(sender is cryptoMarket market)
        {
            Console.WriteLine($"Logging: Price of {market.symbool} has changed to {newPrice}");
        }
    }
}