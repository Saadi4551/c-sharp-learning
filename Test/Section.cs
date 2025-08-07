namespace Test;

interface section1
{
    void interfacemethod1();
}
interface section2
{
    void interfacemethod2();
}

interface section3 : section2 
{
    void interfacemethod3();
}


class B: section3
{
  public void interfacemethod1()
    {
        Console.WriteLine("this is method 1 of interfacemethod1");
    }
  public void interfacemethod2()
    {
        Console.WriteLine("this is method 2 of interfacemethod2");
    }
    public void interfacemethod3()
    {
        Console.WriteLine("this is method 3 of interfacemethod3");
    }
}