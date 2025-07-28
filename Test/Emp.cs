namespace Test;

public class Emp
{
    //operator overloading

    public int id;
    public string name;

    public static Emp operator +(Emp obj1, Emp obj2)
    {
        Emp obj3 = new Emp();
        obj3.id = obj1.id + obj2.id;
        obj3.name = obj1.name + obj2.name;
        return obj3;
    }
}