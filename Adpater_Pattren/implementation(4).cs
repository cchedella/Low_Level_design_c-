using system;

class Program
{
    static void Main()
    {
        //your checkout only knows IpaymentStragey
        RazorpaySDK extSDK = new RazorpaySDK();

        IpaymentStragey paymentMethod = new RazorAdapter();

        bool isSucess = paymentMethod.pay(500.00m);
        console.WriteLine(isSucess?"payment done":"payment fail");
    }
}