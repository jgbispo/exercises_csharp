namespace Company
{
  class Program
  {
    static void Main(string[] args)
    {
      Employee[]? employees;
      Console.WriteLine("How many employees do you want to enter?");
      int n = int.Parse(Console.ReadLine()!);
      employees = new Employee[n];

      for (int i = 0; i < n; i++)
      {
        Console.Clear();
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine()!);
        Console.Write("Name: ");
        string name = Console.ReadLine()!;
        Console.Write("Salary: ");
        int salary = int.Parse(Console.ReadLine()!);
        employees[i] = new Employee(name, salary, id);
        Console.WriteLine();
      }
      Console.Clear();
      Console.Write("Enter the employee id that will have salary increase: ");
      int idIncrease = int.Parse(Console.ReadLine()!);
      int pos = Position(employees, idIncrease);
      if (pos == -1)
      {
        Console.WriteLine("This id does not exist!");
      }
      else
      {
        Console.Clear();
        Console.Write("Enter the percentage: ");
        double percentage = double.Parse(Console.ReadLine()!);
        double newSalary = employees[pos].Salary + (employees[pos].Salary * percentage / 100);
        employees[pos].IncrementSalary(newSalary);
        employees[pos].Print();
      }
    }

    static int Position(Employee[] employees, int id)
    {
      for (int i = 0; i < employees.Length; i++)
      {
        if (employees[i].Id == id)
        {
          return i;
        }
      }
      return -1;
    }
  }
}