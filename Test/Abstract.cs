namespace Test;

abstract class Abstract
{
    public void highway()
    {
        Console.WriteLine("this is a simple method");
    }
    public abstract void speed();
}

class car : Abstract
{
    public override void speed()
    {
        Console.WriteLine("the speed of this car is 40km/h");
    }
}

class bus : Abstract
{
    public override void speed()
    {
        Console.WriteLine("the speed of this bus is 80km/h");
    }
}