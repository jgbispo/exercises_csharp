namespace ParkingLot
{
  class ParkingControl
  {
    private Vacancy[] vacancies; // Array of vacancies

    // Constructor
    public ParkingControl(int vacancies)
    {
      this.vacancies = new Vacancy[vacancies];
    }

    // Methods
    public void AddVacancy(Person persons, Automobiles automobiles)
    {
      for (int i = 0; i < this.vacancies.Length; i++)
      {
        if (this.vacancies[i] == null)
        {
          this.vacancies[i] = new Vacancy(persons, automobiles);
          break;
        }
      }
    }

    public void ShowVacanciesEmpty()
    {
      for (int i = 0; i < this.vacancies.Length; i++)
      {
        if (this.vacancies[i] == null)
        {
          Console.WriteLine("Vacancy: " + i + " is empty");
        }
      }
    }

    public void ShowVacanciesFull()
    {
      for (int i = 0; i < this.vacancies.Length; i++)
      {
        if (this.vacancies[i] != null)
        {
          Console.WriteLine("Vacancy: " + i);
          Console.WriteLine("Person: " + this.vacancies[i].Persons.Name);
          Console.WriteLine("Automobile: " + this.vacancies[i].Automobiles.Board);
          Console.WriteLine("Color: " + this.vacancies[i].Automobiles.Color);
          Console.WriteLine();
        }
      }
    }
  }
}