namespace Test;

public enum Orderstatus
{
    processing,
    shipped,
    delivered
}

public class Order
{
  public  Orderstatus status =  Orderstatus.shipped;
}