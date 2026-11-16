using system;


public class stockExchange : IstockExchange
{
    private readonly List<Iinvestor> _investors=new();
    private string _symbool;
    private decimal _price;

    public void registerInvestor(Iinvestor investor)
    {
        if(!_investors.Contains(investor))
                    _investors.Add(investor);
    }

    public void removeInvestor(Iinvestor investor)
    {
                    _investors.Remove(investor);
    }

    public void notifyInvestors(Iinvestor investor)
    {
       foreach(var investor in _investor)
			{
				investor.Update(_symbool,_price);
			}
    }
    //Method to simulate the change
    public void updatePrice(string symbol,decimal price)
    {
        _symbool=symbol;
        _price=price;
        notifyInvestors();//trigger the notification to all the investors
    }
}