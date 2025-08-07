namespace Test;

public struct Points
{
    public int x;
    public int y;

    public Points(int xval, int yval)
    {
        x = xval;
        y = yval;
    }

    public void move(int dx, int dy)
    {
        x += dx;
        y += dy;
    }

    public void display()
    {
        Console.WriteLine($"points is at {x},{y}");
    }
}