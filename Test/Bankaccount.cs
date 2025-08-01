using System.Runtime.InteropServices.Marshalling;

namespace Test;

abstract class Bankaccount
{
    public abstract double CalculateInterest();

    public void displayinfo(string Name)
    {
        Console.WriteLine($"account holder: {Name}");
    }
}

class savingaccount : Bankaccount
{
    private double amount;
    private  double interest;

    public savingaccount(double interest,  double amount)
    {
        this.interest = interest;
        this.amount = amount;
    }

    public override double CalculateInterest()
    {
        return (interest * amount) / 100;
    }
}

class currentaccount : Bankaccount
{
    private double amount;
    private double interest;

    public currentaccount(double interest,  double amount)
    {
        this.amount = amount;
        this.interest = interest;
    }

    public override double CalculateInterest()
    {
        return(amount * interest)/100;
    }
}