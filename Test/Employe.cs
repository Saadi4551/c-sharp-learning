using System.Diagnostics.Contracts;

namespace Test;

public class Employe
{
    public int Id; 
    public string Name;

    public string Val { get; set; }

    public Employe(int  id, string name, string val) // Parameterized ctor
    {
        Id = id;
        Name = name;
        Val = val;
    }

    public Employe() // Default ctor
    {
        
    }

    public void Empdetail()
    {
        Console.WriteLine("the id of employee detail {0} : {1}", Id, Val);
        Console.WriteLine("the name of employee detail {0}",Name);    
    }
}