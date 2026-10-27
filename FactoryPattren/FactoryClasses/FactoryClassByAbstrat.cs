public abstract class VechicleFactory
{
    public abstract IVechicle CreateVechicle();
}


public class CarFactory:VechicleFactory
{
    public override IVechicle CreateVechicle()
    {
        return new Car();
    }
}

public class ShipFactor:VechicleFactory
{
    public override IVechicle CreateVechicle()
    {
        return new ship();
    }
}