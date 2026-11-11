using system;

public class CreditCardPament : Ipayment
{
    public void Pay()
    {
        Console.WriteLine("Payment done with credit card");
    }
}