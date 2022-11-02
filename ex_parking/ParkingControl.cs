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

    public void removeVacancyByBoard(string board)
    {
      for (int i = 0; i < this.vacancies.Length; i++)
      {
        if (this.vacancies[i] != null)
        {
          if (this.vacancies[i].Automobiles.Board == board)
          {
            this.vacancies[i].ExitTime = DateTime.Now;
            ShowVacanciesByBoard(board);
            CalcTimeByBoard(board);
            AmountPayable(board);
            this.vacancies[i] = null;
            break;
          }
        }
      }
    }

    public void CalcTimeByBoard(string board)
    {
      for (int i = 0; i < this.vacancies.Length; i++)
      {
        if (this.vacancies[i] != null)
        {
          if (this.vacancies[i].Automobiles.Board == board)
          {
            TimeSpan time = this.vacancies[i].ExitTime - this.vacancies[i].EntryTime;
            Console.WriteLine("Time: " + time);
            break;
          }
        }
      }
    }

    public void AmountPayable(string board)
    {
      for (int i = 0; i < this.vacancies.Length; i++)
      {
        if (this.vacancies[i] != null)
        {
          if (this.vacancies[i].Automobiles.Board == board)
          {
            TimeSpan time = this.vacancies[i].ExitTime - this.vacancies[i].EntryTime;
            double amount = time.TotalHours * 5;
            Console.WriteLine("Amount payable: " + amount);
          }
        }
      }
    }

    public void ShowVacanciesByBoard(string board)
    {
      for (int i = 0; i < this.vacancies.Length; i++)
      {
        if (this.vacancies[i] != null)
        {
          if (this.vacancies[i].Automobiles.Board == board)
          {
            Console.WriteLine("Board: " + this.vacancies[i].Automobiles.Board);
            Console.WriteLine("Color: " + this.vacancies[i].Automobiles.Color);
            Console.WriteLine("Name: " + this.vacancies[i].Persons.Name);
            Console.WriteLine("CPF: " + this.vacancies[i].Persons.Document);
            Console.WriteLine("Entry time: " + this.vacancies[i].EntryTime);
            Console.WriteLine("Exit time: " + this.vacancies[i].ExitTime);
            break;
          }
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
          Console.WriteLine("Entry Time: " + this.vacancies[i].EntryTime);
          Console.WriteLine();
        }
      }
    }
  }
}