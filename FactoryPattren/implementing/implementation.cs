public class implementation
{

    //craeting the car object using the factory
   IVechicle CarVehicle = Transport.createTransport("Car");

    //craeting the ship object using the factory
   IVechicle ShipVechioe = Transport.createTransport("Ship");


 //calling the Methods of the objects
   CarVehicle.getType();
   ShipVechioe.getType();
} 