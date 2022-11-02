namespace ParkingLot
{
  class Vacancy
  {
    // Properties
    private Person persons;
    private Automobiles automobiles;

    // Constructor
    public Vacancy(Person persons, Automobiles automobiles) 
    {
      this.persons = persons;
      this.automobiles = automobiles;
    }

    // Methods
    public Person Persons
    {
      get { return persons; }
    }

    public Automobiles Automobiles
    {
      get { return automobiles; }
    }

  }
}