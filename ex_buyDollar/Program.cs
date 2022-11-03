using System.Globalization;

namespace BuyDollar
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("What is the dollar price? ");
      double dollar = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
      Console.Write("How many dollars will be bought? ");
      double amount = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
      Console.WriteLine("Amount to be paid in real = " + Buy.Converter(dollar, amount).ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}