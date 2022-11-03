namespace Company
{
  class Employee
  {
    private string name;
    private double salary;
    private int id;

    public Employee(string name, double salary, int id)
    {
      this.name = name;
      this.salary = salary;
      this.id = id;
    }

    public void Print()
    {
      Console.WriteLine("Name: " + Name);
      Console.WriteLine("Salary: " + Salary);
      Console.WriteLine("Id: " + Id);
      Console.WriteLine();
    }

    public void IncrementSalary(double amount)
    {
      Salary += amount;
    }

    // Getters and setters
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public double Salary
    {
      get { return salary; }
      set { salary = value; }
    }

    public int Id
    {
      get { return id; }
      set { id = value; }
    }
  }
}