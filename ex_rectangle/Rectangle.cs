namespace RectangleExercise
{
  class Rectangle
  {
    public int Length { get; set; }
    public int Width { get; set; }

    public Rectangle(int length, int width)
    {
      Length = length;
      Width = width;
    }

    public int Area
    {
      get
      {
        return Length * Width;
      }
    }

    public int Perimeter
    {
      get
      {
        return 2 * (Length + Width);
      }
    }

    public int Diagonal
    {
      get
      {
        return (int)Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2));
      }
    }

    public override string ToString()
    {
      return $"Length: {Length}, Width: {Width}";
    }


  }
}