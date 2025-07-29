namespace Test;

public class Distance
{
    public double feet;
    public double inches;

    public Distance(double f, double i)
    {
        feet=f;
        inches=i;
    }

    public static Distance operator +(Distance d1, Distance d2)
    {
        Distance d3 = new Distance(d1.feet+d2.feet, d1.inches+d2.inches);
        return d3;
    }
    
}