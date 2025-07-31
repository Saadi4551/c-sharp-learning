using System.Net.Security;

namespace Test;

public class Persun
{
    public void greet(string name)
    {
        Console.WriteLine("hello {0}: ",name);
    }

    public void greet(string name, string fullname)
    {
        Console.WriteLine("hello {0}:  and name is {1}: ",name,fullname);
    }

    public void greet(string name, int age)
    {
        Console.WriteLine("name is {0} and you are 25 year old {1}: ", name, age);
    }
}