namespace Test;

abstract class shapess
{
    public abstract double calculatearea();

    public void dislayshape(string name)
    {
        Console.WriteLine($"shapes: {name} ");
    }
}

class rectangle:shapess
{
    private double width;
    private double length;

    public rectangle(double width, double length)
    {
        this.length=length;
        this.width=width;
    }

    public override double calculatearea()
    {
        return length * width;
    }
}

class circle : shapess
{
    private int radius;
    private double pie;

    public circle(int radius, double p)
    {
        this.radius=radius;
        this.pie = p;
    }

    public override double calculatearea()
    {
        return radius * radius * pie;
    }
}