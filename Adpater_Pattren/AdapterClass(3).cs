using system;

public class RazorAdapter:IpaymentStragey
{
    private readonly RazorpaySDK _razorSDK;

    private RazorAdapter(RazorpaySDK razorSDK)
    {
        _razorSDK=razorSDK;
    }

    public bool pay(decimal amount)
    {
        //Translates your systems format (Rupees in decimal)
        int amountInPaise = (int)(amount*100);

        string transactionId = _razorSDK.MakeCharge(amountInPaise,"INR");

        return !string.IsNullOrEmpty(transactionId); 
    }
}