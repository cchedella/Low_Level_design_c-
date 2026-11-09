using system;

public class inventoryManager
{
    public bool verifyStock(string itemId)
    {
        console.writeLine($"verifing the stock for item :${itemId}");
        return true;
    }

    public void reserveItem(string itemId)
    {
        console.writeLine($"reserving the item:${itemId}");
    }
}