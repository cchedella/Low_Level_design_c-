public class ImplementUsingAbstract
{
   VechicleFactory fac=new CarFactory();
   IVechicle v1=fac.CreateVechicle();
   v1.getType();

   VechicleFactory fac2=new ShipFactor();
   IVechicle v2=fac2.CreateVechicle();
   v2.getType();

   
}