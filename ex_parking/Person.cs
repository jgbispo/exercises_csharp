namespace ParkingLot
{
  class Person
  {
    // Properties
    private string name;
    private string document;
    private string phone;

    // Constructor
    public Person(string name, string document, string phone)
    {
      this.name = name;
      this.document = document;
      this.phone = phone;
    }

    // Methods
    public string Name
    {
      get { return name; }
    }

    public string Document
    {
      get { return document; }
    }

    public string Phone
    {
      get { return phone; }
    }
  }
}