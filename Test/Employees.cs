namespace Test;

abstract class Employees
{
    public abstract double calculateSalary();

    public void displayinfo(string Name)
    {
        Console.WriteLine($"employee:  {Name}");
    }
}

class fulltimeemployee: Employees
{
    private double monthlysalary;

    public fulltimeemployee(double monthlySalary)
    {
        monthlysalary = monthlySalary;
    }

    public override double calculateSalary()
    {
        return monthlysalary;
    }
}

class parttimeemployee : Employees
{
    private double hourrate;
    private int hourworked;

    public parttimeemployee(double rate, int worked)
    {
        hourrate = rate;
        hourworked = worked;
    }

    public override double calculateSalary()
    {
        return hourworked * hourrate;
    }
}