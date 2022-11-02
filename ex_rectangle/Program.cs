using System;

namespace RectangleExercise
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter the length of the rectangle: ");
      int length = int.Parse(Console.ReadLine()!);
      Console.Write("Enter the width of the rectangle: ");
      int width = int.Parse(Console.ReadLine()!);

      Rectangle rectangle = new Rectangle(length, width);

      Console.WriteLine($"Area: {rectangle.Area}");
      Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
      Console.WriteLine($"Diagonal: {rectangle.Diagonal}");
    }
  }
}