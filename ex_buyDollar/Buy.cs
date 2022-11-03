namespace BuyDollar
{
  class Buy
  {
    private static double iof = 6.0;

    public static double Converter(double dollar, double amount)
    {
      return (dollar * amount) * (iof / 100 + 1);
    }
  }
}