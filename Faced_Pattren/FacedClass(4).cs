using system;

public class OrderFaced
{
    private readonly paymentProcess _paymentProcess;
    private readonly inventoryManager _inventoryManager;
    private readonly shipingProcess _shipingProcess;

    public OrderFaced(paymentProcess paymentProcess,inventoryManager inventoryManager,shipingProcess shipingProcess)
    {
        _paymentProcess=paymentProcess;
        _inventoryManager =inventoryManager;
        _shipingProcess = shipingProcess;
    }

    //simplefied interface for the client
    public bool placeOrder(string account,decimal amount,string itemId,string address)
    {
        console.WriteLine("Palcing the order");

         if(!_inventoryManager.verifyStock(itemId))
            {
                console.WriteLine($"item with id :{itemId} is out of stock");
                return false;
            }   
         if(!_paymentProcess.processPayment(account,amount))
         {
            console.WriteLine("Payment processing failed");
            return false;
         }
         _inventoryManager.reserveItem(itemId);
         _shipingProcess.arrangeShiping(itemId,address);
            console.WriteLine($"Order placed successfully for item :{itemId} and will be shipped to {address}");
            return true;
         
    }
}