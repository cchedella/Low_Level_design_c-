public class MobileAppSubscriber : IInvestor
	{
		public void Update(string stockSymbol, decimal price)
		{
			Console.WriteLine($"[Mobile App] Alert!{stockSymbol} is now ${price}");
		}
	}
