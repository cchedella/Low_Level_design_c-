// 2. Adaptee ( An extenal thrid party SDK you cannot modify)
// Notice it uses 'int amountInPaise' and 'MakeCharge()'instead of 'pay(decimal)'

public class RazorpaySDK
{
    public string MakeCharge(int amountInPaise,string currency)
    {
        Console.WriteLine($"[Razorpay SDK] Charging {amountInPaise} paise ({currency}) via external API...");
            return "TXN_987654321"; // Returns a transaction ID instead of a bool
    }
}