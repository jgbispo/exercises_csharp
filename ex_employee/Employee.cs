namespace EmployeeTax
{
  class Employee
  {
    // Fields
    private string name;
    private double salary;
    private double tax;

    // Constructor
    public Employee(string name, double salary, double tax)
    {
      this.name = name;
      this.salary = salary;
      this.tax = tax;
    }

    // Methods
    public double NetSalary()
    {
      return salary - tax;
    }

    public void IncreaseSalary(double percentage)
    {
      salary += salary * percentage / 100;
    }

    public override string ToString()
    {
      return name + ", $" + NetSalary().ToString("F2");
    }
  }
}