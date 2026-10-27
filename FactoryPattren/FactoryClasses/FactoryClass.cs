public class Transport
{
    public static IVechicle createTransport(string type)
   {   
    //     if (type.Equals("Car"))
    //     {
    //         return new Car();
    //     }
    //     else if (type.Equals("Bike"))
    //     {
    //         return new Bike();
    //     }
    //     else if (type.Equals("Truck"))
    //     {
    //         return new Truck();
    //     }
    //     else if (type.Equals("Ship"))
    //     {
    //         return new ship();
    //     }
    //     else
    //     {
    //         throw new Exception("Invalid Transport Type");
    //     }
      return type.ToLower() switch
      {
            "car" => new Car(),
            "bike" => new Bike(),
            "truck" => new Truck(),
            "ship" => new ship(),
            _ => throw new Exception("Invalid Transport Type")
      }
    }
}