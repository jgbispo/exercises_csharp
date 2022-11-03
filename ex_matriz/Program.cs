namespace matriz
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] matriz;

      Console.Write("Enter the amount of row and column: ");
      string input = Console.ReadLine()!;
      int row = int.Parse(input.Split(' ')[0]);
      int column = int.Parse(input.Split(' ')[1]);
      matriz = new int[row, column];

      for (int i = 0; i < row; i++)
      {
        Console.Write($"Enter the matriz value from line {i}: ");
        string matrizInput = Console.ReadLine()!;
        for (int k = 0; k < column; k++)
        {
          matriz[i, k] = int.Parse(matrizInput.Split(' ')[k]);
        }
      }

      Console.Write("Enter the value you want to see in the matriz: ");
      int value = int.Parse(Console.ReadLine()!);

      for (int i = 0; i < row; i++)
      {
        for (int j = 0; j < column; j++)
        {
          if (matriz[i, j] == value)
          {
            Console.WriteLine($"Position {i}, {j}:");
            if (j > 0)
            {
              Console.WriteLine($"Left: {matriz[i, j - 1]}");
            }
            if (i > 0)
            {
              Console.WriteLine($"Up: {matriz[i - 1, j]}");
            }
            if (j < column - 1)
            {
              Console.WriteLine($"Right: {matriz[i, j + 1]}");
            }
            if (i < row - 1)
            {
              Console.WriteLine($"Down: {matriz[i + 1, j]}");
            }
            Console.WriteLine();
          }
        }
      }
    }
  }
}