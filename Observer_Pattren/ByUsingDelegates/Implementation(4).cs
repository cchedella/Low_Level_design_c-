using system;

class Program
{
    static void Main()
    {
        var btcMarket = new cryptoMarket("BTC", 50000m);
        var mobileApp = new mobileViewApp();
        var loggingService = new loggingService();

        // subcribe to the event
        btcMarket.priceChanged += mobileApp.onPriceChanged;
        btcMarket.priceChanged += loggingService.onPriceChanged;

        btcMarket.updatePrice(51000m);

        // Unsubcribe from the event
        btcMarket.priceChanged -= loggingService.onPriceChanged;

        btcMarket.updatePrice(52000m);
    }
}