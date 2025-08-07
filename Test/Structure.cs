namespace Test;

public struct Structure
{
    public int ID;
    public string name;

    public void call(int ID, string name)
    {
        this.ID = ID;
        this.name = name;
    }

    public void StructuteA()
    {
        Console.WriteLine(name);
        Console.WriteLine(ID);
    }
}