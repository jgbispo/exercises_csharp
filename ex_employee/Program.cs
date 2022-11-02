using System;

namespace EmployeeTax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Take the name of the employee: ");
            string name = Console.ReadLine()!;
            Console.Write("Take the salary of the employee: ");
            double salary = double.Parse(Console.ReadLine()!);
            Console.Write("Take the tax of the employee: ");
            double tax = double.Parse(Console.ReadLine()!);
            Employee employee = new Employee(name, salary, tax);
            Console.WriteLine();
            Console.WriteLine("Employee: " + employee);
            Console.Write("Enter the percentage to increase salary: ");
            double percentage = double.Parse(Console.ReadLine()!);
            employee.IncreaseSalary(percentage);
            Console.WriteLine(employee);
        }
    }
}