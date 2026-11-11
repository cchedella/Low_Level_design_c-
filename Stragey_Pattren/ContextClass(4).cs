using system;

public class shoppingCart 
{
    private Ipayment _paymentMethod;

    public shoppingCart(Ipayment paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void checkout()
    {
        if(paymentMethod != null)
        {
             throw new InvalidOperationException("Payment strategy not set!"); 
        }
        _paymentMethod.Pay();
    }    

}