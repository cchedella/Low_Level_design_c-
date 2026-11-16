using System;

public class cryptoMarket
{
    public string symbool {get;}
    public decimal _price;

    //define the event using built-in event handler

    public event EventHandler<decimal>? priceChanged;

    public cryptoMarket(string Symbool,decimal price)
    {
        symbool=Symbool;
        _price = price;
    }

    public void updatePrice(decimal newPrice)
    {
        if(_price != newPrice)
        {
            _price = newPrice;
            //Trigger the notification to all the subcribers
            priceChanged?.Invoke(this,_price);
        }
    }
}