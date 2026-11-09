using systm;

public class paymentProcess
{
    public bool processPayment(string account, decimal amount)
    {
        console.writeLine($"processing the payment of${amount} from account ${account}")l
        return true;
    }
}