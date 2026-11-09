     class Program
     {
        static voiv Main(string[] args)
        {
            // Client only intract with the faced
            OrderFaced order = new OrderFaced();
            order.placeOrder("123456789", 100.00m, "item001", "123 Main St, City, Country");
        }
     }