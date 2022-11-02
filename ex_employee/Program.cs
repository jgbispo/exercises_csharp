using System;

namespace EmployeeTax
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", 2000.00, 500.00);
            Console.WriteLine(employee);
            Console.Write("Enter the percentage to increase salary: ");
            double percentage = double.Parse(Console.ReadLine()!);
            employee.IncreaseSalary(percentage);
            Console.WriteLine(employee);
        }
    }
}