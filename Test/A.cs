namespace Test;

public class A
{
     //destructor//
     int id;
     string name;

     public A(int id, string name)
     {
          this.id = id;
          this.name = name;
     }
     public void emplymentinfo()
     {
          Console.WriteLine("the id of class A {0}",id);
          Console.WriteLine("the name of class A {0}",name);
     }
     ~A()
     {
          Console.WriteLine("constructor called");
     }
}
