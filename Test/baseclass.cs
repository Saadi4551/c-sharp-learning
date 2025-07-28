namespace Test;

/*public class baseclass
{
    public void method()
    {
        Console.WriteLine("this is a base class ");
    }
}

class childclass : baseclass
{
    public void method()
    {
        base.method();
        Console.WriteLine("this is a child class ");
    }
}*/



public class baseclass
{
    public virtual void method()
    {
        Console.WriteLine("this is a base class ");
    }
}

class childclass : baseclass
{
    public override void method()
    {
       base.method();
        Console.WriteLine("this is a child class ");
    }
}



