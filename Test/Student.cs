namespace Test;

public struct Student
{
    public string Name;
    public int Age;
    public int marks;

    public void call(int Age, string name, int marks)
    {
        this.Age = Age;
        this.Name = name;
        this.marks = marks;
    }

    public void Studenta()
    {
        Console.WriteLine(Age);
        Console.WriteLine(Name);
        Console.WriteLine(marks);
        
    }
}