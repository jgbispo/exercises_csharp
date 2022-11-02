namespace ParkingLot
{
  class Automobiles
  {
    // Properties
    private string board;
    private string color;

    // Constructor
    public Automobiles(string board, string color)
    {
      this.board = board;
      this.color = color;
    }

    // Methods
    public string Board
    {
      get { return board; }
    }

    public string Color
    {
      get { return color; }
    }
  }
}